using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class Ticket
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int TicketSectionId { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
        public int? TicketStatusId { get; set; }
        public DateTime CreateTime { get; set; }

        public TicketSection TicketSection { get; set; }
        public TicketStatus TicketStatus { get; set; }
    }
}
