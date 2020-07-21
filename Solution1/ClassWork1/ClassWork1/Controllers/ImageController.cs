using System.IO;
using System.Web.Mvc;

namespace ClassWork1.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Image(string id)
        {
            var dir = Server.MapPath("/Images");
            var path = Path.Combine(dir, id + ".jpg");
            return File(path, "image/jpeg");
        }
    }
}