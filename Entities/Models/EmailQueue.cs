using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class EmailQueue
    {
        public int Id { get; set; }
        public int? EmailAccountId { get; set; }
        public bool IsQueue { get; set; }
        public int? ReceiverUserId { get; set; }
        public int EmailStatusId { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public int EmailPriorityId { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public EmailAccount EmailAccount { get; set; }
        public EmailPriority EmailPriority { get; set; }
        public EmailStatus EmailStatus { get; set; }
        public User ReceiverUser { get; set; }
    }
}
