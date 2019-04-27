using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class QuestionAttachment
    {
        public QuestionAttachment()
        {
            QuestionView = new HashSet<QuestionView>();
        }

        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Url { get; set; }
        public string FileName { get; set; }
        public int Size { get; set; }
        public string ContentType { get; set; }
        public string FileType { get; set; }

        public Question Question { get; set; }
        public ICollection<QuestionView> QuestionView { get; set; }
    }
}
