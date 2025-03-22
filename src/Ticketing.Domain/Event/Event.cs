using Ticketing.Domain.SeedWork;

namespace Ticketing.Domain.Event;

public class Event : AggregateRoot
{
    public string Name { get; private set; }
    public string? Description { get; private set; }
    public DateTime Date { get; private set; }
    public bool IsPublished { get; private set; }
    public int TotalSpots { get; private set; }
    public int TotalSpotsReserved { get; private set; }
    public Guid PartnerId { get; private set; }

    private List<EventSection> _sections;
    public IReadOnlyCollection<EventSection> Sections => _sections.AsReadOnly();

    private const int TotalSpotsInitial = 0;
    private const int TotalSpotsReservedInitial = 0;

    public Event(
        string name,
        string? description,
        DateTime date,
        bool isPublished,
        int totalSpots,
        int totalSpotsReserved,
        Guid partnerId
    )
    {
        Name = name;
        Description = description;
        Date = date;
        IsPublished = isPublished;
        TotalSpots = totalSpots;
        TotalSpotsReserved = totalSpotsReserved;
        PartnerId = partnerId;
        _sections = [];
    }

    public static Event NewEvent(
        string name,
        string? description,
        DateTime date,
        string partnerId
    )
    {
        var @event = new Event(
            name,
            description,
            date,
            false,
            TotalSpotsInitial,
            TotalSpotsReservedInitial,
            Guid.Parse(partnerId)
        );
        
        @event.RaiseEvent(new EventCreated(
            @event.Id,
            @event.Name,
            @event.Description,
            @event.Date,
            @event.IsPublished,
            @event.TotalSpots,
            @event.TotalSpotsReserved,
            @event.PartnerId
        ));
        
        return @event;
    }
    
    public void AddSection(
        string name,
        string? description,
        decimal price,
        int totalSpots
    )
    {
        var section = EventSection.NewEventSection(
            name,
            description,
            price,
            totalSpots
        );
        
        _sections.Add(section);
        
        TotalSpots += section.TotalSpots;
    }
}