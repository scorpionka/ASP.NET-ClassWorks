using System.Web.Mvc;

namespace ClassWork1.Controllers
{
    public class SumAndMeanController : Controller
    {
        // GET: SumAndMean
        public ActionResult Index()
        {
            return View();
        }
        public ContentResult Sum(int a, int b)
        {
            return Content($"Sum is {a + b}");
        }
        public ContentResult Mean(int a, int b)
        {
            return Content($"Mean is {(a + b) / 2}");
        }
    }
}