using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Challenge.Api.Competitor.WebApi.Middlewares
{
    public class CustomExceptionMiddleware
    {
        //constructor and service injection
    
        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                //await _next(httpContext);
            }
            catch (Exception ex)
            {
                //_logger.LogError("Unhandled exception ...", ex);
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
        {
            throw new NotImplementedException();
        }

        //additional methods
    }

}