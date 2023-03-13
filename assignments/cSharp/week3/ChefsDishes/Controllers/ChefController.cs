using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ChefsDishes.Models;

namespace ChefsDishes.Controllers;

public class ChefController : Controller
{
    private readonly ILogger<ChefController> _logger;

    private MyContext _context;

    public object CreatorDish { get; private set; }

    public ChefController(ILogger<ChefController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        List<Chef> allChefs = _context.Chefs
        .Include(item => item.CreatorDish)
        .ToList();
        return View("Index", allChefs);
    }

    [HttpGet("chefs")]
    public IActionResult Create()
    {
        List<Chef> allChefs = _context.Chefs.ToList();
        return View();
    }

    [HttpPost("chefs")]
    public IActionResult AddChef(Chef newChef)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newChef);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        else
        {
            return View("Create");
        }
    }
}
