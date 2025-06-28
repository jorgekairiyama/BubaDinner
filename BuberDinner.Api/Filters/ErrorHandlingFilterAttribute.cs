// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.Filters;

// namespace BuberDinner.Api.Filters;

// public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
// {
//     private readonly ILogger<ErrorHandlingFilterAttribute> _logger;

//     public ErrorHandlingFilterAttribute(ILogger<ErrorHandlingFilterAttribute> logger)
//     {
//         _logger = logger;
//     }

//     public override void OnException(ExceptionContext context)
//     {
//         _logger.LogError(context.Exception, "An error occurred while processing the request.");

//         var problemDetails = new ProblemDetails
//         {
//             Type = "https://httpstatuses.org/500",
//             Title = "An error occurred while processing your request.",
//             Status = StatusCodes.Status500InternalServerError,
//             Detail = context.Exception.Message,            
//             Instance = context.HttpContext.Request.Path
//         };
//         context.Result = new ObjectResult(problemDetails);

//         context.ExceptionHandled = true;
//     }
// }