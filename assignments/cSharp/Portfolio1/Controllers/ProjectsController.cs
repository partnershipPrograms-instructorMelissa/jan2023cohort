using Microsoft.AspNetCore.Mvc;
namespace Portfolio1.Controllers;    
    public class ProjectController : Controller  
    {
        //for each route this controller is to handle:
        [HttpGet("/projects")]

        public string Projects(){
            return "These are my projects";
        }
    }