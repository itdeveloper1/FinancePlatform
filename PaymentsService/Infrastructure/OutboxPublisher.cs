public class OutboxPublisher
{
    private readonly PaymentDbContext _db;
    private readonly IEventBus _bus;

    public OutboxPublisher(PaymentDbContext db, IEventBus bus)
    {
        _db = db;
        _bus = bus;
    }

    public async Task PublishPendingEvents()
    {
        var messages = _db.OutboxMessages.Where(m => !m.Processed).ToList();
        foreach (var msg in messages)
        {
            await _bus.Publish(msg.EventType, msg.Payload);
            msg.Processed = true;
        }
        await _db.SaveChangesAsync();
    }
}
