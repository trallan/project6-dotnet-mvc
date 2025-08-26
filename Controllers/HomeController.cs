using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project6_dotnet_mvc.Models;

namespace project6_dotnet_mvc.Controllers;

// Handle incoming HTTP requests, processes data and prepares a response.
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Books()
    {
        var books = new List<Book>
        {
            new Book { Id = 1, Title = "Clean Code", Author = "Robert C. Martin", Year = 2008 },
            new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Year = 1999 },
            new Book { Id = 3, Title = "Design Patterns", Author = "Erich Gamma", Year = 1994 }
        };

        return View(books);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Book(int id)
    {
        var books = new List<Book>
        {
            new Book { Id = 1, Title = "Clean Code", Author = "Robert C. Martin", Year = 2008, ImageUrl = "" },
            new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Year = 1999, ImageUrl = "" },
            new Book { Id = 3, Title = "Design Patterns", Author = "Erich Gamma", Year = 1994, ImageUrl = "" }
        };

        ViewBag.SelectedId = id;
        return View(books);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

