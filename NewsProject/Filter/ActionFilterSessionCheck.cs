using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace NewsProject.Filter
{
    public class ActionFilterSessionCheck : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var userId = context.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary {
                        { "action","Index"},
                        { "controller","Account"}
                    });
            }
            //if (context.HttpContext.User.Identity.IsAuthenticated)
            //{
            //    context.Result = new RedirectToActionResult("Index","Home",new {area="User" });

            //}



            base.OnActionExecuting(context);
        }
    }
}
