using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class ConsultantQuestionStatus
    {
        public ConsultantQuestionStatus()
        {
            ConsultantQuestion = new HashSet<ConsultantQuestion>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ConsultantQuestion> ConsultantQuestion { get; set; }
    }
}
