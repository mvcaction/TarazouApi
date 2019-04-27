using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class ShoppingCartItem
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }

        public Question Product { get; set; }
        public Site Site { get; set; }
        public User User { get; set; }
    }
}
