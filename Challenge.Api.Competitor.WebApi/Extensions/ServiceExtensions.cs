using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;
using Challenge.Api.Competitor.WebApi.ActionFilters;

namespace Challenge.Api.Competitor.WebApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                    // .WithOrigins("http://example.com",
                    //             "http://www.contoso.com")
                    //.WithHeaders(HeaderNames.ContentType, "x-custom-header")
                    );
            }); 
        }

        public static void ConfigureDependecys(this IServiceCollection services)
        {   
            //services.AddSingleton<ITodoLogic,TodoLogic>();
            //services.AddScoped<ITodoLogic,TodoLogic>();
            //services.AddTransient<ITodoLogic,TodoLogic>();
            	
            services.AddScoped<ModelValidationAttribute>();
        }
    }
}