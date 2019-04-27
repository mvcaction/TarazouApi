using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            Order = new HashSet<Order>();
            OrderConsultant = new HashSet<OrderConsultant>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Order> Order { get; set; }
        public ICollection<OrderConsultant> OrderConsultant { get; set; }
    }
}
