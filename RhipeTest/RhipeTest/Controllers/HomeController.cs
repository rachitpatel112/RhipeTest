using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RhipeTest.Models;

namespace RhipeTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public ActionResult ValidateShape(string shape, string measurements1, string amounts1, string measurements2, string amounts2)
        {
            string errorMessage = "";
            try
            {
                var response = new
                {
                    errorMessage = "Could not draw object"
                };

                return Json(response);
            }
            catch (Exception ex)
            {                
                errorMessage = "Could not draw object. Please contact support";
            }

            ViewBag.ErrorMessage = errorMessage;
            return View("Error");
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
