public interface IPaymentService
{
    Payment StartPayment(Guid transactionId);
    void ConfirmPayment(Guid paymentId);
    void FailPayment(Guid paymentId);
}
