using System;
using System.Collections.Generic;
using System.Text;

namespace GetIpAndFollowUser.Data.Entity
{
    public class LocationDetail
    {
        public int id { get; protected set; }
        public string Country { get; protected set; }
        public string Province { get; protected set; }
        public string District { get; protected set; }
        public string SmallAddress { get; protected set; }
        public int IdLocationUser { get; protected set; }
    }
}
