using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace imdb_top.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Content/vendor/jquery/jquery.min.js",
                        "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js",
                        "~/Content/vendor/jquery-easing/jquery.easing.min.js",
                        "~/Content/js/grayscale.min.js",
                        "~/Content/datatables/datatables/jquery.datatables.js",
                        "~/Content/datatables/datatables/datatables.bootstrap.js",
                        "~/Content/datatables/datatables/moment.js"
                        )) ;

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/vendor/bootstrap/css/bootstrap.min.css",                      
                      "~/Content/vendor/fontawesome-free/css/all.min.css",                      
                      "~/Content/datatables/css/datatables.bootstrap.css",
                      "~/Content/css/grayscale.css"
                      ));

        }
    }
}