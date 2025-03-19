namespace Ticketing.Domain.SeedWork;

public class AssertionConcern
{
    public static void AssertArgumentNotNull(object object1, string message)
    {
        if (object1 is null)
            throw new InvalidOperationException(message);
    }
    
    public static void AssertArgumentNotEmpty(string object1, string message)
    {
        if (string.IsNullOrWhiteSpace(object1))
            throw new InvalidOperationException(message);
    }
}