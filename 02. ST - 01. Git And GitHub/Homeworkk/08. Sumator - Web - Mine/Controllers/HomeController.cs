using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _08.Sumator___Web___Mine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calculate(int number1, int number2)
        {
            this.ViewBag.number1 = number1;
            this.ViewBag.number2 = number2;
            this.ViewBag.sum = number1 + number2;
            return View("Index");
        }
    }
}