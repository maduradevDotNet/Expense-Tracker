using Microsoft.AspNetCore.Mvc;

namespace Expense_Tracker.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
