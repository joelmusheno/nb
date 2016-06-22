using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using nb.Infrastructure;
using nb.Models;

namespace nb.Controllers
{
	public class DataController : ApiController
	{
		readonly IBaseRepository<Need> NeedRepository;

		public DataController(IBaseRepository<Need> needRepository)
		{
			NeedRepository = needRepository;
		}

		[HttpGet]
		public Need GetSingleById(int id)
		{
			return NeedRepository.Query().FirstOrDefault(x => x.Id == id);
		}

	}
}
