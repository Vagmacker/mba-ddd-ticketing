using Ticketing.Application;

namespace Ticketing.Infrastructure;

public class UnitOfWork(TicketingDbContext context) : IUnitOfWork
{
    public async Task Commit(CancellationToken cancellationToken)
        => await context.SaveChangesAsync(cancellationToken);

    public Task Rollback(CancellationToken cancellationToken)
        => Task.CompletedTask;
}