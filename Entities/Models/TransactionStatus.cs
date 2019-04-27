using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class TransactionStatus
    {
        public TransactionStatus()
        {
            OrderConsultant = new HashSet<OrderConsultant>();
            Transaction = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<OrderConsultant> OrderConsultant { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
    }
}
