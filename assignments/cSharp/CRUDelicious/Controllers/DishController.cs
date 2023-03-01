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

    // view all
    [HttpGet("")]
    public IActionResult DishIndex(){
        List<Dish> allDishes = _context.Dishes.OrderByDescending(d => d.DishId).ToList();
        return View(allDishes);
    }

    // create    
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

    // read one
    [HttpGet("dishes/{dishId}/view")]
    public IActionResult ViewDish(int dishId){
        Dish? item = _context.Dishes.FirstOrDefault(i => i.DishId == dishId);

        if(item == null){
            return RedirectToAction("DishIndex");
        }
        else{
            return View("ViewDish", item);
        }
    }

    // update 
    [HttpGet("dishes/{dishId}/edit")]
    public IActionResult EditDish(int dishId){
        Dish? item = _context.Dishes.SingleOrDefault(i => i.DishId == dishId);
        if(item == null){
            return RedirectToAction("ViewDish", dishId);
        }
        else{
            return View(item);
        }
    }

    [HttpPost("dishes/{dishId}/update")]
    public IActionResult UpdateDish(Dish newItem, int dishId){
        Dish? oldItem = _context.Dishes.SingleOrDefault(i => i.DishId == dishId);
        if(ModelState.IsValid){
            oldItem.Name = newItem.Name;
            oldItem.Chef = newItem.Chef;
            oldItem.Tastiness = newItem.Tastiness;
            oldItem.Calories = newItem.Calories;
            oldItem.Description = newItem.Description;
            oldItem.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return Redirect($"view");
        }
        return View("editDish", dishId);
    }

    // delete
    [HttpGet("dishes/{dishId}/delete")]
    public IActionResult DeleteDish(int dishId){
        Dish? itemToDelete = _context.Dishes.SingleOrDefault(i => i.DishId == dishId);
        if(itemToDelete != null){
            _context.Dishes.Remove(itemToDelete);
            _context.SaveChanges();
        }        
        return RedirectToAction("DishIndex");
    }
}