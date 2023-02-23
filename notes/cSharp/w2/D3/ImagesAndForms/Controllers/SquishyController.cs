using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ImagesAndForms.Models;

namespace ImagesAndForms.Controllers;

public class SquishyController : Controller
{
    [HttpGet("/squishy")]
    public IActionResult SquishyIndex()
    {
        return View();
    }

    // render
    [HttpGet("/squishy/add")]
    public IActionResult AddSquishy(){
        return View();
    }

    // post
    [HttpPost("/squishy/create")]
    public IActionResult CreateSquishy(Squishy squish){
        return View("view", squish);
    }

    [HttpGet("/squishy/view")]
    public IActionResult ViewSquishy(){
        return View();
    }
}