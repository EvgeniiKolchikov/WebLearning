using System.Text;
using System.Text.Json;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using WebLessons.Models;

namespace WebLessons.Controllers;

public class MyController : Controller
{
    // [HttpGet]
    // public string Index() => "hello";
    // [HttpPost]
    // public string Hello() => "hello evgen";

    // public async Task Index()
    // {
    //     Response.ContentType = "text/html; charset=utf-8";
    //     //await Response.WriteAsync("<h2>Hello ASP Web Future Without Fear</h2>");
    //
    //     var tableBuilder = new StringBuilder("<h2>Request Header</h2><table>");
    //
    //     foreach (var header in Request.Headers)
    //     {
    //         tableBuilder.Append($"<tr><td>{header.Key}</td><td>{header.Value}</td></tr>");
    //     }
    //
    //     tableBuilder.Append("</table>");
    //     await Response.WriteAsync(tableBuilder.ToString());
    // }

    // public string Index(string name, int age)
    // {
    //     return $"Hello {name}, you are {age} years old";
    // }

    // public string Index(Person person)
    // {
    //     return $"Name: {person.Name} Age: {person.Age}";
    // }

    // public string Index(string[] people)
    // {
    //     string result = "";
    //     foreach (var person in people)
    //         result = $"{result}{person}; ";
    //     return result;
    // }
    
    // [HttpGet]
    // public async Task Index()
    // {
    //     string content = @"<form method='post'>
    //             <label>Name:</label><br />
    //             <input name='name' /><br />
    //             <label>Age:</label><br />
    //             <input type='number' name='age' /><br />
    //             <input type='submit' value='Send' />
    //         </form>";
    //     Response.ContentType = "text/html;charset=utf-8";
    //     await Response.WriteAsync(content);
    // }
    // [HttpPost]
    // public string Index(Person person) => $"{person.Name}: {person.Age}";

    // [HttpGet]
    // public async Task Index()
    // {
    //     string form = @"<form method='post'>
    //             <p><input name='names' /></p>
    //             <p><input name='names' /></p>
    //             <p><input name='names' /></p>
    //             <input type='submit' value='Send' />
    //         </form>";
    //     Response.ContentType = "text/html;charset=utf-8";
    //     await Response.WriteAsync(form);
    // }
    //
    // [HttpPost]
    // public string Index(string[] names)
    // {
    //     string result = "";
    //     foreach(string name in names)
    //     {
    //         result = $"{result} {name}";
    //     }
    //     return result;
    // }
    
    // public async Task Index()
    // {
    //     string content = @"<form method='post' action='/Home/PersonData'>
    //                <label>Name:</label><br />
    //             <input name='name' /><br />
    //             <label>Age:</label><br />
    //             <input type='number' name='age' /><br />
    //             <input type='submit' value='Send' />
    //         </form>";
    //     Response.ContentType = "text/html;charset=utf-8";
    //     await Response.WriteAsync(content);
    // }
    // [HttpPost]
    // public string PersonData()
    // {
    //     string name = Request.Form["name"];
    //     string age = Request.Form["age"];
    //     return $"{name}: {age}";
    // }

    // public IActionResult Index()
    // {
    //     var person = new Person("Tom", 44);
    //     var jsonOption = new JsonSerializerOptions
    //     {
    //         PropertyNameCaseInsensitive = true,
    //         WriteIndented = true
    //     };
    //     
    //     return Json(person,jsonOption);
    // }
    
    // public IActionResult Index() => Content("Index");
    // public IActionResult About() => Content("About");
 
    // public IActionResult Contact()
    // {
    //     return Redirect("~/My/About");  
    // }
    // public IActionResult Contact()
    // {
    //     return Redirect("https://microsoft.com");
    // }

    // public IActionResult Index()
    // {
    //     return RedirectToRoute("default", new { controller = "My", action = "About", name = "Tom", age = 32 });
    // }
    //
    // public IActionResult About(string name, int age) => Content($"Name:{name}  Age: {age}");

    // public IActionResult Index()
    // {
    //     return StatusCode(505);
    // }
    // public IActionResult Index()
    // {
    //     return NotFound("Not Found");
    // }

    // public IActionResult Index(int age)
    // {
    //     if (age < 18) return Unauthorized(new Error("Acces Denied"));
    //     return Content("Access is available");
    // }
    // public IActionResult Index()
    // {
    //     return Ok("Everything is Ok");
    // }
    // public IActionResult Result()
    // {
    //     return new HtmlResult("Привет! Друг мой, я твоя душа, у нас все получится, мы идем на верном пути," +
    //                           "пусть мы сомнеаемся в себе и нам страшно, но удача это твоя способность в этом мире,ВПЕРЕД!");
    // }

    // public IActionResult GetPhysicalFile()
    // {
    //     var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hello.txt");
    //     var fileType = "text/plain";
    //     var fileName = "hello.txt";
    //
    //     return PhysicalFile(filePath, fileType, fileName);
    // }
    //
    // public IActionResult GetAllBytesFile()
    // {
    //     var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hello.txt");
    //     var fileBytes = System.IO.File.ReadAllBytes(filePath);
    //     var fileType = "text/plain";
    //     var fileName = "hello.txt";
    //
    //     return File(fileBytes, fileType, fileName);
    // }
    //
    // public IActionResult GetStreamFile()
    // {
    //     var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hello.txt");
    //     var fs = new FileStream(filePath, FileMode.Open);
    //     var fileType = "text/plain";
    //     var fileName = "hello.txt";
    //
    //     return File(fs, fileType, fileName);
    // }
    //
    // public IActionResult GetVirtualFile()
    // {
    //     var fileType = "application/octet-stream";
    //     var fileName = "helloVirtual.txt";
    //
    //     return File("hello2.txt", fileType, fileName);
    // }

    // private readonly ITimeService timeService;
    //
    // public MyController(ITimeService timeServ)
    // {
    //     timeService = timeServ;
    // }
    // public string Index() => timeService.Time;

    // public string Index([FromServices]ITimeService timeServ)
    // {
    //     return timeServ.Time;
    // }
    
    // public string Index()
    // {
    //     var timeService = HttpContext.RequestServices.GetService<ITimeService>();
    //     return timeService?.Time ?? "Undefined";
    // }

    // public IActionResult Index()
    // {
    //     ViewData["Message"] = "Hello Evgen!";
    //     ViewBag.Message1 = "ViewBagMessage";
    //     ViewBag.People = new List<string> { "Tom", "Max", "Jim" };
    //     var letters = new List<string> { "KKK", "JJJ", "RRR" };
    //     return View(letters);
    // }

    // public IActionResult Index() => View();
    // public IActionResult About() => View();

    // [HttpGet]
    // public IActionResult Index() => View();
    //
    // [HttpPost]
    // public string Index(string language) => $"Language: {language}";

    List<Person> people = new List<Person>()
    {
        new Person(1,"Kimi",44),
        new Person(2,"Hulkenberg",32),
        new Person(3,"Max",25)
    };

    public IActionResult Index()
    {
        return View(people);
    }

}

public record Error(string Message);

