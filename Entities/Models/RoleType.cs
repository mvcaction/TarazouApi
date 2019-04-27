using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class RoleType
    {
        public RoleType()
        {
            Role = new HashSet<Role>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Role> Role { get; set; }
    }
}
