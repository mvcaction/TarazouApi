using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class EmailPriority
    {
        public EmailPriority()
        {
            EmailQueue = new HashSet<EmailQueue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<EmailQueue> EmailQueue { get; set; }
    }
}
