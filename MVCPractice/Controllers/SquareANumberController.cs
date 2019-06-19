using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class SquareANumberController : Controller
    {
        // GET: SquareANumber
        public ActionResult Index()
        {
            double numberToStart = 0.0; ;
            return View(viewName: "Index", model: numberToStart);
        }

        [HttpPost]
        public ActionResult SaySquare(double inputNumber)
        {
            return View(viewName: "Index", model: Math.Sqrt(Math.Abs(inputNumber)));
        }
    }
}