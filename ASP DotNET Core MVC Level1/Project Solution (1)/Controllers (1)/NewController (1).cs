using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Project_Solution.Controllers
{
    public class NewController : Controller
    {
        public IActionResult New()
        {
            //. Create an ASP.NET core website add a controller to the project's controller in the project's view folder then pass data to & from the view to controller, test it in postman.
            return View();
        }
    }
}