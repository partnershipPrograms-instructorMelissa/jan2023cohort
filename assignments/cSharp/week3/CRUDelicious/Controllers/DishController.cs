using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;
public class DishController : Controller
{
    private MyContext _context;
    public DishController(MyContext context)
    {
        _context = context;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        List<Dish> allDishes = _context.Dishes.ToList();
        return View("Index", allDishes);
    }

    [HttpGet("create")]
    public IActionResult Create()
    {
        List<Dish> allDishes = _context.Dishes.ToList();
        return View("Create");
    }


    [HttpPost("create")]
    public IActionResult AddDish(Dish newDIsh)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newDIsh);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            return View("Create");
        }
    }

    [HttpGet("dish/{id}")]
    public IActionResult Result(int id)
    {
        Dish? ViewDish = _context.Dishes.FirstOrDefault(i => i.DishId == id);
        if (ViewDish != null)
        {
            return View(ViewDish);
        }
        else
        {
            return RedirectToAction("Index");
        }
    }

    [HttpGet("dish/{id}/edit")]
    public IActionResult EditDish(int id)
    {
        Dish? ToEditDish = _context.Dishes.FirstOrDefault(i => i.DishId == id);
        if (ToEditDish != null)
        {
            return View(ToEditDish);
        }
        else
        {
            return RedirectToAction("Index");
        }
    }

    [HttpPost("dish/{id}/update")]
    public IActionResult UpdateDish(Dish newDish, int id)
    {
        // 2. Find the old version of the instance in your database
        Dish? OldDish = _context.Dishes.FirstOrDefault(i => i.DishId == id);
        // 3. Verify that the new instance passes validations
        if (ModelState.IsValid)
        {
            // 4. Overwrite the old version with the new version
            // Yes, this has to be done one attribute at a time
            OldDish.Name = newDish.Name;
            OldDish.Chef = newDish.Chef;
            OldDish.Description = newDish.Description;
            OldDish.Calories = newDish.Calories;
            OldDish.Tastiness = newDish.Tastiness;
            OldDish.Description = newDish.Description;
            // You updated it, so update the UpdatedAt field!
            OldDish.UpdatedAt = DateTime.Now;
            // 5. Save your changes
            _context.SaveChanges();
            // 6. Redirect to an appropriate page
            return RedirectToAction("Index");
        }
        else
        {
            // 3.5. If it does not pass validations, show error messages
            // Be sure to pass the form back in so you don't lose your changes
            // It should be the old version so we can keep the ID
            return View("EditDish", OldDish);
        }
    }

    [HttpPost("dish/{id}/destroy")]
    public IActionResult DestroyDish(int id)
    {
        Dish? dishToDelete = _context.Dishes.SingleOrDefault(i => i.DishId == id);
        // Once again, it could be a good idea to verify the monster exists before deleting
        if (dishToDelete != null)
        {
            _context.Dishes.Remove(dishToDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            return RedirectToAction("EditDish");
        }
    }
}

