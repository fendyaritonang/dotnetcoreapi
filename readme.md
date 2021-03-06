## Create new project of .Net Core WebAPI
dotnet new webapi -n Commander

## Generate initial migration (this won't update database)
dotnet ef migrations add InitialMigration

## Execute initial migration script
dotnet ef database update

## Nuget packages to install
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection
Install-Package Microsoft.AspNetCore.JsonPatch
Install-Package Microsoft.AspNetCore.Mvc.NewtonsoftJson
