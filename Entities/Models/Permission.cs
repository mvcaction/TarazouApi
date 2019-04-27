using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class Permission
    {
        public Permission()
        {
            PermissionRole = new HashSet<PermissionRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SystemName { get; set; }
        public string Area { get; set; }
        public bool LoginNeed { get; set; }
        public int PermissionTypeId { get; set; }

        public PermissionType PermissionType { get; set; }
        public ICollection<PermissionRole> PermissionRole { get; set; }
    }
}
