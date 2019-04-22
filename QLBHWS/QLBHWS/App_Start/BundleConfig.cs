using System.Web;
using System.Web.Optimization;

namespace QLBHWS
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //-------------------------------Obaju------------------------------
            bundles.Add(new StyleBundle("~/obaju/css").Include(
                     "~/obajuStyle/css/bootstrap.min.css",
                     "~/obajuStyle/css/animate.min.css",
                     "~/obajuStyle/css/owl.carousel.css",
                     "~/obajuStyle/css/owl.theme.css",
                     "~/obajuStyle/css/style.default.css"));

            bundles.Add(new StyleBundle("~/Content/js").Include(
                      "~/obajuStyle/js/bootstrap.min.js",
                      "~/obajuStyle/js/jquery.cookie.js",
                      "~/obajuStyle/js/waypoints.min.js",
                      "~/obajuStyle/js/modernizr.js",
                      "~/obajuStyle/js/bootstrap-hover-dropdown.js",
                      "~/obajuStyle/js/owl.carousel.min.js",
                      "~/obajuStyle/js/front.js"));
            BundleTable.EnableOptimizations = true;
        }
    }
}
