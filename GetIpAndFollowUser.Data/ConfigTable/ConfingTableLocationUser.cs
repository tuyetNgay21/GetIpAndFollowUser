using GetIpAndFollowUser.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetIpAndFollowUser.Data.ConfigTable
{
   public  class ConfingTableLocationUser : IEntityTypeConfiguration<LocationUser>
    {
        public void Configure(EntityTypeBuilder<LocationUser> builder)
        {
            builder.Property(e => e.DateCreate)
                     .HasColumnType("date")
                     .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.DateEnd).HasDefaultValueSql("((60))");

            builder.Property(e => e.IpClient)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Locations)
                .HasMaxLength(200)
                .IsUnicode(false);
        }
    }
}
