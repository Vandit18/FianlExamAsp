using System.Web;
using System.Web.Mvc;

namespace VanditKothari_FinalExam1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
