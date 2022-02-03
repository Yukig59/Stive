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

    public string path(Microsoft.AspNetCore.Http.HttpContext context) { 
        var host = $"{context.Request.Path}"; 
        return host;    
    }

    public IActionResult Privacy()
    {
        return View();
    }


     public async Task<string> get()
    {
        string page = "http://localhost:7211/Home/api";


        using (HttpClient client = new HttpClient())
        {
            // autre possibilité
            //client.BaseAddress = new Uri(page);
        
            // on peut compléter le header
            //client.DefaultRequestHeaders.Add("X-TEST", "123");
        
            // la requête
            using (HttpResponseMessage response = await client.GetAsync(page))
            {
        
                using (HttpContent content = response.Content)
                {
                    // récupère la réponse, il ne resterai plus qu'à désérialiser
                    string result = await content.ReadAsStringAsync();
                    return result;
                }
            }
        }
        // return View();
    }


    public async Task<string> post()
    {


        var page = new Uri("http://localhost:7211/Home/api");
        
        using (WebClient client = new WebClient())
        {
            return await client.UploadStringTaskAsync(page, "{Titre:\"Tartuffe\", Auteur:\"Molière\"}");
        }

        // return View();
    }



    public IActionResult api()
    {
        string formValue;

        Console.WriteLine(Request.Form["t"]);
        Console.WriteLine(Request);
        // if (!string.IsNullOrEmpty(Request.Form["Titre"]))
        // {
        //     formValue= Request.Form["Titre"];
        //     Console.WriteLine(formValue);

        // }
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

public class Livre
{
   public string Titre { get; set; }
  
   public string Auteur { get; set; }
}