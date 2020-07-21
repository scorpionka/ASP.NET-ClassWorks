using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace ClassWork2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Upload()
        {
            return View("Upload");
        }

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase upload)
        {
            if (upload != null)
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "Files/";
                string fileName = Path.GetFileName(upload.FileName);
                upload.SaveAs(Path.Combine(path, fileName));
                return Content($"Done!");
            }
            else
            {
                return Content($"Nothing!");
            }
        }
    }
}