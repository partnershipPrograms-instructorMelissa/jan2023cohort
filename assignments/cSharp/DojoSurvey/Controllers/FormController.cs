using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;    
    public class FormController : Controller  
    {
        //for each route this controller is to handle:
        [HttpGet("/result")]
        public ViewResult Result(){
            return View("result");
        }

        [HttpPost("/result")]
        public IActionResult CreateUser(string name, string location, string language, string comment){
            ViewBag.name = $"{name}";
            ViewBag.location = $"{location}";
            ViewBag.language = $"{language}";
            ViewBag.comment = $"{comment}";

            return View("result");
        }

        [HttpPost("/")]
        public RedirectToActionResult Method(){
            return RedirectToAction("");
        }
    }