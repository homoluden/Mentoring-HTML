using System.Web;
using System.Web.Optimization;

namespace HTMLProxy
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            // AngularJS
            bundles.Add(new ScriptBundle("~/bundles/ng-base").Include(
                        "~/Scripts/angular.js",
                        "~/Scripts/angular-bootstrap.js",
                        "~/Scripts/angular-cookies.js",
                        "~/Scripts/angular-loader.js",
                        "~/Scripts/angular-resource.js",
                        "~/Scripts/ui-bootstrap-0.6.0.js",
                        "~/Scripts/ui-bootstrap-tpls-0.6.0.js"));
            bundles.Add(new ScriptBundle("~/bundles/ng-app").Include(
                        "~/Scripts/ng-app/app.js",
                        "~/Scripts/ng-app/IndexCtrl.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/ui/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css",
                        "~/Content/bootstrap/bootstrap.css",
                        "~/Content/bootstrap/bootstrap-theme.css"));
        }
    }
}