using System.Web.Mvc;

namespace ClassWork1.Controllers
{
    public class RedirectController : Controller
    {
        // GET: Redirect
        public ActionResult Index()
        {
            return View();
        }
        public RedirectResult RedirectGoogle()
        {
            return Redirect("https://google.com");
        }
        public ActionResult RedirectCurrentDateAndTime()
        {
            return RedirectToAction("CurrentDateAndTime", "CurrentDateAndTime");
        }
    }
}