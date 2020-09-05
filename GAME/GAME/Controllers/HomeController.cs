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

        public ActionResult Registrarse()
        {
            ViewBag.Message = "Regisrandose";
            return View();
        }
        public ActionResult Othelo()
        {
            ViewBag.Message = "Game";
            Pepe n = new Pepe();
            n.apellido = "jorge";
            n.edad = 5;
            n.nombre = "joder";
            return View();
        }
        public ActionResult Iniciar_Sesion()
        {
            ViewBag.Message = "Iniciando Sesion";
            return View();
        }
    }
}