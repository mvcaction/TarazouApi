using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class UserProfile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Gender { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public Gender GenderNavigation { get; set; }
        public User User { get; set; }
    }
}
