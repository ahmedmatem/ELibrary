using ELibrary.Core.Automapper;
using ELibrary.Web.Automapper;
using ELibrary.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace ELibrary.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddApplicationDbContext(builder.Configuration);

            builder.Services.AddApplicationIdentity();

            builder.Services.AddApplicationServices();

            builder.Services.AddAutoMapper(
                typeof(WebMappingProfile).Assembly,
                typeof(CoreMappingProfile).Assembly);
            
            // Add services to the container.
            builder.Services.AddControllersWithViews(options =>
            {
                options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapAreaControllerRoute(
                name: "Admin",
                areaName: "Admin",
                pattern: "admin/{controller=Home}/{action=Index}/{id?}");
            app.MapAreaControllerRoute(
                name: "Teacher",
                areaName: "Teacher",
                pattern: "teacher/{controller=Home}/{action=Index}/{id?}");
            app.MapAreaControllerRoute(
                name: "Student",
                areaName: "Student",
                pattern: "student/{controller=Home}/{action=Index}/{id?}");

            app.MapDefaultControllerRoute();

            app.MapRazorPages();

            app.Run();
        }
    }
}
