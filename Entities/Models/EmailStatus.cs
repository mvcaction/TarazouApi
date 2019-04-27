using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class EmailStatus
    {
        public EmailStatus()
        {
            EmailQueue = new HashSet<EmailQueue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<EmailQueue> EmailQueue { get; set; }
    }
}
