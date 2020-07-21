using System;
using System.Globalization;
using System.Web.Mvc;

namespace ClassWork1.Controllers
{
    public class CurrentDateAndTimeController : Controller
    {
        // GET: CurrentDateAndTime
        public ActionResult Index()
        {
            return View();
        }
        public ContentResult CurrentDateAndTime()
        {
            //DateTime DateTimeNow = DateTime.UtcNow;
            //DateTimeNow = DateTimeNow.ToLocalTime();
            //return Content($"{DateTimeNow.ToString("MM")}/{DateTimeNow.ToString("dd")}/{DateTimeNow.ToString("yyyy")} " +
            //    $"{DateTimeNow.ToString("HH")}:{DateTimeNow.ToString("mm")}");
            return Content(DateTime.Now.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture));
        }
    }
}