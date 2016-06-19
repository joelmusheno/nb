using System;
using nb.Infrastructure;
using nb.Models.Foundation;
using nb.Models;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace nb.Infrastructure
{
	public class InMemoryRepository<T> : IBaseRepository<T> where T : IBaseModel
	{
		readonly Dictionary<int, T> data;

		public InMemoryRepository()
		{
			data = new Dictionary<int, T>();
		}

		public void Delete(T entity)
		{
			if (data.Keys.Contains(entity.Id))
				data.Remove(entity.Id);
		}

		public IQueryable<T> Query()
		{
			return data.Values.AsQueryable();
		}

		public T Save(T entity)
		{
			if (entity.Id <= 0)
				entity.Id = data.Keys.Count + 1;
			else
				data[entity.Id] = entity;

			return data[entity.Id];
		}

	}
}

