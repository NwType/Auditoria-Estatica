# Definir la ruta del proyecto
$projectPath = "./DemoAuditApp/DemoAuditApp.csproj"

Write-Host "--- Iniciando Auditoría Automática (IEEE 1028) ---" -ForegroundColor Cyan

# 1. Ejecutar el análisis de .NET (Linter y Analizadores)
# El comando 'dotnet build' usará las reglas configuradas en el .csproj
dotnet build $projectPath /warnaserror

if ($LASTEXITCODE -ne 0) {
    Write-Host "Error: La auditoría detectó problemas de calidad o seguridad." -ForegroundColor Red
    exit 1 # Esto indica al CI/CD que la prueba falló
}

Write-Host "Auditoría completada con éxito." -ForegroundColor Green
exit 0