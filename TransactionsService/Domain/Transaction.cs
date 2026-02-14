public class Transaction
{
    public Guid Id { get; private set; }
    public List<TransactionItem> Items { get; private set; } = new();
    public string Status { get; private set; } = "Created";
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

    public void AddItem(string description, decimal amount)
    {
        if (Status != "Created") throw new InvalidOperationException("Cannot add items after submit.");
        Items.Add(new TransactionItem(description, amount));
    }

    public void Submit()
    {
        if (!Items.Any()) throw new InvalidOperationException("Cannot submit empty transaction.");
        Status = "Submitted";
        DomainEvents.Raise(new TransactionSubmitted(Id));
    }

    public void Cancel(bool isMerchant = false)
    {
        if (Status == "Confirmed" && !isMerchant)
            throw new InvalidOperationException("Only merchant can cancel after confirmation.");
        Status = "Cancelled";
        DomainEvents.Raise(new TransactionCancelled(Id));
    }
}

