using Assignment_30.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_30.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetQuote(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (CarInsuranceQuoteEntities db = new CarInsuranceQuoteEntities())
                {
                    var getquote = new GetQuote();
                    getquote.FirstName = firstName;
                    getquote.LastName = lastName;
                    getquote.EmailAddress = emailAddress;

                    db.GetQuotes.Add(getquote);
                }

                return View("Success");
            }
        }



        public ActionResult About()
        {
            ViewBag.Message = "Get a quote for how much your Car Insurance would cost!";

            return View();
        }

    }
}