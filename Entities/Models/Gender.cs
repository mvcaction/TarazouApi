using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class Gender
    {
        public Gender()
        {
            UserProfile = new HashSet<UserProfile>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<UserProfile> UserProfile { get; set; }
    }
}
