using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRApractice.Models;

namespace CRApractice.Controllers;

public class SquishyController : Controller
{
    private MyContext _context;
    
    public SquishyController(MyContext context){
        _context = context;
    }

    [HttpGet("allSquishies")]
    public IActionResult AllSquishies(){
        if(HttpContext.Session.GetInt32("uid") == null){
            return RedirectToAction("Index", "User");
        }
        List<Squishy> allSquishies = _context.Squishies.ToList();
        return View("AllSquishies", allSquishies);
    }

    // create
    [HttpGet("addSquishy")]
    public IActionResult AddSquishy(){
        if(HttpContext.Session.GetInt32("uid") == null){
            return RedirectToAction("Index", "User");
        }
        return View();
    }
    [HttpPost("createSquishy")]
    public IActionResult CreateSquishy(Squishy squishy){
        if(ModelState.IsValid){
            // add to database
            _context.Squishies.Add(squishy);
            // save to database
            _context.SaveChanges();
            Console.WriteLine($"{squishy.Name} with ID {squishy.ID} added to Squishies database");
            return Redirect("allSquishies");
        }
        return View("addSquishy");
    }

    // read - view one
    [HttpGet("squishy/{squishyID}/view")]
    public IActionResult ViewSquishy(int squishyID){
        if(HttpContext.Session.GetInt32("uid") == null){
            return RedirectToAction("Index", "User");
        }
        Squishy? item = _context.Squishies.FirstOrDefault(i => i.ID == squishyID);
        if(item == null){
            return RedirectToAction("AllSquishies");
        }
        return View(item);
    }

    // update
    [HttpGet("squishy/{squishyID}/edit")]
    public IActionResult EditSquishy(int squishyID){
        if(HttpContext.Session.GetInt32("uid") == null){
            return RedirectToAction("Index", "User");
        }
        Squishy? item = _context.Squishies.FirstOrDefault(i => i.ID == squishyID);
        if(item == null){
            return RedirectToAction("AllSquishies");
        }
        else{
            return View(item);
        }
    }

    [HttpPost("squishy/{squishyID}/update")]
    public IActionResult UpdateSquishy(Squishy newItem, int squishyID){
        Squishy? oldItem = _context.Squishies.FirstOrDefault(i => i.ID == squishyID);
        if(ModelState.IsValid){
            // update info
            oldItem.Name = newItem.Name;
            oldItem.Img = newItem.Img;
            oldItem.Location = newItem.Location;
            oldItem.UpdatedAt = DateTime.Now;
            // save new info
            _context.SaveChanges();
            return RedirectToAction("AllSquishies");
        }
        else{
            return View("EditSquishy", squishyID);
        }
    }

    // delete
    [HttpGet("squishy/{squishyID}/delete")]
    public IActionResult DeleteSquishy(int squishyID){
        Squishy? itemToDelete = _context.Squishies.SingleOrDefault(i => i.ID == squishyID);
        if(itemToDelete != null){
            _context.Squishies.Remove(itemToDelete);
            _context.SaveChanges();
        }
        return RedirectToAction("AllSquishies");

    }

    // [HttpPost("monsters/{MonsterId}/destroy")]
    // public IActionResult DestroyMonster(int MonsterId)
    // {
    //     Monster? MonToDelete = _context.Monsters.SingleOrDefault(i => i.MonsterId == MonsterId);
    //     // Once again, it could be a good idea to verify the monster exists before deleting
    //     _context.Monsters.Remove(MonToDelete);
    //     _context.SaveChanges();
    //     return RedirectToAction("Index");
    // }

}