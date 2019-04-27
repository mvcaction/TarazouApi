using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{ 
    public partial class QuestionType
    {
        public QuestionType()
        {
            Question = new HashSet<Question>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public bool Active { get; set; }

        public ICollection<Question> Question { get; set; }
    }
}
