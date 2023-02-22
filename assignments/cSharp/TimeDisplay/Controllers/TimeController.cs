using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay.Controllers;
public class TimeController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View();
    }
}