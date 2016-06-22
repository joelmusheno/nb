using System;
using System.Web.Http.Dependencies;
using Ninject;

namespace nb.Infrastructure
{
	public class NinjectResolver : NinjectScope, System.Web.Http.Dependencies.IDependencyResolver,
													  System.Web.Mvc.IDependencyResolver
	{
		private readonly IKernel _kernel;

		public NinjectResolver(IKernel kernel) : base(kernel)
		{
			_kernel = kernel;

		}
		public IDependencyScope BeginScope()
		{
			return new NinjectScope(_kernel.BeginBlock());

		}
	}
}

