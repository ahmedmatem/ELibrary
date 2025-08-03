using Azure.Storage.Blobs;
using ELibrary.Core.Services;
using ELibrary.Infrastructure.Data;
using ELibrary.Infrastructure.Data.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ELibrary.Web.Extensions
{
    public static class ServiceExtensions
    {
        /// <summary>
        /// Registers the application-specific services with the dependency injection (DI) container.
        /// </summary>
        /// <param name="services">The service collection to which the application services will be added.</param>
        /// <returns>The updated <see cref="IServiceCollection"/> instance, enabling method chaining.</returns>
        /// <remarks>
        /// This method configures scoped lifetime services for the core application layer, 
        /// such as domain services for resources, ... and Azure Blob storage. Each service interface is mapped
        /// to its concrete implementation.
        /// </remarks>
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ELibrary.Core.Services.ResourceService, ResourceService>();

            return services;
        }

        /// <summary>
        /// Registers the <see cref="ApplicationDbContext"/> with the dependency injection (DI) container
        /// and configures it to use SQL Server with the connection string defined in the application configuration.
        /// </summary>
        /// <param name="services">The service collection to add the DbContext to.</param>
        /// <param name="configuration">The application configuration used to retrieve the connection string.</param>
        /// <returns>The updated <see cref="IServiceCollection"/>.</returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the connection string "DefaultConnection" is not found in the configuration.
        /// </exception>
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Register a singleton Azure BlobServiceClient using the connection string from configuration.
            // This client is used to interact with Azure Blob Storage throughout the application.
            services.AddSingleton(x => new BlobServiceClient(configuration.GetValue<string>("ConnectionStrings:AzureBlobStorageConnection")));

            services.AddScoped<IRepository, Repository>();

            return services;
        }

        /// <summary>
        /// Adds the default identity services with Entity Framework Core support.
        /// </summary>
        /// <param name="services">The service collection to add services to.</param>
        /// <param name="connectionString">The connection string for the database.</param>
        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services)
        {
            services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedEmail = false;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }
    }
}
