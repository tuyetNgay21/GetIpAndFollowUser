using System;
using System.Collections.Generic;
using System.Text;

namespace GetIpAndFollowUser.Data.Entity
{
    public class FollowWorkingPage
    {
        public int id { get; protected set; }
        public string LinkPage { get; protected set; }
        public int ViewCount { get; protected set; }
        public int Duration { get; protected set; }
        public int IdPageUser { get; protected set; }
    }
}
