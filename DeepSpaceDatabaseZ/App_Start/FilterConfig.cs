using System.Web;
using System.Web.Mvc;

namespace DeepSpaceDatabaseZ
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
