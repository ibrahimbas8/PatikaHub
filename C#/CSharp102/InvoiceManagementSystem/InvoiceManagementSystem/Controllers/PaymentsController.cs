using InvoiceManagementSystem.Data;
using InvoiceManagementSystem.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using InvoicePaySystemApi.Services;

namespace InvoiceManagementSystem.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly InvoiceManagementSystemContext _context;
        private readonly IBraintreeService _braintreeService;

        public PaymentsController(InvoiceManagementSystemContext context, IBraintreeService braintreeService)
        {
            _context = context;
            _braintreeService = braintreeService;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreatePaymentVM createPaymentVM)
        {
            var gateway = _braintreeService.GetGateway();
            var clientToken = gateway.ClientToken.Generate();  //Genarate a token
            ViewBag.ClientToken = clientToken;
            var data = _context.Dues.Where(x => x.UserID ==)
            return View();
        }
    }
}
