using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidation.Models;
namespace DojoSurveyValidation.Controllers;    
    public class FormController : Controller  
    {
        //for each route this controller is to handle:
        [HttpGet("form/result")]
        public ViewResult Result(){
            return View("result");
        }

        [HttpPost("form/result")]
        public IActionResult Result(Form form){
            if(ModelState.IsValid){
                return View("ViewResult",form);
            }
            else{
                return RedirectToAction("");
            }
        }

        [HttpGet("/viewResult")]
        public IActionResult ViewResult(){
            return View();
        }

        [HttpPost("/")]
        public RedirectToActionResult Method(){
            return RedirectToAction("");
        }
    }