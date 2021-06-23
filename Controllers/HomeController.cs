using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using serviceCar.Models;
using serviceCar.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace serviceCar.Controllers 
{
    public class HomeController : Controller 
    {
        private servicecarContext _context;
        private readonly ILogger<HomeController> _logger;
        public String methodUsed="Index";




        public HomeController(ILogger<HomeController> logger, servicecarContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Login()
        {

            HttpContext.Session.SetInt32("iduser", 0);
            HttpContext.Session.SetString("isadmin", "azert");

            methodUsed ="Login";
            ViewBag.methodUsed=methodUsed;
            return View();
        }

        [HttpPost]  
        [ValidateAntiForgeryToken]  
        public ActionResult Login([Bind("Login,Password")]User objUser){
            
            if (ModelState.IsValid){
                var user=_context.User.Where(a=>a.Login.Equals(objUser.Login) && a.Password.Equals(objUser.Password) ).FirstOrDefault();
                if(user!=null ){

                    HttpContext.Session.SetInt32("iduser", user.IdUser);
                    HttpContext.Session.SetString("isadmin", user.IsAdmin.ToString());

                    if (user.IsAdmin==false){

                        
                        return RedirectToAction("Profil", "Conductor",new { id = HttpContext.Session.GetInt32("iduser") });
                    
                    }
                    else{
                        HttpContext.Session.SetString("IdUser",user.IdUser.ToString());

                        return RedirectToAction("DisplayCon", "Admin",new { id=HttpContext.Session.GetString("IdUser") });
                    }
                }
                else{
                    
                }
            }
            return View();
        }

        public IActionResult ContactUs()
        {
            methodUsed="ContactUs";
            ViewBag.methodUsed=methodUsed;
            return View();
        }

        public IActionResult AboutUs()
        {
            methodUsed="AboutUs";
            ViewBag.methodUsed=methodUsed;
            return View();
        }

        public IActionResult Privacy()
        {
            methodUsed="Privacy";
            ViewBag.methodUsed=methodUsed;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
