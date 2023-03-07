using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers;

public class WeddingController : Controller
{

    private MyContext _context;  // or use _context instead of db (Make sure this matches on all controller files)

    public WeddingController(MyContext context)
    {
        _context = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    private int? uid
    {
        get
        {
            return HttpContext.Session.GetInt32("uid");
        }
    }

    // Recommend routeName and FunctionName be the same
    [SessionCheck]
    [HttpGet("weddings/{id}")]
    public IActionResult Details(int id)
    {
        Wedding? ViewWedding = _context.Weddings
        .FirstOrDefault(i => i.WeddingId == id);
        if (ViewWedding != null)
        {
            return View(ViewWedding);
        }
        else
        {
            return RedirectToAction("WeddingList");
        }
    }


    [SessionCheck]
    [HttpGet("weddings/new")]
    public IActionResult Create()
    {
        List<Wedding> allWeddings = _context.Weddings.ToList();
        return View();
    }

    [SessionCheck]
    [HttpPost("weddings/new")]
    public IActionResult AddWedding(Wedding newWedding)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newWedding);
            _context.SaveChanges();
            return RedirectToAction("Details");
        }
        else
        {
            return View("Create");
        }
    }

}