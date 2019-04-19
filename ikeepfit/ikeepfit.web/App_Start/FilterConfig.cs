using System.Web;
using System.Web.Mvc;
using ikeepfit.WebCore;

namespace ikeepfit.web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ExpFilter());
        }
    }
}
