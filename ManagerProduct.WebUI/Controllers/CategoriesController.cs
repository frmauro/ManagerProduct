using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ManagerProduct.WebUI.Models;
using ManagerProduct.Application.Interfaces;

namespace ManagerProduct.WebUI.Controllers;

public class CategoriesController : Controller
{
    private readonly ILogger<CategoriesController> _logger;
    private readonly ICategoryService _categoryService;

    public CategoriesController(ILogger<CategoriesController> logger,
    ICategoryService categoryService)
    {
        _logger = logger;
        _categoryService = categoryService;
    }

    public async Task<IActionResult> Index()
    {
        var categories = await _categoryService.GetAllAsync();
        return View(categories);
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
