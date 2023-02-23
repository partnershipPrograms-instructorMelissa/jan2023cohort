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
        public IActionResult Result(Form form){
            return View(form);
        }

        [HttpPost("/")]
        public RedirectToActionResult Method(){
            return RedirectToAction("");
        }
    }