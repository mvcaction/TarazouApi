using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class QuestionView
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int? AttachmentId { get; set; }
        public int ConsultantId { get; set; }
        public DateTime CreateTime { get; set; }

        public QuestionAttachment Attachment { get; set; }
        public Consultant Consultant { get; set; }
        public Question Question { get; set; }
    }
}
