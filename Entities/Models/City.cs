using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class City
    {
        public City()
        {
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ProvinceId { get; set; }

        public Province Province { get; set; }
        public ICollection<User> User { get; set; }
    }
}
