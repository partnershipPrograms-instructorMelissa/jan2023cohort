using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;    
    public class FormController : Controller  
    {
        [HttpGet("")]
        public ViewResult Index(){
            return View();
        }

        [HttpPost("create")]
        public IActionResult Result(Form form){
            return View("ViewResult", form);
        }

        [HttpGet("viewResult")]
        public ViewResult ViewResult(){
            return View();
        }
    }