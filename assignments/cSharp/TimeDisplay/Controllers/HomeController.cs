using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay.Controllers;    
    public class HomeController : Controller  
    {
        //for each route this controller is to handle:
        [HttpGet("")]

        public ViewResult Index(){
            return View();
        }
    }