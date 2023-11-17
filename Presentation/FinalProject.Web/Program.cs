using FinalProject.Application.Extensions;
using FinalProject.Infrastructure.Extensions;
using FinalProject.Persistence.Extentions;
using FinalProject.Web.Extensions;

namespace FinalProject.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddConfigurationApplicationServices(builder.Configuration);
            builder.Services.AddPersitenceConfigureService(builder.Configuration);
            builder.Services.AddConfigurationInfrastructurService(builder.Configuration);
            builder.Services.AddPresentatioConfigurationService(builder.Configuration);


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseExeptionHandling();


            app.UseRouting();

            app.UseAuthorization();


            app.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}