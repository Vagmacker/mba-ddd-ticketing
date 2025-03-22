using System.Collections.ObjectModel;

namespace Ticketing.Domain.SeedWork;

public abstract class AggregateRoot : Entity
{
    private readonly List<IDomainEvent> _events = [];
    public IReadOnlyCollection<IDomainEvent> Events
        => new ReadOnlyCollection<IDomainEvent>(_events);

    protected void RaiseEvent(IDomainEvent @event) => _events.Add(@event);
    protected void ClearEvents() => _events.Clear();
}