using System.Web;
using System.Web.Mvc;

namespace WebAPI_ASP.NET_v2._10._20
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
