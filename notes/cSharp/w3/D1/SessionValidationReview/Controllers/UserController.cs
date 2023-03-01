using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionValidationReview.Models;

namespace SessionValidationReview.Controllers;

public class UserController:Controller{
    [HttpGet("regUser")]
    public IActionResult RegUser(){
        return View();
    }

    [HttpPost("regUser")]
    public IActionResult CreateUser(User user){
        if(ModelState.IsValid){
            // set session
            string userFirstName = user.FirstName;
            HttpContext.Session.SetString("FirstName", userFirstName);
            // HttpContext.Session.GetString("FirstName");
            // redirect
            return RedirectToAction("Dashboard", user);
        }
        return View("RegUser");
    }

    [HttpGet("dashboard")]
    public IActionResult Dashboard(User user){
        return View(user);
    }

    [HttpGet("logout")]
    public IActionResult Logout(){
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Home");
    }
}