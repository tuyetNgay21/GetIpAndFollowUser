using GetIpAndFollowUser.Data.Entity;
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
        
        public DbSet<FollowWorkingPage> FollowWorkingPages { get; protected set; }
        public DbSet<LocationDetail> LocationDetails { get; protected set; }
        public DbSet<LocationUser> LocationUsers  { get; protected set; }
    }
}
