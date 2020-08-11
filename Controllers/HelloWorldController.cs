using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Getting_Started.Controllers
{

    public class HelloWorldController : Controller
    {
        public IActionResult Index(string name, int id, int numTimes = 1)
        {
            ViewData["method"] = "Index";
            ViewData["name"] = name;
            ViewData["id"] = id;
            ViewData["numTimes"] = numTimes;

            return View();
        }

        public IActionResult Welcome(string name = "John", int id = 4, int numTimes = 1)
        {
            ViewData["method"] = "Welcome";
            ViewData["name"] = name;
            ViewData["id"] = id;
            ViewData["numTimes"] = numTimes;

            return View();
        }
    }
}
