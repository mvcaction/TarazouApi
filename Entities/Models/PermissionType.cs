using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class PermissionType
    {
        public PermissionType()
        {
            Permission = new HashSet<Permission>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Permission> Permission { get; set; }
    }
}
