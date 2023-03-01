using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RandomPasscodeGenerator.Models;

namespace RandomPasscodeGenerator.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // session set to 0
        HttpContext.Session.SetInt32("value",0);
        return View();
    }

    [HttpGet("generate")]
    public IActionResult Generate(){
        // ====== Session =======
        // session get
        int? oldVal = HttpContext.Session.GetInt32("value");
        int newVal = oldVal.Value + 1;
        // session set with changed value
        HttpContext.Session.SetInt32("value", newVal);
        // ====== Passcode ======
        string passcode = "";

        Random rand = new Random();
        while(passcode.Length < 14){
            // number
            if(rand.Next(4) == 0){
                passcode += (char)rand.Next(48, 58);
            } 
            // letter
            else{
                passcode += (char)rand.Next(65, 91);
            }
        }

        return View("randGen", passcode);
    }

    [HttpGet("randGen")]
    public IActionResult RandGeneration(){
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
