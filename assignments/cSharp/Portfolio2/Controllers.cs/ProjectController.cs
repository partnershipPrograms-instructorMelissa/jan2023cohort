using Microsoft.AspNetCore.Mvc;

namespace Portfolio2.Controllers;
public class ProjectController : Controller
{
    [HttpGet]
    [Route("/projects")]
    public ViewResult Project()
    {
        return View();
    }
}