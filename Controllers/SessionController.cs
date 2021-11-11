using GuessTheNumber.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber.Controllers
{
    public class SessionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //Random rn = new Random();
            //var rand = rn.Next(1, 101);
            //var models = new SessionModel(rand);
            //HttpContext.Session.SetInt32("Test", models.random);            
            return View();
        }
    }
}
