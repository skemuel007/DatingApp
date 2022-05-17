# REST Dating App

## To configure DB for app settings
1. Open the project in a terminal and run the following command `dotnet user-secrets init` - This creates user secrets for development
2. Run this command to save connection string
`dotnet user-secrets set "ConnectionString:DataContext" "Server=localhost\\SQLEXPRESS;Database=;User ID=sa;Password=;"` - Please add your db name and password

## To run a migration
1. `dotnet ef migrations add InitialCreate -o Data/Migrations`
2. `dotnet ef database update`