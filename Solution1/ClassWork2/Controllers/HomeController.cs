﻿using ClassWork2.Models;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.Json;
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
        public ViewResult Upload()
        {
            return View("Upload");
        }

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase upload, string newName)
        {
            if (upload != null)
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "Files/";
                string fileName = Path.GetFileName(upload.FileName);
                string extension = Path.GetExtension(fileName);
                upload.SaveAs(Path.Combine(path, newName + extension));
                return Content($"Done!");
            }
            else
            {
                return Content($"Nothing!");
            }
        }

        public enum Operation
        {
            [Description("Average")]
            Average,
            [Description("Min")]
            Min,
            [Description("Max")]
            Max
        }

        [HttpGet]
        public ViewResult Operations()
        {
            return View("Operations");
        }

        [HttpPost]
        public ContentResult Operations(string numbers, Operation operation)
        {
            int[] arrayNumbers = numbers.Split(',').Select(x => Convert.ToInt32(x)).ToArray();
            double result = 0;
            switch (operation)
            {
                case Operation.Average:
                    foreach (var n in arrayNumbers)
                    {
                        result = result + n;
                    }
                    result = result / arrayNumbers.Length;
                    break;
                case Operation.Min:
                    result = arrayNumbers.Min();
                    break;
                case Operation.Max:
                    result = arrayNumbers.Max();
                    break;
            }
            return Content($"{operation} = {Math.Round(result, 1)}");
        }

        [HttpGet]
        public ViewResult Person()
        {
            return View("Person");
        }

        [HttpPost]
        public ContentResult Person(Person person)
        {
            PersonFormatted personFormatted = new PersonFormatted();
            personFormatted.Id = person.Id;
            personFormatted.Name = $"{person.FirstName} {person.Patronymic} {person.LastName}. Sex: {person.sex}. He(She) has children: {person.Children.Count()}";
            if (person.Children.Count() > 0)
            {
                foreach (var x in person.Children)
                {
                    personFormatted.Children = personFormatted.Children + $"{x.FirstName} {x.Patronymic} {x.LastName}. Sex: {x.sex} - ";
                }
            }
            string jsonString;
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            jsonString = JsonSerializer.Serialize(personFormatted, options);
            return Content(jsonString);
        }
    }
}