using System;
using System.Web.Mvc;
using nb.Infrastructure;
using nb.Models;
using System.Linq;

namespace nb.Controllers
{
	public class HomeController : Controller
	{
		readonly IBaseRepository<Need> NeedsRepository;


 		public HomeController(IBaseRepository<Need> needsRepository){
			NeedsRepository = needsRepository;
		}


		public ActionResult Index()
		{
			ViewBag.TotalRequests = NeedsRepository.Query().Count();

			return View();
		}
	}
}

