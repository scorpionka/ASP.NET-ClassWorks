using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassWork7.Infrastructure.Filters
{
    public class CustomActionFilter : FilterAttribute, IActionFilter
    {
        private DateTime start;
        private DateTime stop;

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            stop = DateTime.Now;
            Debug.WriteLine($"Time of action: {stop-start}");
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            start = DateTime.Now;
        }
    }
}