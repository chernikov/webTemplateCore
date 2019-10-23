using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using webTemplate.BL;
using webTemplate.Web.Services;

namespace webTemplate.Web.Middlewares
{
    public class RequestLogMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLogMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IIdentityService identityService, IUserAuthBL userAuthBL, ILogger<RequestLogMiddleware> logger)
        {
            if (logger.IsEnabled(LogLevel.Information))
            {
                var startTime = DateTime.Now.Ticks;
                await _next.Invoke(context);

                var total = (DateTime.Now.Ticks - startTime) / 10000;
                var isError = (context.Response.StatusCode / 100) > 3;
                var principal = identityService.Restore();
                var userInfo = string.Empty;
                if (principal != null)
                {
                    var identity = (ClaimsIdentity)principal.Identity;
                    var claimsList = identity.Claims.ToList();
                    var sid = claimsList.FirstOrDefault(p => p.Type == ClaimTypes.Sid).Value;
                    if (!string.IsNullOrEmpty(sid))
                    {
                        var id = Int32.Parse(sid);
                        var user = userAuthBL.GetUserById(id);
                        userInfo = string.Empty;
                        if (user != null)
                        {
                            var role = claimsList.FirstOrDefault(p => p.Type == ClaimTypes.Role).Value;
                            var obj = new { user, role };
                            userInfo = JsonConvert.SerializeObject(obj);
                        }
                    }
                }
                var path = $"{context.Request.Path.Value.ToLower()}{context.Request.QueryString}";
                logger.LogInformation($"{(isError ? "[ERROR]" : "[REQUEST]")}\t{context.Response.StatusCode}\t{total} ms\t{context.Request.Method}: {path}\tUser : {userInfo}");
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
