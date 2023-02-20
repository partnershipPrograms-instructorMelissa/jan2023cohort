using Microsoft.AspNetCore.Mvc;

namespace Portfolio2.Controllers;
public class UserController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View();
    }
}