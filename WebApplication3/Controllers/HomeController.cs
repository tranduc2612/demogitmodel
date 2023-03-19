using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		Qlbansach1Context db = new Qlbansach1Context();
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			var lst = db.TNhanViens.AsNoTracking().ToList();
			ViewBag.lst = lst;
			return View();
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