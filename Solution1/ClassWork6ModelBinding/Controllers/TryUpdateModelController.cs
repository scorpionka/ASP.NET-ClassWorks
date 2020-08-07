using ClassWork6ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassWork6ModelBinding.Controllers
{
    public class TryUpdateModelController : Controller
    {
        // GET: TryUpdateModel
        //TryUpdateModel/IndexIncludePriceYear?Title=MyLife&Price=3.56&Count=2&Year=2009

        public ActionResult IndexIncludePriceYear([Bind(Include = "Price, Year")] BookViewModel bookViewModel)
        {
            return Json(new { bookViewModel }, JsonRequestBehavior.AllowGet);
        }

        //TryUpdateModel/IndexExcludeTitle?Title=MyLife&Price=3.56&Count=2&Year=2009
        public ActionResult IndexExcludeTitle([Bind(Exclude = "Title")] BookViewModel bookViewModel)
        {
            return Json(new { bookViewModel }, JsonRequestBehavior.AllowGet);
        }

        //TryUpdateModel/IndexUpdateAll?Title=MyLife&Price=3.56&Count=2&Year=2009
        public ActionResult IndexUpdateAll()
        {
            var bookViewModel = new BookViewModel();
            TryUpdateModel(bookViewModel);
            return Json(new { bookViewModel }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult IndexUpdateFromDatabase()
        {
            var bookViewModel = new BookViewModel();
            studentViewModel.DataFromDB = "IndexV3";
            TryUpdateModel(bookViewModel);
            return Json(new { bookViewModel }, JsonRequestBehavior.AllowGet);
        }
    }
}