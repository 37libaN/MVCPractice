using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class StringActivityController : Controller
    {
        // GET: StringActivity
        public ActionResult Index()
        {
            return View(viewName: "Index", model: "What is Thomas?");
        }
        [HttpPost]
        public ActionResult SayHello(string inputString)
        {
            string words = "Thomas is ";
            return View(viewName: "Index", model: words + inputString + ".");
        }
    }
}