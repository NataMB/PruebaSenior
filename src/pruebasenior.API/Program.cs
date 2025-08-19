using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

// -----------------------------
// 1. Registrar servicios
// -----------------------------
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ Recuperar conexiones con fallback (Opción 2)
var sqlConnection = builder.Configuration.GetConnectionString("DefaultConnection") 
                   ?? throw new InvalidOperationException("Missing SQL Server connection string.");

var redisConnection = builder.Configuration.GetConnectionString("Redis") 
                     ?? throw new InvalidOperationException("Missing Redis connection string.");

// HealthChecks: SQL Server + Redis
builder.Services.AddHealthChecks()
    .AddSqlServer(sqlConnection)
    .AddRedis(redisConnection);

// -----------------------------
// 2. Construir aplicación
// -----------------------------
var app = builder.Build();

// -----------------------------
// 3. Middlewares
// -----------------------------
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

// -----------------------------
// 4. Endpoints de HealthChecks
// -----------------------------
app.MapHealthChecks("/health");   // Endpoint básico
app.MapHealthChecks("/healthz");  // Alternativo

app.Run();