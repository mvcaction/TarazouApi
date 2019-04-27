using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class Consultant
    {
        public Consultant()
        {
            Answer = new HashSet<Answer>();
            AnswerConsultant = new HashSet<AnswerConsultant>();
            ConsultantQuestion = new HashSet<ConsultantQuestion>();
            ConsultantQuestionCategory = new HashSet<ConsultantQuestionCategory>();
            ConsultantUpload = new HashSet<ConsultantUpload>();
            OrderConsultant = new HashSet<OrderConsultant>();
            Question = new HashSet<Question>();
            QuestionView = new HashSet<QuestionView>();
            ReportQuestion = new HashSet<ReportQuestion>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string VekalatCode { get; set; }
        public string VekalatLocation { get; set; }
        public string Address { get; set; }
        public string Sheba { get; set; }
        public bool Active { get; set; }
        public int MaxSelectQuestionInDay { get; set; }
        public int Score { get; set; }
        public bool ImmediateQuestionAllowed { get; set; }
        public int ScoreConsultant { get; set; }

        public User User { get; set; }
        public ICollection<Answer> Answer { get; set; }
        public ICollection<AnswerConsultant> AnswerConsultant { get; set; }
        public ICollection<ConsultantQuestion> ConsultantQuestion { get; set; }
        public ICollection<ConsultantQuestionCategory> ConsultantQuestionCategory { get; set; }
        public ICollection<ConsultantUpload> ConsultantUpload { get; set; }
        public ICollection<OrderConsultant> OrderConsultant { get; set; }
        public ICollection<Question> Question { get; set; }
        public ICollection<QuestionView> QuestionView { get; set; }
        public ICollection<ReportQuestion> ReportQuestion { get; set; }
    }
}
