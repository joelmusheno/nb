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
		readonly IBaseRepository<Location> LocationRepository;

		public HomeController(IBaseRepository<Need> needsRepository, IBaseRepository<Location> locationRepository){
			NeedsRepository = needsRepository;
			LocationRepository = locationRepository;

			if (!locationRepository.Query().Any()){
				LocationRepository.Save(new Location() {
					Name = "Home Base"
				});
				LocationRepository.Save(new Location() {
					Name = "Remote site"
				});
			}
				
		}


		public ActionResult Index()
		{
			ViewBag.TotalRequests = NeedsRepository.Query().Count();

			return View();
		}
	}
}

