# What is this?
This is a 'getting started' guide for ASP.NET. In this branch we will learn ***how to create a view***.
Controller handles and responds user inputs and interactions. They retrieve model data and call view templates that return a response.

# Steps To Follow
- Create a controller called `HelloWorldControllers.cs`:
  - `Right click Controllers > Add Controller > Controller > MVC Controller Empty > Controller Class - Empty.`
- Add the following code to the `HelloWorldControllers` class:
```
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
```
The above line of code requires a view called `Index.cshtml` and `Welcome.cshtml` view. **The view name MUST match the method name!**
- To pass data from the controller to a view do the following:
  - `Right Click Views > Add > Folder. Call it HelloWorld`
  - Create 2 views called `Index.cshtml` and `Welcome.cshtml`.
    - `Right click HelloWorld > Add > View > Razor View - Empty > Call it Index.cshtml`
  - Add the following code to the end of `Index.cshtml`:
  ```
    <h3>Welcome to The Persons App!</h3>

    @for (int i = 0; i < (int)ViewData["numTimes"]; ++i)
    {
        <h3>Name: @ViewData["method"]</h3>
        <h3>Name: @ViewData["name"]</h3>
        <h3>ID: @ViewData["id"]</h3>
    }
  ```
  - Add the following code to the end of Welcome.cshtml:
  ```
    <h3>Welcome to The Persons App!</h3>

    @for (int i = 0; i < (int)ViewData["numTimes"]; ++i)
    {
        <h3>Name: @ViewData["method"]</h3>
        <h3>Name: @ViewData["name"]</h3>
        <h3>ID: @ViewData["id"]</h3>
    }
  ```
- `Views/Shared/_Layout.cshtml` is an HTML container that is applied across multiple pages. Make a few changes to `_Layout.cshtml`.
- Append the following to the URL:
  - HelloWorld/Index
  - HelloWorld/Welcome
  - HelloWorld/Index/3?name="John"&numTimes=2
  - HelloWorld/Welcome?3&name="Carl"&numTimes=3
- Because we do not specify a view in the Index and Welcome method, it will call the default views which matches its names.