using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Validations.Models;

namespace Validations.Controllers;
public class UserController : Controller {
    [HttpGet("user")]
    public IActionResult User(){
        return View();
    }

    [HttpGet("someAction")]
    public IActionResult SomeAction(){
        return View();
    }

    // Other routes
    [HttpPost("user/create")]
    public IActionResult Create(User user)
    {    
        // The if statement triggers if our model passed its validation checks
        if(ModelState.IsValid)    
        {        
            // Do something! Maybe insert into a database or log data to the console  
            // Then we will redirect to a new page        
            return View("SomeAction", user);    
        }    
        else    
        {        
            // Oh no! We need to return a ViewResponse to preserve the ModelState and the errors it now contains! 
            // Make sure you return the View that contains the form!       
            return View("NewUser");    
        }
    }
}

