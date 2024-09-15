using AzureBoard.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AzureBoard.Infrastructure.Configurations;

public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.FirstName).HasMaxLength(100).IsRequired(true);

        builder.Property(u => u.LastName).HasMaxLength(100).IsRequired(true);

        builder.Property(u => u.Email).HasMaxLength(100).IsRequired(true);

        builder.HasOne(u => u.Address)
            .WithOne(a => a.User)
            .HasForeignKey<Address>(a => a.UserId);
    }
}