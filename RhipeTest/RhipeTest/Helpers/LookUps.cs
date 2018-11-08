using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RhipeTest.Helpers
{
    public class LookUps
    {
        public static List<SelectListItem> Shapes()
        {
            List<SelectListItem> shapes = new List<SelectListItem>();
            shapes.Add(new SelectListItem { Text = "Isosceles Triangle", Value = "IT" });
            shapes.Add(new SelectListItem { Text = "Scalene Triangle", Value = "ST" });
            shapes.Add(new SelectListItem { Text = "Equilateral Triangle", Value = "ET" });            
            return shapes;
        }

        public static List<SelectListItem> Measurements()
        {
            List<SelectListItem> measurements = new List<SelectListItem>();
            measurements.Add(new SelectListItem { Text = "height", Value = "height" });
            measurements.Add(new SelectListItem { Text = "base", Value = "base" });
            measurements.Add(new SelectListItem { Text = "side", Value = "side" });
            measurements.Add(new SelectListItem { Text = "width", Value = "width" });
            return measurements;
        }

        public static List<SelectListItem> Amounts()
        {
            List<SelectListItem> amounts = new List<SelectListItem>();
            amounts.Add(new SelectListItem { Text = "100", Value = "100" });
            amounts.Add(new SelectListItem { Text = "200", Value = "200" });
            amounts.Add(new SelectListItem { Text = "300", Value = "300" });
            amounts.Add(new SelectListItem { Text = "400", Value = "400" });
            amounts.Add(new SelectListItem { Text = "500", Value = "500" });
            amounts.Add(new SelectListItem { Text = "600", Value = "600" });
            return amounts;
        }

       
    }
}
