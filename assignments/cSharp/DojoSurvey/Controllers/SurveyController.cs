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

    [HttpGet("survey")]
    public IActionResult RegForm()
    {
        return View();
    }

    [HttpPost("survey")]
    public IActionResult Submission(Survey yourSurvey)
    {
        return View("Result", yourSurvey);
    }

    public IActionResult Result()
    {
        return View();
    }

}