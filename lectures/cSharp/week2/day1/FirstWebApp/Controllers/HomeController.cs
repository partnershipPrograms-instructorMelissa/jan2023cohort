using Microsoft.AspNetCore.Mvc;
namespace FirstWebApp.Controllers;     //be sure to use your own project's namespace!
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public string Index()
        {
            return "Hello World from the Home Controller!";
        }
        [HttpGet("/hello")]
        public string Hello() {
            return "Whats cooking?";
        }
    }

