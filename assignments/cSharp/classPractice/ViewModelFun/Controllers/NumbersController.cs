using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class NumbersController : Controller
{
    int[] num = new int[]{
        1, 
        2,
        3,
        10,
        43,
        5,
    };

    [HttpGet("/numbers")]
    public IActionResult Numbers()
    {
        return View(num);
    }
}