public class PaymentService : IPaymentService
{
    private readonly PaymentDbContext _db;

    public PaymentService(PaymentDbContext db)
    {
        _db = db;
    }

    public Payment StartPayment(Guid transactionId)
    {
        var payment = new Payment { TransactionId = transactionId };
        _db.Payments.Add(payment);
        _db.SaveChanges();
        return payment;
    }

    public void ConfirmPayment(Guid paymentId)
    {
        var payment = _db.Payments.Find(paymentId);
        payment.Confirm();
        _db.SaveChanges();
    }

    public void FailPayment(Guid paymentId)
    {
        var payment = _db.Payments.Find(paymentId);
        payment.Fail();
        _db.SaveChanges();
    }
}
