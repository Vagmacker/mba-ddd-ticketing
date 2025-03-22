namespace Ticketing.Domain.Event;

public sealed class EventCreated(
    Guid eventId,
    string name,
    string? description,
    DateTime date,
    bool isPublished,
    int totalSpots,
    int totalSpotsReserved,
    Guid partnerId
) : IEventDomainEvent
{
    public DateTime OccurredOn()
        => DateTime.UtcNow;

    public string EventId()
        => eventId.ToString();
}