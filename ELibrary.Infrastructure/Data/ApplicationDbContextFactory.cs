using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ELibrary.Infrastructure.Data
{
    /// <summary>
    /// Design-time factory for creating instances of <see cref="ApplicationDbContext"/>.
    /// 
    /// This class is required by Entity Framework Core tooling (e.g., dotnet ef)
    /// to instantiate the DbContext during design-time operations like:
    /// - Applying migrations (dotnet ef migrations add / update)
    /// - Generating SQL scripts
    ///
    /// Since EF tools run outside the ASP.NET Core application host,
    /// the normal dependency injection and configuration setup (e.g., in Program.cs)
    /// is not available. This factory provides a manual way to construct the DbContext
    /// with the necessary options.
    ///
    /// The connection string is read from the "CONNECTION_STRING" environment variable,
    /// which is set dynamically during CI/CD pipeline execution in GitHub Actions.
    ///
    /// This setup is especially useful for enabling database migrations
    /// to run as part of automated deployments to Azure.
    ///
    /// Located in the ELibrary.Infrastructure project to align with the data access layer.
    /// </summary>

    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Pull connection string from env var passed by GitHub Actions
            var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("CONNECTION_STRING environment variable is not set.");
            }

            optionsBuilder.UseSqlServer(connectionString);

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
