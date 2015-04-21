using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Route.Controllers
{
    public class BaseControl:Controller
    {
        protected override void ExecuteCore()
        {
            base.ExecuteCore();
        }
        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            if (filterContext.RouteData.Values.Count>2&& filterContext.RouteData.Values["category"].ToString() == "xiaoyayun")
            {
               // RedirectToAction("xiaoyayun", "home");
                Redirect("/home/xiaoyayun");
            }
          //  base.OnActionExecuted(filterContext);
        }
    }
}