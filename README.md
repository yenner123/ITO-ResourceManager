# ITO-ResourceManager
Prueba ITO-Software Net Core 5

## Crear base de datos con Docker
```docker run `
    -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Qwerty2021*" `
    --mount source=ITO-RM,target=/var/opt/mssql `
    --name ITO-RM --hostname ITO-RM `
    -p 1433:1433 `
    -d mcr.microsoft.com/mssql/server:2019-latest´```

## Generar clases entidad (Scaffold)
```Scaffold-DBContext "Server=localhost;Database=ITO-RM;user=SA;password=Qwerty2021*" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models ```
