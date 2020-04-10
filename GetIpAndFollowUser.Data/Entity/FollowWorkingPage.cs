using System;
using System.Collections.Generic;
using System.Text;

namespace GetIpAndFollowUser.Data.Entity
{
    public class FollowWorkingPage
    {
        public int Id { get; set; }
        public string LinkPage { get; set; }
        public int? ViewCount { get; set; }
        public int? Duration { get; set; }
        public int? IdPageUser { get; set; }

        public virtual LocationUser IdPageUserNavigation { get; set; }
    }
}
