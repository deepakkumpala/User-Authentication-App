# Resilient User Authentication Application

**Concepts covered**
 
1. **ASP.NET Core MVC:** A powerful and open-source web framework for building modern, dynamic, and cross-platform web applications using the ASP.NET framework.

2. **Identity (ASP.NET Core Identity):** A membership system that adds login functionality to ASP.NET Core applications, providing user authentication, authorization, and account management features.

3. **PostgreSQL:** An advanced, open-source relational database management system known for its extensibility, standards compliance, and robust support for complex queries, making it a popular choice for web applications.

4. **Migrate** -  Migrating your ASP.NET Core MVC application from SQL Server to PostgreSQL can bring flexibility and scalability to your database. In this guide, I will walk through the process, covering key steps to ensure a smooth transition.


Follow the below steps


## Step 1: Prepare for Migration

Delete the existing Migration folder to start with a clean slate. This ensures that the new PostgreSQL migrations will be generated from scratch.

```bash
# Delete the Migration folder
rm -rf Migrations
```

## Step 2: Add Necessary NuGet Packages

To enable PostgreSQL support, add the required NuGet packages to your project file:

```xml
<!-- Microsoft.VisualStudio.Web.CodeGeneration.Design -->
<PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="7.0.11" />

<!-- Npgsql.EntityFrameworkCore.PostgreSQL -->
<PackageReference Include="Npgsql.EntityFrameworkCore.PostgreSQL" Version="7.0.0" />
```

Use the `dotnet restore` command to fetch the newly added packages.

```bash
dotnet restore
```

## Step 3: Update Connection String

Adjust the connection string in your `appsettings.json` or `appsettings.Development.json` to reflect the PostgreSQL server details:

```json
"DefaultConnection": "Host=localhost;Port=5433;Database=authentication_app;Username=postgres;Password=<YOURPASSWORD>;",
```

Ensure that the host, port, database name, username, and password match your PostgreSQL setup.

## Step 4: Modify DbContext Configuration

Replace the SQL Server configuration in your `Startup.cs` file with PostgreSQL configuration. Locate the code that configures the DbContext, and replace it as follows:

```csharp
// Replace the existing SQL Server configuration
builder.Services.AddDbContext<AuthenticationAppDbContext>(options => options.UseSqlServer(connectionString));

// With the new PostgreSQL configuration
builder.Services.AddDbContext<IdentityContext>(options => options.UseNpgsql(connectionString));
```

This change ensures that your application now uses PostgreSQL as the underlying database.

## Conclusion

Congratulations! You've successfully migrated your ASP.NET Core MVC application from SQL Server to PostgreSQL. Ensure to thoroughly test your application to verify that the migration was successful, and your functionalities remain intact.

By following these steps, you've embraced the power of PostgreSQL, providing your application with a robust and scalable database solution.


Happy coding!


