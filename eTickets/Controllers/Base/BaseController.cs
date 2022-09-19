using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers.Base
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
