using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class Order
    {
        public Order()
        {
            GiftCardUsage = new HashSet<GiftCardUsage>();
            OrderItem = new HashSet<OrderItem>();
            Transaction = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public Guid OrderGuid { get; set; }
        public int SiteId { get; set; }
        public int UserId { get; set; }
        public int OrderStatusId { get; set; }
        public int PaymentStatusId { get; set; }
        public string PaymentMethodSystemName { get; set; }
        public int OrderDiscountPrice { get; set; }
        public int QuestionId { get; set; }
        public int OrderPrice { get; set; }
        public int OrderTotalPrice { get; set; }
        public DateTime? PaidDateUtc { get; set; }
        public bool? Deleted { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public bool Active { get; set; }

        public OrderStatus OrderStatus { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public Question Question { get; set; }
        public Site Site { get; set; }
        public User User { get; set; }
        public ICollection<GiftCardUsage> GiftCardUsage { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
    }
}
