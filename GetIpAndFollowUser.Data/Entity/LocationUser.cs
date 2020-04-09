using System;
using System.Collections.Generic;
using System.Text;

namespace GetIpAndFollowUser.Data.Entity
{
    public class LocationUser
    {
        public int Id { get; protected set; }
        public string IpClient { get; protected set; }
        public string Location { get; protected set; }
        public DateTime DateCreate { get; protected set; }
        public int DateEnd { get; protected set; }
    }
}
