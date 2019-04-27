using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class Answer
    {
        public Answer()
        {
            AnswerAttachment = new HashSet<AnswerAttachment>();
            AnswerConsultant = new HashSet<AnswerConsultant>();
        }

        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int ConsultantId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public int? SatisfactionId { get; set; }
        public string DissatisfactionComment { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? SatisfactionTime { get; set; }
        public int Score { get; set; }
        public int ScoreConsultant { get; set; }

        public Consultant Consultant { get; set; }
        public Question Question { get; set; }
        public Satisfaction Satisfaction { get; set; }
        public User User { get; set; }
        public ICollection<AnswerAttachment> AnswerAttachment { get; set; }
        public ICollection<AnswerConsultant> AnswerConsultant { get; set; }
    }
}
