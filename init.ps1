Write-Host "Deteniendo contenedores previos..." -ForegroundColor Yellow
docker compose down -v

Write-Host "levantando servicios..." -ForegroundColor Cyan
docker compose up -d --build

Write-Host "Esperando a que SQL Server esté listo (20s)..." -ForegroundColor Yellow
Start-Sleep -Seconds 20

Write-Host "Aplicando migraciones" -ForegroundColor Cyan
docker compose exec api dotnet ef database update --project src/pruebasenior.Infrastructure --startup-project src/pruebasenior.API

Write-Host "listo" -ForegroundColor Green
