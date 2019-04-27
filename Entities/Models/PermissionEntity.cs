using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class PermissionEntity
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public string EntityName { get; set; }
        public int RoleId { get; set; }

        public Role Role { get; set; }
    }
}
