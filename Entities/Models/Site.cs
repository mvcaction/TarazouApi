using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class Site
    {
        public Site()
        {
            GenericAttribute = new HashSet<GenericAttribute>();
            Order = new HashSet<Order>();
            Setting = new HashSet<Setting>();
            ShoppingCartItem = new HashSet<ShoppingCartItem>();
            SiteMapping = new HashSet<SiteMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool SslEnabled { get; set; }
        public string SecureUrl { get; set; }
        public string Hosts { get; set; }
        public int DefaultLanguageId { get; set; }
        public int DisplayOrder { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhoneNumber { get; set; }

        public Language DefaultLanguage { get; set; }
        public ICollection<GenericAttribute> GenericAttribute { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<Setting> Setting { get; set; }
        public ICollection<ShoppingCartItem> ShoppingCartItem { get; set; }
        public ICollection<SiteMapping> SiteMapping { get; set; }
    }
}
