using Xunit;
using Microsoft.EntityFrameworkCore;

public class TransactionIntegrationTests
{
    [Fact]
    public void HappyPathTransactionFlow()
    {
        var db = new TransactionDbContext(new DbContextOptionsBuilder<TransactionDbContext>()
            .UseInMemoryDatabase("TestDb").Options);

        var service = new TransactionService(db);

        // Create Transaction
        var tx = service.CreateTransaction(Guid.NewGuid());
        service.AddItem(tx.Id, "Item1", 100);

        // Submit Transaction
        service.SubmitTransaction(tx.Id);

        Assert.Equal("Submitted", tx.Status);
    }
}
