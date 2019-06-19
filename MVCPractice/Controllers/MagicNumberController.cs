using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class MagicNumberController : Controller
    {
        // GET: MagicNumber
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public ActionResult RandomNumber(int inputNumberOne, int inputNumberTwo)
        {
            int rand = new Random().Next(Math.Min(inputNumberOne, inputNumberTwo), 
                Math.Max(inputNumberOne, inputNumberTwo));
            return View(viewName: "Index", model: rand);
        }
    }
}