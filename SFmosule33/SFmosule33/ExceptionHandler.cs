using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SFmosule33
{
    public class ExceptionHandler : ActionFilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var message = "Произошла непредвиденная ошибка!";

            if (context.Exception is CustomException)
            {
                message = context.Exception.Message;
            }
            context.Result = new BadRequestObjectResult(message);
        }
    }
}
