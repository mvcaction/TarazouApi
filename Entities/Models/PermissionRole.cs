using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class PermissionRole
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public Permission Permission { get; set; }
        public Role Role { get; set; }
    }
}
