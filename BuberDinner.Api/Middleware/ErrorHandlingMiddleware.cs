// using System.Net;
// using System.Text.Json;

// namespace BuberDinner.Api.Middleware;

// public class ErrorHandlingMiddleware
// {
//     private readonly RequestDelegate _next;
//     private readonly ILogger<ErrorHandlingMiddleware> _logger;

//     public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
//     {
//         _next = next;
//         _logger = logger;
//     }

//     public async Task InvokeAsync(HttpContext context)
//     {
//         try
//         {
//             await _next(context);
//         }
//         catch (Exception ex)
//         {
//             _logger.LogError(ex, "An error occurred while processing the request.");
//             await HandleExceptionAsync(context, ex);
//         }
//     }

//     private static Task HandleExceptionAsync(HttpContext context, Exception ex)
//     {
//         var code = HttpStatusCode.InternalServerError; // 500 if unexpected
//         var result = JsonSerializer.Serialize(new
//         {
//             error = "An unexpected error occurred while processing your request.",
//             details = ex.Message
//         });
//         context.Response.ContentType = "application/json";
//         context.Response.StatusCode = (int)code;

//         return context.Response.WriteAsync(result);
//     }
// }
