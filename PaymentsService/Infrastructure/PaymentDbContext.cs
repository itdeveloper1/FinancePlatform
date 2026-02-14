public class PaymentDbContext : DbContext
{
    public DbSet<Payment> Payments { get; set; }
    public DbSet<OutboxMessage> OutboxMessages { get; set; }

    public PaymentDbContext(DbContextOptions<PaymentDbContext> options) : base(options) { }
}
