using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ManagerProduct.WebUI.Models;
using ManagerProduct.Application.Interfaces;

namespace ManagerProduct.WebUI.Controllers;

public class ProductsController : Controller
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productAppService)
    {
        _productService = productAppService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var products = await _productService.GetAllAsync();
        return View(products);
    }
}

