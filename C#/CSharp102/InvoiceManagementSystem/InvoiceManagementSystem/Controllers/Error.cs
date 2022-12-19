using Microsoft.AspNetCore.Mvc;

namespace InvoiceManagementSystem.Controllers
{
    public class Error : Controller
    {
        public IActionResult Index(int code)
        {
            return View();
        }
    }
}
