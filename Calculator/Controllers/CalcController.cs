using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator.Models;

namespace Calculator.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new calc());
        }

        [HttpPost]

        public ActionResult Index(calc c,string calculate)
        {
            if (calculate == "add")
                c.tot = c.no1 + c.no2;
            else if (calculate == "min")
                c.tot = c.no1 - c.no2;
            else if (calculate == "sub")
                c.tot = c.no1 * c.no2;
            else if (calculate == "divv" && c.no2 != 0)             
                c.tot = c.no1 / c.no2;           
            else
                c.tot = c.no1 = c.no2 = default;

            return View(c);
        }
            
    }
}