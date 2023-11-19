using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ticketing.DAL.Context;

namespace Ticketing.DAL.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddTicketingCoreContext(this IServiceCollection services, IConfiguration configuration)
    {
        var ticketingCoreDbConnectionString = "TicketingDBConnection";
        var connectionsString = configuration.GetConnectionString(ticketingCoreDbConnectionString);
        services.AddDbContext<TicketingCoreContext>(options =>
            options.UseSqlServer(
                connectionsString,
                opt => opt.MigrationsAssembly(typeof(TicketingCoreContext).Assembly.GetName().Name)));
    }
}
