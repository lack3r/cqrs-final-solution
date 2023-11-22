using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebFrontend.ActionFilters
{
    public class IncludeLayoutDataAttribute : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            if (filterContext.Result is ViewResult viewResult)
            {
                // Set data into ViewData
                viewResult.ViewData["WaitStaff"] = StaticData.WaitStaff;
                viewResult.ViewData["ActiveTables"] = Domain.OpenTabQueries.ActiveTableNumbers();
            }

            /*if (filterContext.Result is ViewResult)
            {
                var bag = (filterContext.Result as ViewResult).ViewBag;
                bag.WaitStaff = StaticData.WaitStaff;
                bag.ActiveTables = Domain.OpenTabQueries.ActiveTableNumbers();
            }*/
        }
    }
}