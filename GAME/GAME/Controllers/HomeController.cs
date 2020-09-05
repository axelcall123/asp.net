using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GAME.Models;

namespace GAME.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Othelo()
        {
            ViewBag.Message = "Your contact xd.";
            Pepe n = new Pepe();
            n.apellido = "jorge";
            n.edad = 5;
            n.nombre = "joder";
            return View();
        }


        
    }
}