using System.Web;
using System.Web.Mvc;

namespace MVC_Tercer_Dia_Lab1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}