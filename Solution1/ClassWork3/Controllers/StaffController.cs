using ClassWork3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassWork3.Controllers
{
    public class StaffController : Controller
    {
        public static List<Staff> personnel = new List<Staff>()
        {
            new Staff(){FirstName = "Ivan", LastName = "Ivanov", Patronymic = "Ivanovich", BirthDay = },
            new Staff(){FirstName = "Petr", LastName = "Petrov", Patronymic = "Petrovich"},
            new Staff(){FirstName = "Alexander", LastName = "Alexandrov", Patronymic = "Alexandrovich"},
        };

        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Staff()
        {
            return View(personnel);
        }
    }
}