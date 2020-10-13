# What is this?
This is a 'getting started' guide for ASP.NET. In this branch we will learn ***how to create a controller*** and receive/serve requests.
A controller handles incoming browser requests. It receives data and decides what type of response to send back to the browser.

# Steps To Follow
- Create a `Controller`: 
  - Solution Explorer > Controllers > Add > Controller > Controller Clas - Empty > Create a Controller called `HelloWorldController.cs` > Click Add.
- Replace the contents of `HelloWorldController` with the following:
```
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }

    public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
```
- Press CTRL + F5 to run the app. Append the following to the URL: `/HelloWorld` and `/Welcome`.
- To pass a query string into the URL:
  - Replace Welcome with the following code:
  ```
    public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
  ```
  - Run the app.
  - Append the following to the URL: `HelloWorld/Welcome/3?name=Rick` and `HelloWorld/Welcome?name=John&id=5`.

# Additional Notes:
- All `public` methods are callable HTTP endpoints. `Index()` and `Welcome` are examples. An HTTP endpoint is a targetable URL in the web application.
- Both methods in the `HelloWorldController` class code above are `HTTP GET` methods
- To view the routing format:
  - Open `Startup.cs`. 
  - Look at the Lambda expression inside `app.UseEndpoints()`.
  - The routing format is `{controller=Home}/{action=Index}/{id?}`. `controller` is the controller name, with the Controller part being omitted. `action` is the method name. `id` is the id that is passed as a parameter in the `action`.