using System.Web;
using System.Web.Optimization;

namespace WebApplication4
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            /*    bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                            "~/Scripts/jquery-{version}.js"));
    */
            /*     bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                             "~/Scripts/jquery.validate*"));
     */
            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                         "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/js").Include(
                      "~/Scripts/js/jquery.min.js",
                      "~/Scripts/js/bootstrap.min.js",
                      "~/Scripts/js/adminlte.min.js"));
           
            bundles.Add(new StyleBundle("~/css").Include(
                      "~/Content/Compartido/css/bootstrap.min.css",
                      "~/Content/font-awesome/css/font-awesome.min.css",
                      "~/Content/Compartido/css/ionicons.css",
                      "~/Content/Compartido/css/AdminLTE.min.css",
                      "~/Content/Compartido/css/skins/skin-red.css"));
            BundleTable.EnableOptimizations = true;
        }
    }
}
