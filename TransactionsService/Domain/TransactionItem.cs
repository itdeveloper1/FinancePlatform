public class TransactionItem
{
    public Guid Id { get; private set; }
    public string Description { get; private set; }
    public decimal Amount { get; private set; }

    public TransactionItem(string description, decimal amount)
    {
        Id = Guid.NewGuid();
        Description = description;
        Amount = amount;
    }
}

