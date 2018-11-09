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

        public IActionResult Draw()
        {            
            return View();
        }

        public ActionResult ValidateShape(string shape, string measurements1, string size1, string measurements2, string size2, string measurements3, string size3)
        {
            string errorMessage = "";
            try
            {
                if(shape == "ET" && measurements1 != "side")
                {
                    errorMessage = "Please select the correct Measurement for Equilateral Triangle";
                }
                else if (shape == "IT" && (!((size1 == size2 && size2 != size3) || (size1 == size3 && size1 != size2) || (size2 == size3 && size3 != size1)) || (measurements1 == "side" || measurements2 == "side")))
                {
                    errorMessage = "Please select the correct Measurement for Isosceles Triangle";
                }
                else if(shape == "ST" && !((size1 != size2) && (size2 != size3) && (size3 != size1)))
                {
                    errorMessage = "Please select the correct Measurement for Scalene Triangle";
                }               
                var response = new
                {
                    errorMessage = errorMessage
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
