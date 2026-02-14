using Xunit;

public class PaymentDomainTests
{
    [Fact]
    public void PaymentCanBeConfirmed()
    {
        var payment = new Payment { TransactionId = Guid.NewGuid() };
        payment.Confirm();
        Assert.Equal("Confirmed", payment.Status);
    }

    [Fact]
    public void PaymentCanFail()
    {
        var payment = new Payment { TransactionId = Guid.NewGuid() };
        payment.Fail();
        Assert.Equal("Failed", payment.Status);
    }
}
