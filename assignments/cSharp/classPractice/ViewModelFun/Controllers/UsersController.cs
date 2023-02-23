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
}