public class Payment
{
    public Guid Id { get; private set; }
    public Guid TransactionId { get; private set; }
    public string Status { get; private set; } = "Started";
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

    public void Confirm()
    {
        Status = "Confirmed";
        DomainEvents.Raise(new PaymentConfirmed(Id));
    }

    public void Fail()
    {
        Status = "Failed";
        DomainEvents.Raise(new PaymentFailed(Id));
    }
}
