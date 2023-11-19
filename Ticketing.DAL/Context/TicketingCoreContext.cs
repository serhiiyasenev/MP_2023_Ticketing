using Microsoft.EntityFrameworkCore;
using Ticketing.DAL.Context.EntityConfigurations;
using Ticketing.DAL.Entities;

namespace Ticketing.DAL.Context;

public class TicketingCoreContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Venue> Venues { get; set; }
    public DbSet<Manifest> Manifests { get; set; }
    public DbSet<Seat> Seats { get; set; }
    public DbSet<Offer> Offers { get; set; }
    public DbSet<Price> Prices { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<EventManager> EventManagers { get; set; }

    public TicketingCoreContext(DbContextOptions<TicketingCoreContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Specify the connection string here
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TicketingDb;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfig).Assembly);
    }
}
