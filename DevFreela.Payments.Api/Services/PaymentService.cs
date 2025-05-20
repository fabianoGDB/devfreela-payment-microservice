using DevFreela.Payments.Api.Models.Inputs;
using System.Threading.Tasks;

namespace DevFreela.Payments.Api.Services
{
    public class PaymentService : IPaymentService
    {
        public async Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel)
        {
            return await Task.FromResult(true);
        }
    }
}
