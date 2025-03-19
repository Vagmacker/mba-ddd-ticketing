using Ticketing.Domain.SeedWork;

namespace Ticketing.Domain.Partner;

public class Partner : AggregateRoot
{
    public string Name { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public DateTime UpdatedAt { get; private set; }

    /// <summary>
    /// Entity Framework needs this constructor
    /// </summary>
    private Partner()
    {
    }

    private Partner(string aName, DateTime aCreatedAt, DateTime aUpdatedAt)
    {
        Name = aName;
        CreatedAt = aCreatedAt;
        UpdatedAt = aUpdatedAt;
    }

    public static Partner NewPartner(string aName)
    {
        var now = DateTime.UtcNow;
        return new Partner(aName, now, now);
    }
}