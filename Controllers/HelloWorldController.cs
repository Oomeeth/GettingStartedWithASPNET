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
        /*
         * BLOCK 1
         * To add a view change the Index method to the one below.
         * Create a folder under Views called HelloWorld. Create a html view called Index.cshtml.
         * 
         * Have a look at Views/HelloWorld/Index.cshtml.
         * Run the app and append /HelloWorld/Index to the URL.
         * 
         * Because a view template was not specified, ASP.NET will render the default view, which is has the same name as the method and located within the HelloWorld folder
         */

        public IActionResult Index()
        {
            return View();
        }

        /* 
         * BLOCK 2
         * Run the app and append /HelloWorld/Welcome to the URL.
         * Have a look at the Welcome template Views/HelloWorld/Welcome.cshtml.
         */

        public IActionResult Welcome()
        {
            return View();
        }

        /*
         * BLOCK 3
         * The below controller method accepts an input from the URL and displays it in the browser.
         * Try appending /HelloWorld/Person/3?name=John&numTimes=2 to the URL.
         */

        public IActionResult Person(string name, int id, int numTimes = 1)
        {
            ViewData["name"] = name;
            ViewData["id"] = id;
            ViewData["numTimes"] = numTimes;

            return View();
        }
    }
}
