using Microsoft.AspNetCore.Mvc;

namespace ViewModelFun.Controllers;
public class NumberController : Controller
{
    [HttpGet]
    [Route("numbers")]
    public IActionResult Number()
    {
        int[] numbers = {5, 38, 45, 99, 101, 17};
        return View(numbers);
    }
}