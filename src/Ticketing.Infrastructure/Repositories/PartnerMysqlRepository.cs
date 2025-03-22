using Ticketing.Domain.Partner;
using Microsoft.EntityFrameworkCore;

namespace Ticketing.Infrastructure.Repositories;

public class PartnerMysqlRepository(TicketingDbContext context) : IPartnerRepository
{
    private DbSet<Partner> Partners => context.Partners;

    public async Task<List<Partner>> GetAll(CancellationToken cancellationToken)
    {
        return await Partners
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<Partner?> Get(Guid id, CancellationToken cancellationToken)
    {
        return await Partners
            .AsNoTracking()
            .FirstOrDefaultAsync(partner => partner.Id == id, cancellationToken);
    }

    public async Task Insert(Partner aggregate, CancellationToken cancellationToken)
        => await Partners.AddAsync(aggregate, cancellationToken);

    public Task Delete(Partner aggregate, CancellationToken cancellationToken)
        => Task.FromResult(Partners.Remove(aggregate));

    public Task Update(Partner aggregate, CancellationToken cancellationToken)
        => Task.FromResult(Partners.Update(aggregate));
}