using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class SmsPriority
    {
        public SmsPriority()
        {
            SmsQueue = new HashSet<SmsQueue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<SmsQueue> SmsQueue { get; set; }
    }
}
