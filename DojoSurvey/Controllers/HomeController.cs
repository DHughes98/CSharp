using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey;
public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("result")]
    public IActionResult Result(string name, string location, string language, string textarea)
    {
        ViewBag.name = name;
        ViewBag.location = location;
        ViewBag.language = language;
        ViewBag.textarea = textarea;

        return View();
    }
    
}