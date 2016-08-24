using System.Web.Optimization;

namespace HashFruit.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Scripts/angular.min.js",
                      "~/Scripts/myweb/app.js"));

            bundles.Add(new ScriptBundle("~/bundles/templateJS").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/jquery.scrollUp.min.js",
                      "~/Scripts/price-range.js",
                      "~/Scripts/main.js",
                      "~/Scripts/jquery.prettyPhoto.js",
                      "~/Scripts/pace.js",
                      "~/Scripts/bootstrap-notify.min.js",
                      "~/Scripts/myweb/main.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/prettyPhoto.css",
                      "~/Content/price-range.css",
                      "~/Content/animate.css",
                      "~/Content/main.css",
                      "~/Content/responsive.css",
                      "~/Content/pace.css"));
        }
    }
}