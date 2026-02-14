using Xunit;

public class PaymentIntegrationTests
{
    [Fact]
    public void HappyPathPaymentFlow()
    {
        var db = new PaymentDbContext(new DbContextOptionsBuilder<PaymentDbContext>()
            .UseInMemoryDatabase("PaymentTestDb").Options);

        var service = new PaymentService(db);

        // Start Payment
        var payment = service.StartPayment(Guid.NewGuid());

        // Confirm Payment
        service.ConfirmPayment(payment.Id);

        Assert.Equal("Confirmed", payment.Status);
    }
}
