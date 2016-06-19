using System;
using System.Web.Mvc;
using nb.Infrastructure;
using nb.Models;

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
			
			var mvcName = typeof(Controller).Assembly.GetName();
			var isMono = Type.GetType("Mono.Runtime") != null;

			ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData["Runtime"] = isMono ? "Mono" : ".NET";

			return View();
		}
	}
}

