using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class TemplateType
    {
        public TemplateType()
        {
            Template = new HashSet<Template>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Template> Template { get; set; }
    }
}
