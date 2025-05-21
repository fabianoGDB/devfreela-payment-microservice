namespace DevFreela.Payments.Api.Models
{
    public class PaymentApprovedIntegrationEvent
    {
        public int Id { get; set; }

        public PaymentApprovedIntegrationEvent(int idProject)
        {
            Id = idProject;
        }
    }
}
