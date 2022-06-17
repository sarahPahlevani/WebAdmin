using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;

namespace RealEstateAdmin
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class AuthAttribute : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var currentAction = context.RouteData.Values["action"].ToString().ToLower();
            var validAction = new List<string> { "login","forgetmypassword" };
            var userToken = context.HttpContext.Request.Cookies["token"] ?? "";
            
            if (!validAction.Contains(currentAction) && (string.IsNullOrEmpty(userToken)))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                {
                    controller = "home",
                    action = "login"
                }));
            }

        }


    }
}
