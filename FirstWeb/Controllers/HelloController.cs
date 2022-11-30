using Microsoft.AspNetCore.Mvc;
namespace FirstWeb.Controllers;
public class HelloController : Controller
{
    // Routing!!
    // This tells our controoler we have a web page we want to see (or GET})
    [HttpGet]
    // What is url
    // if blank goes to localhost:5XXX/
    [Route("")]
    public ViewResult Index()
    {
        // Viewbag allows us to pass data from our controller to our view
        // Think of a viewbag as a dictionary it has keys and values
        ViewBag.Name = "Dillon";
        ViewBag.Number = 7;
        return View("Index");
    }

// localhost:5XXX/user/more
    [HttpGet("user/more")]
    public ViewResult AUser()
    {
        //If its empty it assumes the name of the action as the name of the cshtml file
        ViewBag.Name = "Dan";
        return View();
    }

    [HttpGet("user/{id}")]
    public string OneUser(int id)
    {
        return $"This is user {id}";
    }
}