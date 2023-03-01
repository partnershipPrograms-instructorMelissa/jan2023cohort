using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

public class DishController : Controller
{
    private MyContext _context;

    public DishController( MyContext context)
    {
        _context = context;
    }

    [HttpGet("dishes")]
    public IActionResult DishIndex(){
        return View();
    }

    [HttpGet("dishes/new")]
    public IActionResult AddDish(){
        return View();
    }

    [HttpPost("dishes/create")]
    public IActionResult CreateDish(Dish dish){
        if(ModelState.IsValid){
            _context.Dishes.Add(dish);
            _context.SaveChanges();
            Console.WriteLine($"{dish.Name} with ID {dish.DishId} added to Dishes database.");
            return RedirectToAction("DishIndex");
        }
        return View("AddDish");
    }
}