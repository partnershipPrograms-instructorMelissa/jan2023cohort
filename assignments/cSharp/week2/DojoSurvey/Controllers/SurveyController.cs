using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers;
public class SurveyController : Controller
{

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("result")]
    public IActionResult Result(Survey yourSurvey)
    {
        return View(yourSurvey);
    }
    [HttpPost("survey")]
    public IActionResult Submission(Survey yourSurvey)
    {
        if (ModelState.IsValid)
        {
            // Do somethng! Maybe insert into a database or log data to the console  
            // Then we will redirect to a new page        
            return RedirectToAction("Result", yourSurvey);
        }
        else
        {
            // Oh no! We need to return a ViewResponse to preserve the ModelState and the errors it now contains! 
            // Make sure you return the View that contains the form!       
            return View("Index");
        }
    }
}