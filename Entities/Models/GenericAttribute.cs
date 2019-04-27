using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class GenericAttribute
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public string KeyGroup { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int? SiteId { get; set; }

        public Site Site { get; set; }
    }
}
