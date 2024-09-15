using AzureBoard.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AzureBoard.Infrastructure.Configurations;

public class WorkItemEntityTypeConfiguration : IEntityTypeConfiguration<WorkItem>
{
    public void Configure(EntityTypeBuilder<WorkItem> builder)
    {
        builder.ToTable("WorkItems");

        builder.HasKey(wi => wi.Id);

        builder.Property(wi => wi.State).IsRequired(true);

        builder.Property(wi => wi.Area).HasColumnType("nvarchar(200)").IsRequired(true);

        builder.Property(wi => wi.IterationPath).HasColumnName("Iteration_Path").IsRequired(true);

        builder.Property(x => x.Effort).HasColumnType("decimal(5,2)");

        builder.Property(x => x.EndDate).HasPrecision(3);

        builder.Property(x => x.Activity).HasMaxLength(200);

        builder.Property(x => x.RemainingWork).HasPrecision(14, 2);

        builder.Property(x => x.Priority).HasDefaultValue(1);

        builder.HasMany(x => x.Comments)
            .WithOne(x => x.WorkItem)
            .HasForeignKey(x => x.WorkItemId);

        builder.HasOne(x => x.Author)
            .WithMany(x => x.WorkItems)
            .HasForeignKey(x => x.AuthorId);
    }
}