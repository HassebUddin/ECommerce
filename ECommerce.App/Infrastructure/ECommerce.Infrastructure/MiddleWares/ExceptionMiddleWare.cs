
using ECommerce.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System.Net;
using System.Text.Json;

namespace ECommerce.Infrastructure.MiddleWares
{
    public class ExceptionMiddleWare
    {

        private readonly RequestDelegate next;
        private readonly IHostEnvironment _env;
        public ExceptionMiddleWare(RequestDelegate next, IHostEnvironment env)
        {
            this.next = next;
            _env = env;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var code = (int)HttpStatusCode.BadRequest; // 400 if unexpected
            var response = _env.IsDevelopment()
                ? new ApiExceptionModel(ex.Message, code, ex.StackTrace!)
                : new ApiExceptionModel("something went wrong", code);

            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = code;

            var jsonResponse = JsonSerializer.Serialize(response, options);
            return context.Response.WriteAsync(jsonResponse);
        }
    }
}
