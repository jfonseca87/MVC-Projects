using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MvcQuintoDia_Lab1.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Bundles").Include("~/Script/*.js"));
            BundleTable.EnableOptimizations = true;
        }
    }
}