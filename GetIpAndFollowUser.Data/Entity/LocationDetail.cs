using System;
using System.Collections.Generic;
using System.Text;

namespace GetIpAndFollowUser.Data.Entity
{
    public class LocationDetail
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string SmallAddress { get; set; }
        public int? IdLocationUser { get; set; }

        public virtual LocationUser IdLocationUserNavigation { get; set; }
    }
}
