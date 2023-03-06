using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChefDishes.Models;

namespace ChefDishes.Controllers;

public class ChefController : Controller
{
    private MyContext _context; 

    public ChefController(MyContext context)
    {
        _context = context;
    }

    // read
    [HttpGet("chef")]
    public IActionResult ViewChefs(){
        //! To get all posts from a user: User? MyUser = _context.Users.Include(p => p.AllPosts).FirstOrDefault(i => i.UserId == id)
        List<Chef> chefs = _context.Chefs.Include(c => c.AllDishes).ToList();
        return View(chefs);
    }

    // create
    [HttpGet("chef/add")]
    public IActionResult AddChef(){
        return View();
    }

    [HttpPost("chef/create")]
    public IActionResult CreateChef(Chef chef){
        if(ModelState.IsValid){
            _context.Chefs.Add(chef);
            _context.SaveChanges();
            return RedirectToAction("ViewChefs");
        }
        return View("AddChef");
    }

    // update

    // edit
}