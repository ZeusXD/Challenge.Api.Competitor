using Challenge.Api.Competitor.WebApi.Middlewares;
using Challenge.Api.Competitor.WebApi.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;


namespace Challenge.Api.Competitor.WebApi.Extensions
{
    public static class ConfigureExtensions 
    {
        public static void ExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.StatusCode = 500;
                    context.Response.ContentType = "application/json";
        
                    var error = context.Features.Get<IExceptionHandlerFeature>();
                    if (error != null)
                    {
                        var ex = error.Error;
        
                        await context.Response.WriteAsync(new ErrorModel()
                        {
                            StatusCode = 500,
                            ErrorMessage = ex.Message 
                        }.ToString()); //ToString() is overridden to Serialize object
                    }
                });
            });
            
        }
    
        public static IApplicationBuilder UseCustomExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExceptionMiddleware>();
        }

    }

}