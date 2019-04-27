using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class UserForgetPassword
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Code { get; set; }
        public int Type { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsActive { get; set; }

        public User User { get; set; }
    }
}
