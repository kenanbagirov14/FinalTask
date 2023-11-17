using FinalProject.Web.Middleware;

namespace FinalProject.Web.Extensions
{
    public static class PresentationMiddleware
    {
        public static IApplicationBuilder UseExeptionHandling(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExeptionHandligMiddleware>();
        }

    }
}
