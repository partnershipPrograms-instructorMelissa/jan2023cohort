using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChefDishes.Models;

namespace ChefDishes.Controllers;

public class DishController : Controller
{
    private MyContext _context; 

    public DishController(MyContext context)
    {
        _context = context;
    }

    // read
    [HttpGet("dish")]
    public IActionResult ViewDishes(){
        List<Dish> allDishes = _context.Dishes.Include(d => d.Creator).ToList();
        return View(allDishes);
    }

    // create
    [HttpGet("dish/add")]
    public IActionResult AddDish(){
        ViewBag.Chefs = _context.Chefs.ToList();
        Console.WriteLine(new string('=', 10));
        return View();
    }
    [HttpPost("dish/create")]
    public IActionResult CreateDish(Dish dish){
        if(ModelState.IsValid){
            _context.Dishes.Add(dish);
            _context.SaveChanges();
            return RedirectToAction("ViewDishes");
        }
        // Console.WriteLine(new string('=', 10));
        // Console.WriteLine($"Model State: {ModelState.IsValid} (kw)");
        // Console.WriteLine(new string('=', 10));
        ViewBag.Chefs = _context.Chefs.ToList();
        return View("AddDish");
    }
}