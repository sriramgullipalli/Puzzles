using System.Web;
using System.Web.Mvc;

namespace SampleForHandsOnExp_MVC_WebAppWithEntity
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
