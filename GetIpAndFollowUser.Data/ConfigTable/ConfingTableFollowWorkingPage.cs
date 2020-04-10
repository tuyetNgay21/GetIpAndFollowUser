using GetIpAndFollowUser.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetIpAndFollowUser.Data.ConfigTable
{
   public class ConfingTableFollowWorkingPage : IEntityTypeConfiguration<FollowWorkingPage>
    {
        public void Configure(EntityTypeBuilder<FollowWorkingPage> builder)
        {
            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Duration).HasDefaultValueSql("((0))");

            builder.Property(e => e.LinkPage)
                .HasMaxLength(300)
                .IsUnicode(false);

            builder.Property(e => e.ViewCount).HasDefaultValueSql("((1))");

            builder.HasOne(d => d.IdPageUserNavigation)
                .WithMany(p => p.FollowWorkingPage)
                .HasForeignKey(d => d.IdPageUser)
                .HasConstraintName("FK__FollowWor__IdPag__208CD6FA");
        }
    }
}
