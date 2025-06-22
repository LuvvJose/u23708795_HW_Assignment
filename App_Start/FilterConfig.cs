using System.Web;
using System.Web.Mvc;

namespace u23708795_HW_Assignment
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
