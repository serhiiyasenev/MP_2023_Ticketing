using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ticketing.DAL.Entities;

namespace Ticketing.DAL.Context.EntityConfigurations;

public sealed class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasAlternateKey(x => x.Email);
        builder.HasIndex(x => x.Email).IsUnique();
        builder.HasIndex(x => x.Username).IsUnique();
        builder.Property(x => x.Username).IsRequired().HasMaxLength(25);
        builder.Property(x => x.FirstName).IsRequired().HasMaxLength(25);
        builder.Property(x => x.LastName).IsRequired().HasMaxLength(25);
        builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
        builder.Property(x => x.PasswordHash).HasMaxLength(100);
        builder.Property(x => x.Salt).HasMaxLength(100);

        builder.HasMany(x => x.Tickets)
              .WithOne(x => x.Customer)
              .IsRequired()
              .OnDelete(DeleteBehavior.NoAction);
    }
}