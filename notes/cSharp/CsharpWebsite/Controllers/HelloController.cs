using Microsoft.AspNetCore.Mvc;

namespace CsharpWebsite.Controllers;
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "Hello World from HelloController!";
        }

        [HttpGet]
        [Route("hello/{name}")]
        public string Greet(string name)
        {
            return $"Hello {name!}";
        }
    }

