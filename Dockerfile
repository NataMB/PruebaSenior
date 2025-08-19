# Imagen base para compilar
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copiar la solución
COPY ./pruebasenior.sln ./

# Copiar solo los proyectos válidos
COPY ./src/pruebasenior.API/pruebasenior.API.csproj ./src/pruebasenior.API/
COPY ./src/pruebasenior.Application/pruebasenior.Application.csproj ./src/pruebasenior.Application/
COPY ./src/pruebasenior.Infrastructure/pruebasenior.Infrastructure.csproj ./src/pruebasenior.Infrastructure/

# Restaurar dependencias
RUN dotnet restore ./pruebasenior.sln

# Copiar todo el código
COPY . .

# Publicar
RUN dotnet publish ./src/pruebasenior.API/pruebasenior.API.csproj -c Release -o /app/publish

# Imagen final
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "pruebasenior.API.dll"]