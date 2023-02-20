using Microsoft.AspNetCore.Mvc;
namespace SecondWebApp.Controllers;     //be sure to use your own project's namespace!
    public class SquishyController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet("/squishy")]       //type of request
        public ViewResult Squishy(){
            return View();
        }
    }