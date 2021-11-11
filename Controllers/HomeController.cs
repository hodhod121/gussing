using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GuessTheNumber.Models;
using GuessTheNumber.ApplicationLayer;
using Microsoft.AspNetCore.Http;

namespace GuessTheNumber.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new MyModel();
            Random rn = new Random();
            var rand = rn.Next(1, 101);
            var models = new SessionModel(rand);
            HttpContext.Session.SetInt32("Test", models.random);
            ViewBag.sessionv = HttpContext.Session.GetInt32("Test");
            
            model.GetGuessNumber();
            return View(model);
        }
   
        public IActionResult Index(MyModel mymodel)
        {          
            if (ModelState.IsValid)
            {
                mymodel.ShowResult = true;
                var resul = new Result();
                ViewBag.Result = resul.GetResult(ref mymodel);
            }
            return View(mymodel);
           
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
