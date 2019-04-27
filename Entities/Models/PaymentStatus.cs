using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class PaymentStatus
    {
        public PaymentStatus()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Order> Order { get; set; }
    }
}
