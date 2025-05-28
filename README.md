# sql server 2025
```
docker pull mcr.microsoft.com/mssql/server:2025-latest

docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=PAssWoRd123..@" -p 1433:1433 --name dedsiaspire-mssql2025 --restart=on-failure:10 -d mcr.microsoft.com/mssql/server:2025-latest
```

## 创建数据库
```
create DataBase DedsiServiceADB
go

create DataBase DedsiServiceBDB
go

create DataBase DedsiServiceCDB
go

create DataBase DedsiAuthCenterDB
go

use DedsiServiceADB
go

use DedsiServiceBDB
go

use DedsiServiceCDB
go

use DedsiAuthCenterDB
go
```