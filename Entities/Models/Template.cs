using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class Template
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int TemplateTypeId { get; set; }
        public string Tokens { get; set; }
        public bool Active { get; set; }
        public bool IsQueued { get; set; }
        public int? EmailAccountId { get; set; }
        public int? SmsAccountId { get; set; }
        public bool IsFlash { get; set; }
        public bool IsFlashSupport { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public User CreatedByNavigation { get; set; }
        public EmailAccount EmailAccount { get; set; }
        public User ModifiedByNavigation { get; set; }
        public SmsAccount SmsAccount { get; set; }
        public TemplateType TemplateType { get; set; }
    }
}
