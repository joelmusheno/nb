using System;
using nb.Infrastructure;
using nb.Models;
using System.Web.Http;
namespace nb
{
	public class NeedController:ApiController
	{
		readonly IBaseRepository<Need> Repo;
		public NeedController(IBaseRepository<Need> repo) {
			Repo = repo;
		}
	}
}

