using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers;

public class WeddingController : Controller
{

    private MyContext _context;

    public WeddingController( MyContext context)
    {
        _context = context;
    }

    [SessionCheck]
    [HttpGet("wedding/add")]
    public IActionResult AddWedding(){
        return View();
    }

    [HttpPost("wedding/create")]
    public IActionResult CreateWedding(Wedding wedding){
        Console.WriteLine($"======I'm here=====");
        if(ModelState.IsValid){
            _context.Weddings.Add(wedding);
            _context.SaveChanges();
            return RedirectToAction("Dashboard", "Home");
        }
        return View("AddWedding");
    }
}