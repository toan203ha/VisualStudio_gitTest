using System.Web;
using System.Web.Mvc;

namespace buoi01_DAPM_13_9
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
