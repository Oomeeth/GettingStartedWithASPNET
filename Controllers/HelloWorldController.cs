using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Getting_Started.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, string surname, string id)
        {
            ViewData["method"] = "Welcome";
            ViewData["name"] = name;
            ViewData["surnname"] = surname;
            ViewData["id"] = id;
            ViewData["repeat"] = 3;

            return View();
        }
    }
}
