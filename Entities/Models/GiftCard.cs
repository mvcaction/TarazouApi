using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class GiftCard
    {
        public GiftCard()
        {
            GiftCardUsage = new HashSet<GiftCardUsage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Remain { get; set; }
        public int? UserId { get; set; }
        public string Code { get; set; }
        public DateTime CreateTime { get; set; }
        public bool Active { get; set; }

        public User User { get; set; }
        public ICollection<GiftCardUsage> GiftCardUsage { get; set; }
    }
}
