using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Level3.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            //Register logging provider in startup class, provider for event log,tracesource,console, debug,ETW, use constructor  injection to get access to the logger in a controller or class.                                    
            //2. Name JSON file as appsettings.jon create a class to get a values fill the class in startup class.


            return View();
        }
    }
}