using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class AnswerAttachment
    {
        public int Id { get; set; }
        public int AnswerId { get; set; }
        public string Url { get; set; }
        public string FileName { get; set; }
        public int Size { get; set; }
        public string ContentType { get; set; }
        public string FileType { get; set; }

        public Answer Answer { get; set; }
    }
}
