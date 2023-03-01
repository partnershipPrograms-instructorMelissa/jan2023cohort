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
        List<Squishy> allSquishies = _context.Squishies.ToList();
        return View("AllSquishies", allSquishies);
    }

    [HttpGet("addSquishy")]
    public IActionResult AddSquishy(){
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

    // [HttpPost("monsters/{MonsterId}/update")]
    // public IActionResult UpdateMonster(Monster newMon, int MonsterId)
    // {
    //     // 2. Find the old version of the instance in your database
    //     Monster? OldMonster = _context.Monsters.FirstOrDefault(i => i.MonsterId == MonsterId);
    //     // 3. Verify that the new instance passes validations
    //     if(ModelState.IsValid)
    //     {
    //         // 4. Overwrite the old version with the new version
    //         // Yes, this has to be done one attribute at a time
    //         OldMonster.Name = newMon.Name;
    //         OldMonster.Height = newMon.Height;
    //         OldMonster.Description = newMon.Description;
    //         // You updated it, so update the UpdatedAt field!
    //         OldMonster.UpdatedAt = DateTime.Now;
    //         // 5. Save your changes
    //         _context.SaveChanges();
    //         // 6. Redirect to an appropriate page
    //         return RedirectToAction("Index");
    //     } else {
    //         // 3.5. If it does not pass validations, show error messages
    //         // Be sure to pass the form back in so you don't lose your changes
    //         // It should be the old version so we can keep the ID
    //         return View("EditMonster", OldMonster);
    //     }
    // }

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