using AzureBoard.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AzureBoard.Infrastructure.Configurations;

public class WorkItemStateEntityTypeConfiguration : IEntityTypeConfiguration<WorkItemState>
{
    public void Configure(EntityTypeBuilder<WorkItemState> builder)
    {
        builder.ToTable("WorkItemStates");

        builder.HasKey(wis => wis.Id);

        builder.Property(wis => wis.Value).HasMaxLength(50).IsRequired(true);
    }
}