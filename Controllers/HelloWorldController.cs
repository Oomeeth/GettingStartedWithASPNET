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
         * public methods are callable HTTP endpoints, which is a targetable URL.
         * Run (CTRL + F5) the app and try appending 'HelloWorld' to the URL. Then try appending 'HelloWorld/Index' and 'HelloWorld/Welcome'
         * Have a look at Configure in Startup.cs to view the format for the URL routing logic
         */

        public string Index()
        {
            return "This is my default action.";
        }

        public string Welcome()
        {
            return "This is the welcome action method.";
        }

        /*
         * BLOCK 2:
         * The method below allows you to specify paramteres to the URL.
         * Run the app and append the following to the URL 'HelloWorld/WelcomeParams?name=John&id=4'
         * 
         * Another way to run this would be to append the following to the URL 'HelloWorld/Welcome/3?name=Rick'
         * Notice that the above URL matches the routing format in Startup.cs Config() '{controller=Home}/{action=Index}/{id?}'
         */

        public string WelcomeParams(string name, int id = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID is {id}");
        }
    }
}
