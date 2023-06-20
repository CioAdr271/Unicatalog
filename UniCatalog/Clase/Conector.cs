using System.Configuration;

namespace UniCatalog.Clase
{
    public static class Conector
    {
        public static string ConSir()
        {
            return ConfigurationManager.ConnectionStrings["UniCatalogDb"].ConnectionString;
        }
    }
}
