using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicous.Models;

namespace CRUDelicous.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        List<Dish> AllDishes = _context.Dishes.OrderByDescending(d => d.CreatedAt).ToList();
        return View(AllDishes);
    }

    [HttpGet("dishes/new")]
    public IActionResult NewDish()
    {
        return View();
    }

    [HttpPost("dishes/create")]
    public IActionResult CreateDish(Dish newDish)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            return View("NewDish");
        }
    }

    [HttpGet("dishes/{id}")]
    public IActionResult ShowDish(int id)
    {
        Dish? OneDish = _context.Dishes.FirstOrDefault(d => d.DishID == id);
        return View(OneDish);
    }

    [HttpGet("dishes/{DishID}/edit")]
    public IActionResult EditDish(int DishID)
    {
        Dish? DishToEdit = _context.Dishes.FirstOrDefault(d => d.DishID == DishID);
        return View(DishToEdit);
    }

    [HttpPost("dishes/{DishID}/update")]
    public IActionResult UpdateDish(Dish newDish, int DishID)
    {
        if (ModelState.IsValid)
        {
            Dish? OldDish = _context.Dishes.FirstOrDefault(d => d.DishID == DishID);
            OldDish.Name = newDish.Name;
            OldDish.Chef = newDish.Chef;
            OldDish.Calories = newDish.Calories;
            OldDish.Tastines = newDish.Tastines;
            OldDish.Desciption = newDish.Desciption;

            OldDish.UpdatedAt = DateTime.Now;
            _context.SaveChanges();

            return Redirect($"/dishes/{DishID}");
        }
        else
        {
            return View("EditDish", newDish);
        }
    }

    [HttpPost("dishes/{DishID}/destroy")]
    public IActionResult DestroyDish(int DishID)
    {
        Dish? DishToDelete = _context.Dishes.SingleOrDefault(d => d.DishID == DishID);
        _context.Dishes.Remove(DishToDelete);
        _context.SaveChanges();
        return RedirectToAction("Index");
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
