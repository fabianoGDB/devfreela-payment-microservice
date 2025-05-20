using DevFreela.Payments.Api.Models.Inputs;
using System.Threading.Tasks;

namespace DevFreela.Payments.Api.Services
{
    public interface IPaymentService
    {
        Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel);
    }
}
