using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class QuestionCategory
    {
        public QuestionCategory()
        {
            ConsultantQuestionCategory = new HashSet<ConsultantQuestionCategory>();
            Question = new HashSet<Question>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public ICollection<ConsultantQuestionCategory> ConsultantQuestionCategory { get; set; }
        public ICollection<Question> Question { get; set; }
    }
}
