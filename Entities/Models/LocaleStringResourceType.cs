using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class LocaleStringResourceType
    {
        public LocaleStringResourceType()
        {
            LocaleStringResource = new HashSet<LocaleStringResource>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<LocaleStringResource> LocaleStringResource { get; set; }
    }
}
