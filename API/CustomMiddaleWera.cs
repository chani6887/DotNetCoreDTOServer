using Microsoft.AspNetCore.Http;
namespace API
{
    public class CustomMiddaleWera
    {
        private readonly RequestDelegate _next;
        public CustomMiddaleWera(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                await httpContext.Response.WriteAsync("****  CurrentCulture.DisplayName:  {CultureInfo.CurrentCulture.DisplayName}");
                return;
            }
            await _next(httpContext);
        }
    }
    public static class ShabatMiddlewareExtensions
    {
        public static IApplicationBuilder useShabbat(this IApplicationBuilder builder )
        {
            return builder.UseMiddleware<CustomMiddaleWera>();
        }
    }
}
