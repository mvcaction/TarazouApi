using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class AnswerConsultant
    {
        public int Id { get; set; }
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public int ConsultantId { get; set; }
        public string Description { get; set; }
        public int SatisfactionId { get; set; }
        public string DissatisfactionComment { get; set; }
        public DateTime CreateTime { get; set; }
        public int ScoreConsultant { get; set; }

        public Answer Answer { get; set; }
        public Consultant Consultant { get; set; }
        public Question Question { get; set; }
        public Satisfaction Satisfaction { get; set; }
    }
}
