using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class Language
    {
        public Language()
        {
            LocaleStringResource = new HashSet<LocaleStringResource>();
            LocalizedProperty = new HashSet<LocalizedProperty>();
            Site = new HashSet<Site>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LanguageCulture { get; set; }
        public string UniqueSeoCode { get; set; }
        public string FlagImageFileName { get; set; }
        public bool Rtl { get; set; }
        public int DefaultCurrencyId { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }

        public ICollection<LocaleStringResource> LocaleStringResource { get; set; }
        public ICollection<LocalizedProperty> LocalizedProperty { get; set; }
        public ICollection<Site> Site { get; set; }
    }
}
