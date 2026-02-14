using Xunit;

public class TransactionDomainTests
{
    [Fact]
    public void CannotSubmitEmptyTransaction()
    {
        var tx = new Transaction();
        Assert.Throws<InvalidOperationException>(() => tx.Submit());
    }

    [Fact]
    public void CannotCancelConfirmedTransactionByClient()
    {
        var tx = new Transaction();
        tx.AddItem("Item1", 100);
        tx.Submit();
        tx.Status = "Confirmed";

        Assert.Throws<InvalidOperationException>(() => tx.Cancel(false));
    }

    [Fact]
    public void MerchantCanCancelConfirmedTransaction()
    {
        var tx = new Transaction();
        tx.AddItem("Item1", 100);
        tx.Submit();
        tx.Status = "Confirmed";

        tx.Cancel(true);
        Assert.Equal("Cancelled", tx.Status);
    }
}
