using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ticketing.DAL.Context;

namespace Ticketing.DAL.Extensions;

public static class ApplicationBuilderExtensions
{
    public static void UseTicketingCoreContext(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
        using var context = scope?.ServiceProvider.GetRequiredService<TicketingCoreContext>();
        context?.Database.Migrate();
    }
}