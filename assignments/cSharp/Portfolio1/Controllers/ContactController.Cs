using Microsoft.AspNetCore.Mvc;
namespace Portfolio1.Controllers;    
    public class ContactController : Controller  
    {
        //for each route this controller is to handle:
        [HttpGet("/contact")]

        public string Contact(){
            return "This is my Contact!";
        }
    }