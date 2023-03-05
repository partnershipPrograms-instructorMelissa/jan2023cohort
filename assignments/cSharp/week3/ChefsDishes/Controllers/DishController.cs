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

    [HttpGet("dishes/new")]
    public IActionResult Create()
    {
        List<Dish> allDishes = _context.Dishes.ToList();
        return View();
    }

    [HttpPost("dishes/new")]
    public IActionResult AddDish(Dish newDish)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("dishes");
        }
        else
        {
            return View("Create");
        }
    }
}