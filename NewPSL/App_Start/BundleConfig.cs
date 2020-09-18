using System.Web;
using System.Web.Optimization;

namespace NewPSL
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/assets/js/jquery-3.2.1.min.js",
                      "~/assets/js/popper.min.js",
                      "~/assets/plugins/slimscroll/jquery.slimscroll.min.js",
                      "~/assets/plugins/raphael/raphael.min.js",
                      "~/assets/plugins/morris/morris.min.js",
                      "~/assets/js/chart.morris.js",
                      "~/assets/js/script.js"

                      ));
 
    

              bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/simple-sidebar.css",
                      "~/Content/site.css",
                      "~/assets/css/bootstrap.min.css",
                      "~/assets/css/font-awesome.min.css",
                      "~/assets/css/feathericon.min.css",
                      "~/assets/plugins/morris/morris.css",
                      "~/assets/css/style.css"

                      ));
        }
    }
}
