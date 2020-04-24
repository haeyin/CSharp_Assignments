using Assignment_30.Models;
using Assignment_30.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_30.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (CarInsuranceQuoteEntities db = new CarInsuranceQuoteEntities())
            {
                var getquoteVms = new List<GetQuoteVm>();

                return View(getquoteVms);
            }
  
        }
    }
}