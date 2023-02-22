using Microsoft.AspNetCore.Mvc;

namespace RazorFun.Controllers;
public class FoodController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View();
    }
}