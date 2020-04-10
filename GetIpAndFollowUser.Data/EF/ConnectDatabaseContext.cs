using GetIpAndFollowUser.Data.ConfigTable;
using GetIpAndFollowUser.Data.Entity;
using GetIpAndFollowUser.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetIpAndFollowUser.Data.EF
{
    public class ConnectDatabaseContext : DbContext
    {
        public ConnectDatabaseContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //API fluent Create Database
            modelBuilder.ApplyConfiguration(new ConfingTableLocationUser());
            modelBuilder.ApplyConfiguration(new ConfingTableLocationDetail());
            modelBuilder.ApplyConfiguration(new ConfingTableFollowWorkingPage());

            //Seeding data
            modelBuilder.Seed();


        }
        

        public DbSet<FollowWorkingPage> FollowWorkingPages { get; protected set; }
        public DbSet<LocationDetail> LocationDetails { get; protected set; }
        public DbSet<LocationUser> LocationUsers  { get; protected set; }
    }
}
