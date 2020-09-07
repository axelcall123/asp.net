using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using GAME.Models;

namespace GAME.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        Persona people = new Persona();
        public ActionResult Registrarse()
        {
            ViewBag.Message = "Regisrandose";
            
            /*people.Nombre = "hoa";*/
            people.Nombre = Request.Form["nombre"].ToString();
            people.Apellido = Request.Form["apellido"].ToString();
            people.N_Usuario = Request.Form["usuairo"].ToString();
            people.Contraseña = Request.Form["contraseña"].ToString();
            people.Fecha_Nac = Request.Form["fecha"].ToString();
            people.Pais = Request.Form["nombre"].ToString();
            people.Correo = Request.Form["nombre"].ToString();
            return View(people);
        }
        public ActionResult P()
        {
            
            return View(people);
        }
        Image img = new Image();
        public ActionResult Othelo()
        {
            /*img.ImageID = "images.png";
            return View(img);*/
            return View();
        }
        public ActionResult Iniciar_Sesion()
        {
            ViewBag.Message = "Iniciando Sesion";
            return View();
        }
    }
    

}