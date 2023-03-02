using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DateValidator.Models;

namespace DateValidator.Controllers;

public class TimeValidatorController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("result")]
    public IActionResult Result(TimeValidator yourTime)
    {
        // The if statement triggers if our model passed its validation checks
        if (ModelState.IsValid)
        {
            // Do somethng! Maybe insert into a database or log data to the console  
            // Then we will redirect to a new page        
            return View("Result", yourTime); ;
        }
        else
        {
            // Oh no! We need to return a ViewResponse to preserve the ModelState and the errors it now contains! 
            // Make sure you return the View that contains the form!       
            return View("Index");
        }
    }

}