using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{

    public partial class ActivityLog
    {
        public int Id { get; set; }
        public int ActivityLogTypeId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string IpAddress { get; set; }

        public ActivityLogType ActivityLogType { get; set; }
        public User User { get; set; }
    }
}
