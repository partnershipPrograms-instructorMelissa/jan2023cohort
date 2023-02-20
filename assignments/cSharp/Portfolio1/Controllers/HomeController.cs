using Microsoft.AspNetCore.Mvc;
namespace Portfolio1.Controllers;    
    public class HomeController : Controller  
    {
        //for each route this controller is to handle:
        [HttpGet("")]

        public string Index(){
            return "This is my Index!";
        }
    }