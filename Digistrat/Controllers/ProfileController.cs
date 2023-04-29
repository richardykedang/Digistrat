﻿using Microsoft.AspNetCore.Mvc;

namespace Digistrat.Controllers
{
	public class ProfileController : Controller
	{
		private readonly ILogger<ProfileController> _logger;

		public ProfileController(ILogger<ProfileController> logger)
		{
			_logger = logger;
		}


		[Route("/profile")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
