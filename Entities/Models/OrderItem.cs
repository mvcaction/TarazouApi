using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public Guid OrderItemGuid { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }

        public Order Order { get; set; }
        public Question Product { get; set; }
    }
}
