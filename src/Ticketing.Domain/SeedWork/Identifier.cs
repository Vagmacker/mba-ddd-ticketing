namespace Ticketing.Domain.SeedWork;

public abstract class Identifier<T>(T value) : ValueObject
{
    public T Value { get; } = value;
}