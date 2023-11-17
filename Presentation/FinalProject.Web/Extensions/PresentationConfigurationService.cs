using FinalProject.Domain.Entities.General;
using FinalProject.Web.Areas.Admin.ServiceFacades;

namespace FinalProject.Web.Extensions
{
    public static class PresentationConfigurationService
    {
        public static IServiceCollection AddPresentatioConfigurationService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<TeacherServiceFacade>();
            services.AddScoped<CommonServiceFacade>();
            services.AddScoped<GroupServiceFacade>();
            services.AddScoped<StudentServiceFacade>();
            services.AddScoped<MessageServiceFacade>();
            services.AddScoped<SettingServiceFacade>();

            return services;
        }
    }
}
