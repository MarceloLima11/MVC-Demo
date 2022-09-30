using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCTest.Data.Context;
using MVCTest.Models;
using MVCTest.Repositoriy;

namespace MVCTest.Controllers;

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

    public IActionResult Create(Person person, [FromServices] RepositoryDefault _repositoryDefault)
    {
        _repositoryDefault.Add(person);
        return View("../Home/List");
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
