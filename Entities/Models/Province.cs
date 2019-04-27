using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class Province
    {
        public Province()
        {
            City = new HashSet<City>();
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<City> City { get; set; }
        public ICollection<User> User { get; set; }
    }
}
