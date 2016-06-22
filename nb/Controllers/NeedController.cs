using System;
using nb.Infrastructure;
using nb.Models;
using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace nb
{
	public class NeedController : Controller
	{
		readonly IBaseRepository<Need> NeedRepository;
		readonly IBaseRepository<Location> LocationRepository;

		public NeedController(IBaseRepository<Need> needRepository, 
		                      IBaseRepository<Location> locationRepository)
		{
			NeedRepository = needRepository;
			LocationRepository = locationRepository;
		}

		public ActionResult Index()
		{
			var nl = NeedRepository.Query().ToList();
			return View(nl);
		}

		public ActionResult Create()
		{
			IEnumerable<SelectListItem> ls = from l in LocationRepository.Query()
					 select new SelectListItem() { Text = l.Name, Value = l.Id.ToString() };
			ViewBag.Locations = ls.ToList();

			var need = new Need() {
				CreateDate = DateTime.Now
			};

			return View(need);
		}

		[HttpPost, ValidateAntiForgeryToken]
		public ActionResult Create(Need need)
		{
			IEnumerable<SelectListItem> ls = from l in LocationRepository.Query()
				select new SelectListItem() { Text = l.Name, Value = l.Id.ToString()};
			ViewBag.Locations = ls.ToList();

			                               
			if (ModelState.IsValid) {
				need.Location = LocationRepository.Query().Single(x => x.Id == need.Location.Id);
				need.CreateDate = DateTime.Now;
				NeedRepository.Save(need);
				return RedirectToAction("Index");
			}

			return View(need);
		}



	}
}

