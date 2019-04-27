using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class SiteMapping
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public string EntityName { get; set; }
        public int SiteId { get; set; }

        public Site Site { get; set; }
    }
}
