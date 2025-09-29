## commands to create database via migrations. Run in root folder(sln)
dotnet ef migrations add InitialCreate   --project ManagerProduct.Infra.Data   --startup-project ManagerProduct.WebUI

dotnet ef database update   --project ManagerProduct.Infra.Data   --startup-project ManagerProduct.WebUI