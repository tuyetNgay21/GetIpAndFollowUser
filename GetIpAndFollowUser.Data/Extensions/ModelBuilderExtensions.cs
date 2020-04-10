using GetIpAndFollowUser.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetIpAndFollowUser.Data.Extensions
{
    //khai báo dùng chung khi khởi tạo
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocationUser>().HasData(
                                              new LocationUser()
                                              {
                                                  Id = 1,
                                                  IpClient = "100,100",
                                                  Locations = "",
                                                  DateCreate = DateTime.Now,
                                                  DateEnd = 60,

                                              }
            );
            modelBuilder.Entity<LocationDetail>().HasData(
                                                new LocationDetail()
                                                {
                                                    Id = 1,
                                                    Country = "VietNam",
                                                    Province = "ThaiBinh",
                                                    District = "HungHa",
                                                    SmallAddress = "TanLe",
                                                    IdLocationUser = 1
                                                }
           );
            modelBuilder.Entity<FollowWorkingPage>().HasData(
                                                   new FollowWorkingPage()
                                                   {
                                                       Id = 1,
                                                       LinkPage = "VietNam",
                                                       ViewCount = 0,
                                                       Duration = 0,
                                                       IdPageUser = 1

                                                   }
          );
        }
    }
}
