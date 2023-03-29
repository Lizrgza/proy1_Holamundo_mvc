using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using proy1HolaMundoMVC.Models;

namespace proy1HolaMundoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HelloWorldModel { Message = "Hola Mundo"};
            return View(model);
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