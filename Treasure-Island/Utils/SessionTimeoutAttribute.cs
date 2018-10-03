using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vs_project.Utils
{
    public class SessionTimeoutAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext ctx = HttpContext.Current;
            if (HttpContext.Current.Session["ID"] == null)
            {
                filterContext.Result = new RedirectResult("Promos");
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}