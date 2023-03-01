using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRApractice.Models;

namespace CRApractice.Controllers;

public class ToonController : Controller
{
    private MyContext _context;
    
    public ToonController(MyContext context){
        _context = context;
    }

    [HttpGet("allToons")]
    public IActionResult AllToons(){
        List<Toon> allToons = _context.Toons.ToList();
        return View("AllToons", allToons);
    }

    [HttpGet("addToon")]
    public IActionResult AddToon(){
        return View();
    }
    [HttpPost("createToon")]
    public IActionResult CreateToon(Toon toon){
        if(ModelState.IsValid){
            // add to database
            _context.Toons.Add(toon);
            // save to database
            _context.SaveChanges();
            Console.WriteLine($"{toon.Name} with ID {toon.ID} added to Toons database");
            return Redirect("allToons");
        }
        return View("addToon");
    }

}