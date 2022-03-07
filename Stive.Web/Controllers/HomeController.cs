using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Stive.Web.Models;
using System.Net;
using System.Web;
namespace Stive.Web.Controllers;



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

    public IActionResult element(int id)
    {
        ViewData["id"] = id;

        return View();
    }

    public IActionResult paywall(int id, int number)
    {
        ViewData["id"] = id;
        
        ViewData["number"] = number;

        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
