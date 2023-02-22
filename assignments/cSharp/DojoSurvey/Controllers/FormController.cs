using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;    
    public class FormController : Controller  
    {
        //for each route this controller is to handle:
        [HttpGet("/result")]

        public ViewResult Result(){
            return View();
        }

        [HttpGet("/result")]
        public IActionResult CreateUser(string name, string location, string language, string comment){
            ViewBag.name = $"{name}";
            ViewBag.location = $"{location}";
            ViewBag.language = $"{language}";
            ViewBag.comment = $"{comment}";

            return View("result");
        }
    }