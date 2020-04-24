using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\seatt\Desktop\C#_Projects\samplelog.txt", text);
            //Random rdm = new Random(10);
            //var num = rdm.Next();

            //ViewBag.RandomNumber = num;

            //if (num > 20000)
            //{
            //    return View("About");
            //}

            //return Content("Hello!");
            //return RedirectToAction("Contact");
            //List<string> names = new List<string>
            //{
            //    "Clare", "Jesse", "Max"
            //};
            //            return View(names);
            //int number = 5;
            //return View(number);
            User user = new User();
            user.Id = 1;
            user.FirstName = "Clare";
            user.LastName = "Shin";
            user.Age = 28;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            throw new Exception("Invalid page");
            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}