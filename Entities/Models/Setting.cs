using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class Setting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int SettingModuleId { get; set; }
        public int? SiteId { get; set; }

        public SettingModule SettingModule { get; set; }
        public Site Site { get; set; }
    }
}
