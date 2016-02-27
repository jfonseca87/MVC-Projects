using System.Web;
using System.Web.Mvc;

namespace MvcQuintoDia_Lab2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}