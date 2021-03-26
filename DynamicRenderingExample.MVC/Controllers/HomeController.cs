using DynamicRenderingExample.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicRenderingExample.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var inputs = new Inputs();
            inputs.InputList.Add(new StringInput());
            inputs.InputList.Add(new DateInput());
            inputs.InputList.Add(new ColorInput());

            return View(inputs);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}