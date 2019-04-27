using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class ConsultantQuestionCategory
    {
        public int Id { get; set; }
        public int ConsultantId { get; set; }
        public int QuestionCategoryId { get; set; }

        public Consultant Consultant { get; set; }
        public QuestionCategory QuestionCategory { get; set; }
    }
}
