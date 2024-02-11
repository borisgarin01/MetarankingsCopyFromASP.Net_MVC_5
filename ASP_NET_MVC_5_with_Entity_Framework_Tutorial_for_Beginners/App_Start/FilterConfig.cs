using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_5_with_Entity_Framework_Tutorial_for_Beginners
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
