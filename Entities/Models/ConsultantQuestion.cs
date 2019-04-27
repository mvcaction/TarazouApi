using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class ConsultantQuestion
    {
        public int Id { get; set; }
        public int ConsultantId { get; set; }
        public int QuestionId { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool Immediate { get; set; }
        public int QuestionStatusId { get; set; }

        public Consultant Consultant { get; set; }
        public Question Question { get; set; }
        public QuestionStatus QuestionStatus { get; set; }
        public ConsultantQuestionStatus Status { get; set; }
    }
}
