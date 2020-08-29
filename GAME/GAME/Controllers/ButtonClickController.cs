using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GAME.Controllers
{
    public class ButtonClickController : Controller
    {
        // GET: ButtonClick
        public ActionResult YIndex()
        {
            return View();
        }
        public ActionResult check(String button) { 
                if (button == "first"){ 
                    TempData["bl"] = "F chat"; } 
                else { 
                    TempData["bl"] = "Foca chat"; 
                } 
                return RedirectToAction("YIndex"); 
                }
        }
}