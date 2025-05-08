using DotNetCoreWebAPI.Services;

namespace DotNetCoreWebAPI.Middleware
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;
        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        // IMessageWriter is injected into InvokeAsync
        public async Task InvokeAsync(HttpContext httpContext, IMessageWriter svc)
        {
            svc.Write(DateTime.Now.Ticks.ToString());
            await _next(httpContext);
        }
    }
}
