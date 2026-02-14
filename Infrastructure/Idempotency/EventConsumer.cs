public class EventConsumer
{
    private readonly DbContext _db;

    public async Task HandleEvent(string eventId, string payload)
    {
        if (_db.Set<ProcessedEvent>().Any(e => e.Id == eventId))
            return; // Skip duplicate

        _db.Set<ProcessedEvent>().Add(new ProcessedEvent { Id = eventId, ProcessedAt = DateTime.UtcNow });
        await _db.SaveChangesAsync();
    }
}
