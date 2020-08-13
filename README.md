# What is this?
This is a 'getting started' guide for ASP.NET. In this branch we will learn ***how to create a model***. A model class in responsible for managing databses. We will use Entity Framework Core ORM to interact with the Database, since it simplefies data access code and creates the database for us. Our model classes will be POCO because they do not have any dependancies with the EF Core framework.

# Steps To Follow
- Create a model class called Person under Models folder. `Right click Models > Add > Class > Class > Person`
- Add the following to `Person.cs`:
    ```
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
    ```
- Install the provider for EF Core SQL Server: Navigate to `Tools > NuGet Package Manager > Package Manager Console` and enter the command `Install-Package Microsoft.EntityFrameworkCore.SqlServer`
- Create a database context class (for C.R.U.D functionality): 
  - Create a `Data folder > Add the file PersonContext.cs`. 
  - Add the following namespaces to `PersonContext.cs`: `Microsoft.EntityFrameworkCore, Getting_Started.Models`.
  - Add the code within `Getting_Started.Data` of `PersonContext.cs` namespace:
    ```
        public class PersonContext : DbContext
        {
            public DbSet<Person> person { get; set; }

            public PersonContext(DbContextOptions<PersonContext> options) : base(options)
            {

            }
        }
    ```
- EF Core must be registered with Dependancy Injection during application startup.
  - Register the Database Context. Add the following namespaces to `Startup.cs`: `Getting_Started.Data, Microsoft.EntityFrameworkCore`
  - Add the code to the end in `Startup.ConfigureServices()`:
  ```
    services.AddDbContext<PersonContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MvcMovieContext")));
  ```
- Add the following line of code after `AllowedHosts` in `appsettings.json`:
    ```
        ,
        "ConnectionStrings": {
            "MvcMovieContext": "Server=(localdb)\\mssqllocaldb;Database=PersonContext-1;Trusted_Connection=True;MultipleActiveResultSets=true"
        }
    ```
- Use scaffolding tool to create CRUD app:
  - `Right-click Controllers > Add > New Scaffolded Item > MVC Controller with views, using Entity Framework > Add > Model Class: Person, Data context class: PersonContext`
- Migrations is a set of tools to create and update a database to match your data model:
  - `Tools > select NuGet Package Manager > Package Manager Console` and enter the following 2 commands: `Add-Migration InitialCreate` and `Update-Database`.

# How does Model, Views and Controllers interact with each other?
- Have a look at the `Details()` method in `PeopleController.cs`. 
  - The method accepts an id value to a person. Appending `People/Details/1` to the URL will display the details for the first person. 
  - `var person = await _context.Person.FirstOrDefaultAsync(m => m.Id == id);` will select `Person` entities that match the route data. If a `Person` is found it is passed through `return View(person);`
  - In `Details.cshtml` you will see a `@model MvcMovie.Models.Person` at the top. This directive was created by scaffolding allows access to the `Person` model which has been passed in from the controller (`return View(person);` above).