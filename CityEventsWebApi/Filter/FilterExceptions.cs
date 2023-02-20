using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace CityEvents.Filter
{
    public class FilterExceptions
    {
        public class GeneralExcepetionFilter : ExceptionFilterAttribute
        {
            public override void OnException(ExceptionContext context)
            {
                var problem = new ProblemDetails
                {
                    Title = "Unexpected error",
                    Detail = "An unexpected error occurred on the request",
                    Type = context.Exception.GetType().Name
                };

                switch (context.Exception)
                {
                    case ArgumentException:
                        problem.Detail = "DataBase Error";
                        context.HttpContext.Response.StatusCode = StatusCodes.Status501NotImplemented;
                        break;
                    case NullReferenceException:
                        problem.Detail = "Object reference not set to an instance of an object";
                        context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                        break;
                    case FormatException:
                        problem.Detail = "Invalid format provided";
                        context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                        break;
                    default:
                        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                        break;
                }
                context.Result = new ObjectResult(problem);
            }
        }
    }
}
