using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class SettingModule
    {
        public SettingModule()
        {
            Setting = new HashSet<Setting>();
        }

        public int Id { get; set; }
        public string ModuleName { get; set; }

        public ICollection<Setting> Setting { get; set; }
    }
}
