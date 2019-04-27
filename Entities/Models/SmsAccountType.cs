using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class SmsAccountType
    {
        public SmsAccountType()
        {
            SmsAccount = new HashSet<SmsAccount>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<SmsAccount> SmsAccount { get; set; }
    }
}
