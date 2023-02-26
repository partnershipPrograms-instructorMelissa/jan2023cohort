using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DataValidation.Models;

namespace DataValidation.Controllers;

public class TimeDateController : Controller
{
    [HttpGet("")]
    public IActionResult Index(){
        return View();
    }

    [HttpGet("checkTimeDate")]
    public IActionResult CheckTimeDate(TimeDate timeDate){
        if(ModelState.IsValid){
            return View("ViewTimeDate", timeDate);
        }
        return View("Index");
    }

    [HttpGet("viewTimeDate")]
    public IActionResult ViewTimeDate(){
        return View();
    }
}