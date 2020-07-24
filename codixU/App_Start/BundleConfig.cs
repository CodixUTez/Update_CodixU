using System.Web;
using System.Web.Optimization;

namespace codixU
{
    public class BundleConfig
    {
        // Paketleme hakkında daha fazla bilgi için lütfen https://go.microsoft.com/fwlink/?LinkId=301862 adresini ziyaret edin
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Geliştirme yapmak ve öğrenmek için Modernizr'ın geliştirme sürümünü kullanın. Daha sonra,
            // üretim için hazır. https://modernizr.com adresinde derleme aracını kullanarak yalnızca ihtiyacınız olan testleri seçin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/Js").Include(
                "~/AdminContent/plugin/jquery/jquery.min.js",
                "~/AdminContent/plugins/bootstrap/js/bootstrap.bundle.min.js",
                "~/AdminContent/dist/js/adminlte.min.js",
                "~/AdminContent/dist/js/demo.js"));
            bundles.Add(new StyleBundle("~/Css").Include(
                "~/AdminContent/bootstrap/css/bootstrap.min.css",
                "~/AdminContent/dist/css/adminlte.min.css"));
            BundleTable.EnableOptimizations = true; bundles.Add(new ScriptBundle("~/Js").Include(
                "~/AdminContent/plugin/jquery/jquery.min.js",
                "~/AdminContent/plugins/bootstrap/js/bootstrap.bundle.min.js",
                "~/AdminContent/dist/js/adminlte.min.js",
                "~/AdminContent/dist/js/demo.js"));
            bundles.Add(new StyleBundle("~/Css").Include(
                "~/AdminContent/bootstrap/css/bootstrap.min.css",
                "~/AdminContent/dist/css/adminlte.min.css"));
            BundleTable.EnableOptimizations = true;
        }
    }
}
