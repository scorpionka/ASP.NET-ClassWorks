using ClassWork7.Infrastructure.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassWork7.Controllers
{
    public class FilterController : Controller
    {
        [CustomResultFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}