using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ZoosAndAnimals.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace ZoosAndAnimals.Controllers;

public class ZooController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public ZooController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    private int? uid {
        get {
            return HttpContext.Session.GetInt32("uid");
        }
    }
    
    // Recommend routeName and FunctionName be the same
    [SessionCheck]
    [HttpGet("/zoo/dashboard")]
    public IActionResult Dashboard() {
        List<Zoo> allTheZoos = db.Zoos
            .Include(z => z.AllAnimals)
            .ThenInclude(a => a.TheAnimal)
            // .ThenInclude(theA => theA.AllZoos)
            .OrderBy(z => z.Location)
            .ToList();

        return View("Dashboard", allTheZoos);
    }
    [SessionCheck]
    [HttpGet("/zoo/addZoo")]
    public IActionResult AddZoo() {
        List<User> allUsers = db.Users
        .OrderBy(u => u.LastName)
        .ToList();
        return View("AddZoo");
    }
    [SessionCheck]
    [HttpGet()]
    public IActionResult CreateZoo(Zoo z) {
        z.UserId = (int)uid;
        if(ModelState.IsValid) {
            db.Zoos.Add(z);
            db.SaveChanges();
            return Redirect("Dashboard");
        }
        return View("AddZoo");
    }
}