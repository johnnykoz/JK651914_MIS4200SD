using System.Web;
using System.Web.Mvc;

namespace JK651914_MIS4200SD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
