using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Level2.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            //. Create an interface IWeatherService& class weather service, Register it for dependency injection pass it to a controller in its constructor then do unit testing on the controller.                       
            //refere business layer use Level2.Test to test the controller
            return View();
        }
    }
}