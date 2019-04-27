using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class Satisfaction
    {
        public Satisfaction()
        {
            Answer = new HashSet<Answer>();
            AnswerConsultant = new HashSet<AnswerConsultant>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public bool Selected { get; set; }
        public int Score { get; set; }
        public int ScoreConsultant { get; set; }

        public ICollection<Answer> Answer { get; set; }
        public ICollection<AnswerConsultant> AnswerConsultant { get; set; }
    }
}
