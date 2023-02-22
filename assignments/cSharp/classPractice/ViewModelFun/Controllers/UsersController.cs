using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class UsersController : Controller
{
    public List<User> users = new List<User>(){
        new User("Moose", "Phillips"),
        new User("Sarah"),
        new User("Jerry"),
        new User("Rene", "Ricky"),
        new User("Barbarah"),
    };

    [HttpGet("/users")]
    public IActionResult Users()
    {
        return View(users);
    }

    // [HttpGet("/user")]
    // public ViewResult SingleUser(){
    //     Random rand = new Random();

    //     return View(users[rand.Next(users.Count)]);
    // }
    // public RedirectToActionResult RandomUser(){
    //     List<User> users = new List<User>(){
    //         new User("Moose", "Phillips"),
    //         new User("Sarah"),
    //         new User("Jerry"),
    //         new User("Rene", "Ricky"),
    //         new User("Barbarah"),
    //     };

    //     Random rand = new Random();

    //     return RedirectToAction("User", "user", new {user = users[rand.Next(users.Count)]});
    // }
}