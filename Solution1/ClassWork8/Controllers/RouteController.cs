using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassWork8.Controllers
{
    public class RouteController : Controller
    {
        // GET: Route
        public ActionResult Sum(int x, int y)
        {
            return Content($"{x+y}");
        }
    }
}