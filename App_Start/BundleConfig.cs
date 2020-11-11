using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVCTest.App_Start
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			//BundleTable.EnableOptimizations = true;
			var bundleCss = new StyleBundle("~/Bundles/Css").Include("~/Bundles/Css/bootstrap.min.css");
			
			bundles.Add(bundleCss);
		}
	}
}