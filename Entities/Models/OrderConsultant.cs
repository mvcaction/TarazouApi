using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class OrderConsultant
    {
        public OrderConsultant()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public Guid OrderGuid { get; set; }
        public int UserId { get; set; }
        public int ConsultantId { get; set; }
        public int OrderStatusId { get; set; }
        public int TransactionStatusId { get; set; }
        public string PaymentMethodSystemName { get; set; }
        public string Peygiri { get; set; }
        public int Price { get; set; }
        public DateTime? PaidDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public string PaymentDescription { get; set; }

        public Consultant Consultant { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        public User User { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
    }
}
