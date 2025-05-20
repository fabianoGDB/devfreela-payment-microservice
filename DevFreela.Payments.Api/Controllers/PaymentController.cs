using DevFreela.Payments.Api.Models.Inputs;
using DevFreela.Payments.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DevFreela.Payments.Api.Controllers
{
    [Route("api/payment")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]PaymentInfoInputModel paymentInfo)
        {
            var result = await _paymentService.Process(paymentInfo);

            if (!result)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}
