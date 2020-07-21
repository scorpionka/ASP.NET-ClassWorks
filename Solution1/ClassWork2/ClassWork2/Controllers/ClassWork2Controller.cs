using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassWork2.Controllers
{
    public class ClassWork2Controller : Controller
    {
        // GET: ClassWork2
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase data)
        {
            var file = Request.Files["file"];
            var length = file.ContentLength;
            var fileType = file.ContentType;
            var name = file.FileName;
            var stream = file.InputStream;
            return Content($"Upload done!");
        }
        public ContentResult Operation(int[] numbers, string operation)
        {
            return Content($"Empty");
        }
    }
}