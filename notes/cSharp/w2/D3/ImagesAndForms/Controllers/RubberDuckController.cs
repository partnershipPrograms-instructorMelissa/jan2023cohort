using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ImagesAndForms.Models;

namespace ImagesAndForms.Controllers;

public class RubberDuckController : Controller
{
    [HttpGet("/rubber_duck")]
    public IActionResult DuckIndex()
    {
        return View();
    }

    [HttpGet("/rubber_duck/add")]
    public IActionResult AddDuck(){
        return View();
    }

    [HttpPost("/rubber_duck/create")]
    public IActionResult CreateDuck(RubberDuck duck){
        return View("ViewDuck", duck);
    }

    [HttpGet("/rubber_duck/view")]
    public IActionResult ViewDuck(){
        return View();
    }
}