using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class Coupon
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int Number { get; set; }
        public string Code { get; set; }
        public DateTime? ExpiredTime { get; set; }
        public bool Active { get; set; }
        public bool IsValid { get; set; }
        public int? UserId { get; set; }

        public User User { get; set; }
    }
}
