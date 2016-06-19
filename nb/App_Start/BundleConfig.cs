using System.Web;
using System.Web.Optimization;

namespace nb
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));
			bundles.Add(new StyleBundle("~/bootstrap/").Include("~/Content/bootstrap.css",
			                    "~/Content/jumbotron-narrow.css"));
		}
	}

}

