using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }

        public IActionResult Login()
        {
            return View("Login");
        }
    }
}
