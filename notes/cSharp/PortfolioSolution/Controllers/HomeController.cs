using Microsoft.AspNetCore.Mvc;
namespace PortfolioSolution.Controllers;
public class HomeController : Controller
{

    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("/projects")]
    public IActionResult Projects()
    {
        return View("Projects");
    }

    [HttpGet("/contact")]
    public IActionResult Contact()
    {
        return View();
    }
}