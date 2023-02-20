using Microsoft.AspNetCore.Mvc;
namespace Portfolio1.Controllers;    
    public class ProjectsController : Controller  
    {
        //for each route this controller is to handle:
        [HttpGet("/projects")]

        public ViewResult Projects(){
            return View();
        }
    }