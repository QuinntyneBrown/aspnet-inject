using System.Web.Optimization;

namespace Chloe.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var bundle = new ScriptBundle("~/bundles/app");
            bundles.Add(bundle);
            BundleTable.EnableOptimizations = true;
        }        
    }
}