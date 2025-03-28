namespace Ticketing.Domain.SeedWork;

public interface IRepository<TAggregate> where TAggregate : AggregateRoot
{
    public Task<List<TAggregate>> GetAll(CancellationToken cancellationToken); 
    public Task<TAggregate?> Get(Guid id, CancellationToken cancellationToken);
    public Task Insert(TAggregate aggregate, CancellationToken cancellationToken);
    public Task Delete(TAggregate aggregate, CancellationToken cancellationToken);
    public Task Update(TAggregate aggregate, CancellationToken cancellationToken);
}