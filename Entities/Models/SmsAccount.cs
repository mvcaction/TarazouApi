using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class SmsAccount
    {
        public SmsAccount()
        {
            Template = new HashSet<Template>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Tel { get; set; }
        public string Api { get; set; }
        public int SmsAccountTypeId { get; set; }
        public long? Active { get; set; }

        public SmsAccountType SmsAccountType { get; set; }
        public ICollection<Template> Template { get; set; }
    }
}
