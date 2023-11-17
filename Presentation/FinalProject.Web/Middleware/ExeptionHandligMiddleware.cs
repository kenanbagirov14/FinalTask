namespace FinalProject.Web.Middleware
{
    public class ExeptionHandligMiddleware
    {
        public RequestDelegate _next;
        public ILogger _logger;

        public ExeptionHandligMiddleware(RequestDelegate next, ILogger<ExeptionHandligMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        
        }
    }
}
