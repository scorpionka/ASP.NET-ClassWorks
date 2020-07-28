using ClassWork3.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ClassWork3.Controllers
{
    public class StaffController : Controller
    {
        public static List<Staff> personnel = new List<Staff>()
        {
            new Staff(){FirstName = "Ivan", LastName = "Ivanov", Patronymic = "Ivanovich", BirthDay = new DateTime(2000, 5, 15), ContactNumber = "375291111111"},
            new Staff(){FirstName = "Petr", LastName = "Petrov", Patronymic = "Petrovich", BirthDay = new DateTime(1998, 6, 7), ContactNumber = "375293333333"},
            new Staff(){FirstName = "Alexander", LastName = "Alexandrov", Patronymic = "Alexandrovich", BirthDay = new DateTime(1995, 12, 25), ContactNumber = "375295555555"},
        };

        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Staff()
        {
            return View("Staff", personnel);
        }
    }
}