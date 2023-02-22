using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;
public class UsersController : Controller
{
    [HttpGet("users")]
    public IActionResult Users()
    {
        List<User> users = new List<User>();
        users.Add(new User("Moose", "Phillips"));
        users.Add(new User("Sarah", ""));
        users.Add(new User("Rene", "Ricky"));
        users.Add(new User("Barbarah", ""));
        return View(users);
    }
}