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
        private Stopwatch myStopwatch;
        public Stopwatch MyStopwatch { get; set; }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            myStopwatch.Stop();
            Debug.WriteLine($"{myStopwatch}");
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            myStopwatch.Start();
        }
    }
}