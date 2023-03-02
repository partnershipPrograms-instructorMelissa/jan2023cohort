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

    [HttpGet("result")]
    public IActionResult Result()
    {
        return View();
    }

    [HttpPost("result")]
    public IActionResult Submission(User user)
    {
        string theUser = user.FirstName;
        HttpContext.Session.SetString("FirstName", theUser);
        string getUser = HttpContext.Session.GetString("FirstName");

        return View("Result", user);
    }

    [HttpGet("clear")]
    public IActionResult ClearSession()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }
    
}