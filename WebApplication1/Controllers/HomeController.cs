using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Services()
    {
        return View();
    }

    public IActionResult GiftCards()
    {
        return View();
    }
    public IActionResult Memberships()
    {
            return View();
    }

     public IActionResult Privacy()
    {
            return View();
    }
    public IActionResult Franchise(){
        return View();
    }
    public IActionResult Careers(){
        return View();
    }
    public IActionResult Locations(){
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
