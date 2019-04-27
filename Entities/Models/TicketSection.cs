using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class TicketSection
    {
        public TicketSection()
        {
            Ticket = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Sms { get; set; }
        public bool Active { get; set; }

        public ICollection<Ticket> Ticket { get; set; }
    }
}
