using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers;

    public class Portfolio : Controller {

        [HttpGet]
        [Route("")]
        public string Index(){
            return "This is my index!";
        }

        [HttpGet]
        [Route("/projects")]
        public string projects(){
            return "These are my projects!";
        }

        [HttpGet]
        [Route("/contacts")]
        public string contacts(){
            return "joslyn";
        }
    }