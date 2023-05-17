using eAuction_touchdown.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eAuction_touchdown.Controllers
{
	public class HomeController : Controller
	{
		public ViewResult Index()
		{

			//UserEmailOptions options = new UserEmailOptions
			//{
			//    ToEmails = new List<string>() { "test@gmail.com"},
			//    PlaceHolders = new List<KeyValuePair<string, string>>()
			//    {
			//        new KeyValuePair<string, string>("{{UserName}}", "John")
			//    }
			//};

			//await _emailService.SendTestEmail(options);

			//var userId = _userService.GetUserId();
			//var isLoggedIn = _userService.IsAuthenticated();

			//bool isDisplay = _newBookAlertconfiguration.DisplayNewBookAlert;
			//bool isDisplay1 = _thirdPartyBookconfiguration.DisplayNewBookAlert;

			//var value = _messageRepository.GetName();

			//var newBook = configuration.GetSection("NewBookAlert");
			//var result = newBook.GetValue<bool>("DisplayNewBookAlert");
			//var bookName = newBook.GetValue<string>("BookName");

			//var result = configuration["AppName"];
			//var key1 = configuration["infoObj:key1"];
			//var key2 = configuration["infoObj:key2"];
			//var key3 = configuration["infoObj:key3:key3obj1"];
			return View();
		}
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		/*public IActionResult Index()
		{
			return View();
		}*/

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
