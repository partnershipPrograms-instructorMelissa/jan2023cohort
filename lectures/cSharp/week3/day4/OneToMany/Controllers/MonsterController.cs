using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OneToMany.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace OneToMany.Controllers;

public class MonsterController : Controller 
{
    private int? uid {
        get {
            return HttpContext.Session.GetInt32("uid");
        }
    }

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public MonsterController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    
    // Recommend routeName and FunctionName be the same
    // [SessionCheck]
    [HttpGet("/monster/")]
    public IActionResult Dashboard() {
        // if(HttpContext.Session.GetInt32("uid") == null){
        //     return RedirectToAction("Index", "User");
        // }
        List<Monster> allMonsters = db.Monsters.ToList();
        return View("Dashboard", allMonsters);
    }
    [HttpGet("/monster/addMonster")]
    public IActionResult AddMonster() {
        // if(HttpContext.Session.GetInt32("uid") == null){
        //     return RedirectToAction("Index", "User");
        // }
        return View("AddMonster");
    }
    [HttpPost("/monster/createMonster")]
    public IActionResult CreateMonster(Monster m) {
        Console.WriteLine($"what is uid {uid}, what is m {m.Name}");
        m.UserId = (int)HttpContext.Session.GetInt32("uid");
        if(ModelState.IsValid) {
            // if (uid != null){
            
            // }
            // m.UserId = (int)uid;
            db.Monsters.Add(m);
            db.SaveChanges();
            return Redirect("/monster");
        } else {
            Console.WriteLine($"danger error {m.Name}, {m.UserId}, {m.Hidden}");
            return View("AddMonster");
        }
    }
}
