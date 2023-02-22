using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;
public class UserController : Controller
{
    [HttpGet("user")]
    public IActionResult AUser()
    {
        User newUser = new User("Nichole", "Richie");
      
        return View("User", newUser);
    }
        
    
}