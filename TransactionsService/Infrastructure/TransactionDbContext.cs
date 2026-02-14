public class TransactionDbContext : DbContext
{
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<TransactionItem> TransactionItems { get; set; }
    public DbSet<OutboxMessage> OutboxMessages { get; set; }

    public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options) { }
}
