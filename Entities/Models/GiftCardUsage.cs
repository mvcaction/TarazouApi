using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class GiftCardUsage
    {
        public int Id { get; set; }
        public int GiftCardId { get; set; }
        public int OrderId { get; set; }
        public int UsedValue { get; set; }
        public bool IsTemp { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }

        public GiftCard GiftCard { get; set; }
        public Order Order { get; set; }
    }
}
