using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionPasscode.Models;

namespace SessionPasscode.Controllers;

public class UserController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    // [HttpGet("result")]
    // public IActionResult Result()
    // {
    //     return View();
    // }

    [HttpPost("")]
    public IActionResult Submission()
    {
        HttpContext.Session.SetString("FirstName", "Kay");

        string userName = HttpContext.Session.GetString("FirstName");
        // To store an int in session we use ".SetInt32"
        HttpContext.Session.SetInt32("Passwords", 1);
              
        // To retrieve an int from session we use ".GetInt32"
        int? IntVariable = HttpContext.Session.GetInt32("Passwords");
         
        return View("Index");
    }

    [HttpGet("clear")]
    public IActionResult ClearSession()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

}