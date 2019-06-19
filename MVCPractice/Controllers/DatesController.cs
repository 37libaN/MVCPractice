using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class DatesController : Controller
    {
        // GET: Dates
        public ActionResult Index()
        {
            return View(viewName: "Index", model: DateTime.Now.ToString("MM/dd/yyyy"));
        }
        [HttpPost]
        public ActionResult ShowDate(DateTime inputDate)
        {
            return View(viewName: "Index", model: inputDate.ToString("MM/dd/yyyy"));
        }
    }
}