using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ChefsDishes.Models;

namespace ChefsDishes.Controllers;

public class DishController : Controller
{
    private readonly ILogger<DishController> _logger;

    private MyContext _context;

    public DishController(ILogger<DishController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("dishes")]
    public IActionResult Dishes()
    {
        List<Dish> CreatorDish = _context.Dishes
        .Include(c => c.Creator)
        .ToList();

        return View(CreatorDish);
    }

    [HttpGet("dishes/new")]
    public IActionResult Create()
    {
        MyViewModel theChefs = new MyViewModel
        {
            AllChefs = _context.Chefs.ToList()
        };
        return View(theChefs);
    }

    [HttpPost("dishes/new")]
    public IActionResult AddDish(Dish newDish)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("Dishes");
        }
        else
        {
            return View("Create");
        }
    }

    // [HttpGet("dishes/list")]
    // public IActionResult CreateList()
    // {
    //     List<Chef> allChefs = _context.Chefs.ToList();

    //     return View(allChefs);
    // }
}