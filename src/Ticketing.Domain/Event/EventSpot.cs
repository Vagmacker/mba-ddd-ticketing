using Ticketing.Domain.SeedWork;

namespace Ticketing.Domain.Event;

public class EventSpot(string? aLocation, bool isReserved, bool isPublished) : Entity
{
    public string? Location { get; private set; } = aLocation;
    public bool IsReserved { get; private set; } = isReserved;
    public bool IsPublished { get; private set; } = isPublished;

    public static EventSpot NewEventSpot()
        => new EventSpot(null, false, false);

    public void MarkAsReserved()
        => IsReserved = true;

    public void Publish()
        => IsPublished = true;
}