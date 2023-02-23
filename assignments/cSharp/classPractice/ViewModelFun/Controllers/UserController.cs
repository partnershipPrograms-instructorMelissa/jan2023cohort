using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class UserController : Controller
{
    [HttpGet("/user")]
    public IActionResult User(){
        UsersController allUsers = new UsersController();
        Random rand = new Random();
        User user = allUsers.users[rand.Next(allUsers.users.Count)];

        return View(user);
    }
}