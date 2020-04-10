using System;
using System.Collections.Generic;
using System.Text;

namespace GetIpAndFollowUser.Data.Entity
{
    public class LocationUser
    {
        public LocationUser()
        {
            FollowWorkingPage = new HashSet<FollowWorkingPage>();
            LocationDetail = new HashSet<LocationDetail>();
        }

        public int Id { get; set; }
        public string IpClient { get; set; }
        public string Locations { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? DateEnd { get; set; }

        public virtual ICollection<FollowWorkingPage> FollowWorkingPage { get; set; }
        public virtual ICollection<LocationDetail> LocationDetail { get; set; }
    }
}
