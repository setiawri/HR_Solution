using System.Web;
using System.Web.Optimization;

namespace HRWebApplication
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
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //bundles.Add(new StyleBundle("~/listCustomer/css").Include(
            //          "~/vendors/iCheck/skins/flat/green.css",
            //          "~/vendors/bootstrap-datetimepicker/build/css/bootstrap-datetimepicker.min.css",
            //          "~/vendors/datatables.net-bs/css/dataTables.bootstrap.min.css",
            //          "~/vendors/datatables.net-buttons-bs/css/buttons.bootstrap.min.css",
            //          "~/vendors/datatables.net-fixedheader-bs/css/fixedHeader.bootstrap.min.css",
            //          "~/vendors/datatables.net-responsive-bs/css/responsive.bootstrap.min.css",
            //          "~/vendors/datatables.net-scroller-bs/css/scroller.bootstrap.min.css"));

            //bundles.Add(new ScriptBundle("~/listCustomer/js").Include(
            //          "~/vendors/iCheck/icheck.min.js",
            //          "~/vendors/bootstrap-datetimepicker/build/js/bootstrap-datetimepicker.min.js",
            //          "~/vendors/datatables.net/js/jquery.dataTables.min.js",
            //          "~/vendors/datatables.net-bs/js/dataTables.bootstrap.min.js",
            //          "~/vendors/datatables.net-buttons/js/dataTables.buttons.min.js",
            //          "~/vendors/datatables.net-buttons-bs/js/buttons.bootstrap.min.js",
            //          "~/vendors/datatables.net-buttons/js/buttons.flash.min.js",
            //          "~/vendors/datatables.net-buttons/js/buttons.html5.min.js",
            //          "~/vendors/datatables.net-buttons/js/buttons.print.min.js",
            //          "~/vendors/datatables.net-fixedheader/js/dataTables.fixedHeader.min.js",
            //          "~/vendors/datatables.net-keytable/js/dataTables.keyTable.min.js",
            //          "~/vendors/datatables.net-responsive/js/dataTables.responsive.min.js",
            //          "~/vendors/datatables.net-responsive-bs/js/responsive.bootstrap.js",
            //          "~/vendors/datatables.net-scroller/js/dataTables.scroller.min.js",
            //          "~/vendors/jszip/dist/jszip.min.js",
            //          "~/vendors/pdfmake/build/pdfmake.min.js",
            //          "~/vendors/pdfmake/build/vfs_fonts.js"));
        }
    }
}
