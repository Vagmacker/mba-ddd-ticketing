namespace Ticketing.Domain.SeedWork;

public interface IDomainEvent
{
    DateTime OccurredOn();
    string AggregateId();
    string AggregateType();
}