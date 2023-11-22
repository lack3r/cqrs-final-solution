using Cafe.Tab;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using WebFrontend.ActionFilters;

namespace WebFrontend.Controllers
{
    [IncludeLayoutData]
    public partial class ChefController : Controller
    {
        public ActionResult Index()
        {
            return View(Domain.ChefTodoListQueries.GetTodoList());
        }

        public ActionResult MarkPrepared(Guid id, IFormCollection form)
        {
            Domain.Dispatcher.SendCommand(new MarkFoodPrepared
            {
                Id = id,
                MenuNumbers = (from entry in form.Keys.Cast<string>()
                               where form[entry] != "false"
                               let m = MyRegex().Match(entry)
                               where m.Success
                               select int.Parse(m.Groups[1].Value)
                              ).ToList()
            });

            return RedirectToAction("Index");
        }

        [GeneratedRegex(@"prepared_\d+_(\d+)")]
        private static partial Regex MyRegex();
    }
}
