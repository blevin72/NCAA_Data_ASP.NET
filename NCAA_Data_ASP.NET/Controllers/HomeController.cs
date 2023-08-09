using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NCAA_Data_ASP.NET.Models;

namespace NCAA_Data_ASP.NET.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;


    public HomeController(ILogger<HomeController> logger, IConfiguration configuration) //done
    {
        _logger = logger;
        _configuration = configuration;
    }



    public IActionResult Privacy() //done
    {
        return View();
    }


    //public HomeController(IConfiguration configuration)
    //{
    //    _configuration = configuration;
    //}

    public IActionResult Index() //done
    {
        string apiKey = _configuration["APIKey"];

        ViewBag.ApiKey = apiKey;

        return View();
    }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() //done
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

