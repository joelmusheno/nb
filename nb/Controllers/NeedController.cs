using System;
using nb.Infrastructure;
using nb.Models;

using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Linq;
namespace nb
{
	public class NeedController : Controller
	{
		readonly IBaseRepository<Need> NeedRepository;

		public NeedController(IBaseRepository<Need> needRepository)
		{
			NeedRepository = needRepository;
		}

		public ActionResult Index()
		{
			var nl = NeedRepository.Query().ToList();
			return View(nl);
		}

		public ActionResult Create()
		{
			var need = new Need() {
				Name = "Created By..",
				CreateDate = DateTime.Now
			};

			return View(need);
		}

		[HttpPost, ValidateAntiForgeryToken]
		public ActionResult Create(Need need)
		{
			if (ModelState.IsValid) {
				NeedRepository.Save(need);
				return RedirectToAction("Index");
			}

			return View(need);
		}



	}
}

