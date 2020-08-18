using ClassWork7.Infrastructure.Filters;
using System.Web;
using System.Web.Mvc;

namespace ClassWork7
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomActionFilter());
        }
    }
}
