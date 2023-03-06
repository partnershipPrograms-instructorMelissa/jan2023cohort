<<<<<<<< HEAD:assignments/cSharp/DataValidation/Controllers/HomeController.cs
﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DataValidation.Models;

namespace DataValidation.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
========
﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MoviesWithCRU.Models;

namespace MoviesWithCRU.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext db;  // or use _context instead of db

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        db = context; // if you use _context above use it here too
    }

    public IActionResult Index()
    {
        return View("Dashboard");  
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
>>>>>>>> f1b5886614331e29c1fab28cc575282f9ae330fe:lectures/cSharp/week3/day3/MoviesWithCRU/Controllers/HomeController.cs
