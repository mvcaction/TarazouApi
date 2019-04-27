using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class SmsQueue
    {
        public int Id { get; set; }
        public int? SmsAccountId { get; set; }
        public bool IsQueue { get; set; }
        public int? ReceiverUserId { get; set; }
        public int SmsStatusId { get; set; }
        public string Mobile { get; set; }
        public string Text { get; set; }
        public int SmsPriorityId { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public User CreatedByNavigation { get; set; }
        public User ModifiedByNavigation { get; set; }
        public SmsPriority SmsPriority { get; set; }
    }
}
