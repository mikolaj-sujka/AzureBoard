using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzureBoard.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AzureBoard.Infrastructure.Configurations;

public class CommentEntityTypeConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.ToTable("Comments");

        builder.HasKey(c => c.Id);

        builder.Property(x => x.CreatedDate).HasDefaultValueSql("getutcdate()");

        builder.Property(x => x.UpdatedDate).ValueGeneratedOnUpdate();
    }
}