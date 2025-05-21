using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace TonProjet.Filters
{
    public class MyLogFilterAttribute : ActionFilterAttribute
    {
        private readonly ILogger<MyLogFilterAttribute> _logger;

        public MyLogFilterAttribute(ILogger<MyLogFilterAttribute> logger)
        {
            _logger = logger;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("Action is about to be executed"); // Log info
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogWarning("Action has now been executed"); // Log warning
            base.OnActionExecuted(context);
        }
    }
}
