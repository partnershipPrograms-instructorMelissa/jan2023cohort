using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionPractice.Models;

namespace SessionPractice.Controllers;

public class UserController : Controller{
    [HttpGet("")] //overriding home
    public IActionResult Index(){
        return View();
    }
    [HttpPost("login")]
    public IActionResult Login(){
        return View();
    }
}