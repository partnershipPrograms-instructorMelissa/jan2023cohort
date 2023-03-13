using Microsoft.AspNetCore.Mvc;

namespace Forms.Controllers;
public class HomeController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View();
    }
}