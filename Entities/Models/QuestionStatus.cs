using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class QuestionStatus
    {
        public QuestionStatus()
        {
            ConsultantQuestion = new HashSet<ConsultantQuestion>();
            Question = new HashSet<Question>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ConsultantQuestion> ConsultantQuestion { get; set; }
        public ICollection<Question> Question { get; set; }
    }
}
