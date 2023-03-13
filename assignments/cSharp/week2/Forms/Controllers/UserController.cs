using Microsoft.AspNetCore.Mvc;

namespace Forms.Controllers;
public class UserController : Controller
{
    // [HttpGet]
    // [Route("")]
    // public ViewResult User()
    // {
    //     return View("Index");
    // }

    [HttpPost]
    [Route("/result")]
    public IActionResult CreateUser(string name, string location, string language, string comment)
    {
        ViewBag.name = $"{name}";
        ViewBag.location = $"{location}";
        ViewBag.language = $"{language}";
        ViewBag.comment = $"{comment}";

        return View("user");
    }

}