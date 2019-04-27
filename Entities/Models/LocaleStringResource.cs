using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class LocaleStringResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LocaleStringResourceTypeId { get; set; }
        public int LanguageId { get; set; }
        public string ResourceName { get; set; }
        public string ResourceValue { get; set; }
        public bool Editable { get; set; }
        public bool IsHtml { get; set; }

        public Language Language { get; set; }
        public LocaleStringResourceType LocaleStringResourceType { get; set; }
    }
}
