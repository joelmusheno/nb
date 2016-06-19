using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using Ninject.Web.Common;
using Ninject;
using System;
using System.Reflection;
using nb.Infrastructure;
using nb.Models.Foundation;
using Ninject.Web.WebApi;
using System.Web.Optimization;

namespace nb
{
	public class Global : NinjectHttpApplication
	{
		protected override IKernel CreateKernel()
		{
			var kernel = new StandardKernel();
			kernel.Load(Assembly.GetExecutingAssembly());
			return kernel;
		}

		protected override void OnApplicationStarted()
		{
			base.OnApplicationStarted();

			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}


	}
}
