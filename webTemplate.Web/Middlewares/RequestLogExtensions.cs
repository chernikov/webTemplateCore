using Microsoft.AspNetCore.Builder;

namespace webTemplate.Web.Middlewares
{
    public static class RequestLogExtensions
    {
        public static IApplicationBuilder UseRequestLog(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestLogMiddleware>();
        }
    }
}
