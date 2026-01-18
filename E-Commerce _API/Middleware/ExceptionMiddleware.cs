using Microsoft.AspNetCore.Mvc;

namespace E_Commerce__API.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IHostEnvironment _env;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger, IHostEnvironment env)
        {
            _next = next;
            _logger = logger;
            _env = env;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)System.Net.HttpStatusCode.InternalServerError;

                var response = new ProblemDetails
                { 
                    Status = context.Response.StatusCode,
                    Detail = _env.IsDevelopment() ? ex.StackTrace?.ToString() : null,
                    Title = "An unexpected error occurred!"
                };

                var options = new System.Text.Json.JsonSerializerOptions { PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase };
                
                var json = System.Text.Json.JsonSerializer.Serialize(response, options);
                
                await context.Response.WriteAsync(json);
            }
        }
    }
}
