using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class LocalizedProperty
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public int LanguageId { get; set; }
        public string LocaleKeyGroup { get; set; }
        public string LocaleKey { get; set; }
        public string LocaleValue { get; set; }

        public Language Language { get; set; }
    }
}
