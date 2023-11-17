using FinalProject.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Persistence.Extentions
{
    public static class PersitenceConfigureServices
    {
        public static IServiceCollection AddPersitenceConfigureService(this IServiceCollection services, IConfiguration configuration)
        {

           // services.AddScoped<DbContext, FinalProjectDbContext>();

            services.AddDbContext<FinalProjectDbContext>(conf =>
            {
                string connectionString = configuration.GetConnectionString("FinalProjectConnectionString");
                conf.UseSqlServer(connectionString, opt =>
                {
                    opt.EnableRetryOnFailure();
                });

            });

            return services;
        }
    }
}
