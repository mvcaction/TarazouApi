using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class TicketStatus
    {
        public TicketStatus()
        {
            Ticket = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Ticket> Ticket { get; set; }
    }
}
