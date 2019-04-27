using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class Role
    {
        public Role()
        {
            PermissionEntity = new HashSet<PermissionEntity>();
            PermissionRole = new HashSet<PermissionRole>();
            UserRole = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public bool IsSystemRole { get; set; }
        public string SystemName { get; set; }
        public bool? Deleted { get; set; }
        public int TypeId { get; set; }

        public RoleType Type { get; set; }
        public ICollection<PermissionEntity> PermissionEntity { get; set; }
        public ICollection<PermissionRole> PermissionRole { get; set; }
        public ICollection<UserRole> UserRole { get; set; }
    }
}
