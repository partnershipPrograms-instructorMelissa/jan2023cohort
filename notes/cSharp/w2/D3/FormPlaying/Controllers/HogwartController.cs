using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormPlaying.Models;

namespace FormPlaying.Controllers;

public class HogwartController : Controller
{
    [HttpGet("")] // ignoring home
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("/register")]
    public IActionResult RegForm(){
        return View();
    }

    [HttpPost("register")]
    // public IActionResult CreateStudent(string name, string house, int year){

    // }
    public IActionResult CreateStudent(HogwartsStudent student){
        student = new HogwartsStudent(student.Name, student.House, student.Year);

        return View(student);
    }
}