using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class ReportQuestion
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int ConsultantId { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }

        public Consultant Consultant { get; set; }
        public Question Question { get; set; }
    }
}
