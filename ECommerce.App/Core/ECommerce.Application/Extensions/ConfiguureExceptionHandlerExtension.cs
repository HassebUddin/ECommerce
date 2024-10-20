

using ECommerce.Domain.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Mime;
using System.Text.Json;

namespace ECommerce.Application.Extensions
{
    public  static class ConfiguureExceptionHandlerExtension
    {
        public static void ConfiguureExceptionHandler<T>(this WebApplication application,ILogger<T> logger)
        {

            application.UseExceptionHandler(builder =>
            {
                builder.Run(async context=>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = MediaTypeNames.Application.Json;

                    var contextFeatures = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeatures != null)
                    {
                        logger.LogError(contextFeatures.Error.Message);

                        await context.Response.WriteAsync(JsonSerializer.Serialize(new
                        {
                            Status = context.Response.StatusCode,
                            Message = contextFeatures.Error.Message
                        }));

                    }
                });
            });
          
        }
    }
}
