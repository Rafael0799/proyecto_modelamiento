# Calculadora de Contaminación en Ríos

Aplicación web para calcular la carga de contaminantes en tramos de río mediante métodos numéricos.

## Estructura del Proyecto

- **Controllers/**: Controladores MVC
- **Models/**: Modelos de datos
- **Services/**: Servicios de cálculo (Trapecio y Simpson)
- **Views/**: Vistas Razor
- **Tests/**: Pruebas unitarias

## Configuración del Desarrollo

1. Requisitos previos:
   - Visual Studio 2022
   - .NET 7.0 SDK o superior

2. Clonar el repositorio:
   ```bash
   git clone <url-repositorio>
   cd proyecto_modelamiento
   ```

3. Restaurar paquetes NuGet:
   ```bash
   dotnet restore
   ```

4. Ejecutar la aplicación:
   ```bash
   dotnet run
   ```

## Funcionalidades

- Cálculo de integral mediante método del Trapecio
- Cálculo de integral mediante método de Simpson
- Visualización de resultados numéricos y gráficos
- Validación de datos de entrada

## Pruebas

Ejecutar pruebas unitarias:
```bash
dotnet test
```