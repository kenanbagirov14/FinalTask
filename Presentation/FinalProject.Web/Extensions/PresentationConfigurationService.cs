using FinalProject.Domain.Entities.General;
using FinalProject.Web.Areas.Admin.ServiceFacades;
using FinalProject.Web.ServiceFacades;

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
            services.AddScoped<HomeserviceFacade>();
            services.AddHttpContextAccessor();
            return services;
        }
    }
}
