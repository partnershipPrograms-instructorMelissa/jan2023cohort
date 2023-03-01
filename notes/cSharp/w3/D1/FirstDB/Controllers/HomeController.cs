using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstDB.Models;

namespace FirstDB.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;
    public HomeController(ILogger<HomeController> logger, MyContext context)    
    {        
        _logger = logger;
        // When our HomeController is instantiated, it will fill in _context with context
        // Remember that when context is initialized, it brings in everything we need from DbContext
        // which comes from Entity Framework Core
        _context = context;    
    } 

    public IActionResult Index()
    {
        // Now any time we want to access our database we use _context   
        List<Squishy> AllSquishies = _context.Squishies.ToList();
        List<Fruit> AllFruits = _context.Fruits.ToList();
        return View();  
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}
