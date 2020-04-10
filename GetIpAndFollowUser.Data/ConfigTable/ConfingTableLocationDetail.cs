using GetIpAndFollowUser.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetIpAndFollowUser.Data.ConfigTable
{
    public class ConfingTableLocationDetail : IEntityTypeConfiguration<LocationDetail>
    {
        public void Configure(EntityTypeBuilder<LocationDetail> builder)
        {
            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Country)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.District)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Province)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.SmallAddress).HasMaxLength(100);

            builder.HasOne(d => d.IdLocationUserNavigation)
                .WithMany(p => p.LocationDetail)
                .HasForeignKey(d => d.IdLocationUser)
                .HasConstraintName("FK__LocationD__IdLoc__1AD3FDA4");
        }
    }
}
