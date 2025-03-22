using Ticketing.Domain.SeedWork;

namespace Ticketing.Domain.Event;

public class EventSection : Entity
{
    public string Name { get; private set; }
    public string? Description { get; private set; }
    public decimal Price { get; private set; }
    public bool IsPublished { get; private set; }
    public int TotalSpots { get; private set; }
    public int TotalSpotsReserved { get; private set; }

    private List<EventSpot> _spots;
    public IReadOnlyCollection<EventSpot> Spots => _spots.AsReadOnly();

    private const int TotalSpotsReservedInitial = 0;

    public EventSection(
        string aName,
        string? aDescription,
        decimal aPrice,
        bool isPublished,
        int aTotalSpots,
        int aTotalSpotsReserved,
        List<EventSpot> spots
    )
    {
        Name = aName;
        Price = aPrice;
        _spots = spots;
        TotalSpots = aTotalSpots;
        IsPublished = isPublished;
        Description = aDescription;
        TotalSpotsReserved = aTotalSpotsReserved;
    }

    public static EventSection NewEventSection(
        string aName,
        string? aDescription,
        decimal aPrice,
        int aTotalSpots
    )
    {
        var section = new EventSection(
            aName,
            aDescription,
            aPrice,
            false,
            aTotalSpots,
            TotalSpotsReservedInitial,
            []
        );

        section.InitializeSpots();

        return section;
    }

    private void InitializeSpots()
    {
        _spots = [];
        for (var i = 0; i < TotalSpots; i++)
        {
            _spots.Add(EventSpot.NewEventSpot());
        }
    }

    public void Publish()
    {
        IsPublished = true;
    }

    public void UnPublish()
    {
        IsPublished = false;
    }
}