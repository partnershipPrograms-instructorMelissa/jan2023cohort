using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidation.Models;
namespace DojoSurveyValidation.Controllers;    
    public class FormController : Controller  
    {
        [HttpGet("")]
        public ViewResult Index(){
            return View();
        }

        [HttpPost("create")]
        public IActionResult Result(Form form){
            if(ModelState.IsValid){
                return View("ViewResult", form);
            }
            return View("Index");
        }

        [HttpGet("viewResult")]
        public ViewResult ViewResult(){
            return View();
        }
    }