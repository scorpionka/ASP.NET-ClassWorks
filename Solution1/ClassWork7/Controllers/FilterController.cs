using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassWork7.Controllers
{
    public class FilterController : Controller
    {
        public ActionResult Sum(int a, int b)
        {
            return Json(new Sum { Value = a + b });
        }
    }
}