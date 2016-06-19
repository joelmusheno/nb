using System;
using nb.Infrastructure;
using nb.Models.Foundation;
using Ninject.Modules;
using nb.Models;
namespace nb
{
	public class NinjectControllerModule:NinjectModule
	{
		public override void Load()
		{
			Bind(typeof(IBaseRepository<Need>)).To(typeof(InMemoryRepository<Need>)).InSingletonScope();
			//Bind(typeof(IBaseRepository<IBaseModel>)).To(typeof(InMemoryRepository<IBaseModel>));
		}
	}
}

