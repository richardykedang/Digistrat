using Microsoft.AspNetCore.Mvc;

namespace Digistrat.Controllers
{
	public class TicketsController : Controller
	{
		private readonly ILogger<TicketsController> _logger;

		public TicketsController(ILogger<TicketsController> logger)
		{
			_logger = logger;
		}

		[Route("/tickets-details")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
