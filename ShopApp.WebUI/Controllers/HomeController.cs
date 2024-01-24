using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Abstract;
using ShopApp.WebUI.Models;
using System.Diagnostics;

namespace ShopApp.WebUI.Controllers
{
	public class HomeController : Controller
	{
		//private readonly IConfiguration _configuration;
		private readonly IProductService _productService;

		public HomeController(IProductService productService)
		{
			_productService = productService;
		}

		public IActionResult Index()
		{
			return View(new ProductListModel()
			{
				Products = _productService.GetPopulerProducts()

			}); 
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
}