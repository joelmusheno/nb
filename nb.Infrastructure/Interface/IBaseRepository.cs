using System;
using nb.Models.Foundation;
using System.Linq;
using System.Linq.Expressions;

namespace nb.Infrastructure
{
	public interface IBaseRepository<T> where T: IBaseModel
	{
		//IQueryable<T> Query(Func<Expression<T>> query);
		IQueryable<T> Query();
 		T Save(T entity);
		void Delete(T entity);
	}
}

