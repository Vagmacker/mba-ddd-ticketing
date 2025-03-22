using Ticketing.Domain.Partner;
using Microsoft.EntityFrameworkCore;
using Ticketing.Infrastructure.Configurations;

namespace Ticketing.Infrastructure;

public class TicketingDbContext(DbContextOptions<TicketingDbContext> options) : DbContext(options)
{
    public DbSet<Partner> Partners => Set<Partner>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PartnerConfiguration());
    }
}