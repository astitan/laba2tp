using Microsoft.AspNetCore.Mvc;
using System;
using laba2tp.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Reflection;



namespace laba2tp.Controllers
{
    
    public class lab2 : Controller
    {
        public static List<Dannie> usersList = new List<Dannie>();
        
        public IActionResult Addn(Dannie dn, string click)
        {
            if (click == "Добавить пользователя")
            {
                if (HttpContext.Session.Get("user") == null)
                {
                    HttpContext.Session.SetInt32("user", 0);
                }
                else
                {
                    HttpContext.Session.SetInt32("user", BitConverter.ToInt32(HttpContext.Session.Get("user")) + 1) ;
                }
                dn.UserId = BitConverter.ToInt32(HttpContext.Session.Get("user"));
                usersList.Add(dn);
                return View("Index", dn);
            }    
            
             
            return View("Addn");
        }

        [HttpPost]
        public ActionResult Index(Dannie dn)
        {
            
            return View(dn);

        }
        public ActionResult Users()
        {

            return View("Users", usersList);
        }

    }
}
