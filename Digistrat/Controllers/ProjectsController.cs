using Microsoft.AspNetCore.Mvc;

namespace Digistrat.Controllers
{
	public class ProjectsController : Controller
	{
		private readonly ILogger<ProjectsController> _logger;

		public ProjectsController(ILogger<ProjectsController> logger)
		{
			_logger = logger;
		}

		[Route("/projects")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
