using System.Web;
using System.Web.Mvc;

namespace Justice_Ngwenya_Project_API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
