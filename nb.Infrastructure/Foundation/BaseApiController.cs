using System;
using System.Web.Http;
using nb.Models.Foundation;
using System.Linq;

namespace nb.Infrastructure
{
	public class BaseApiController<T>:ApiController where T:IBaseModel
	{
		readonly IBaseRepository<T> Repo;

		public BaseApiController(IBaseRepository<T> repo) {
			Repo = repo;
		}

		[HttpGet]
		public IQueryable<T> Query() {
			return Repo.Query();
		}

		[HttpPut]
		public T Save(T entity){
			return Repo.Save(entity);
		}

		[HttpDelete]
		public void Delete(T entity){
			Repo.Delete(entity);;
		}
	}
}

