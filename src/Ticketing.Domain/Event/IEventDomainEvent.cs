using Ticketing.Domain.SeedWork;

namespace Ticketing.Domain.Event;

public interface IEventDomainEvent : IDomainEvent
{
    const string EventType = "Event";

    string EventId();

    string IDomainEvent.AggregateId()
        => EventId();

    string IDomainEvent.AggregateType()
        => EventType;
}