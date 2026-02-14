public class TransactionService : ITransactionService
{
    private readonly TransactionDbContext _db;

    public TransactionService(TransactionDbContext db)
    {
        _db = db;
    }

    public Transaction CreateTransaction(Guid merchantId)
    {
        var tx = new Transaction();
        _db.Transactions.Add(tx);
        _db.SaveChanges();
        return tx;
    }

    public void AddItem(Guid transactionId, string description, decimal amount)
    {
        var tx = _db.Transactions.Find(transactionId);
        tx.AddItem(description, amount);
        _db.SaveChanges();
    }

    public void SubmitTransaction(Guid transactionId)
    {
        var tx = _db.Transactions.Find(transactionId);
        tx.Submit();
        _db.SaveChanges();
    }

    public void CancelTransaction(Guid transactionId, bool isMerchant)
    {
        var tx = _db.Transactions.Find(transactionId);
        tx.Cancel(isMerchant);
        _db.SaveChanges();
    }
}
