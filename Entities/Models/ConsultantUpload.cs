using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class ConsultantUpload
    {
        public int Id { get; set; }
        public int ConsultantId { get; set; }
        public int UserId { get; set; }
        public string Url { get; set; }
        public string FileName { get; set; }
        public int Size { get; set; }
        public string ContentType { get; set; }
        public string FileType { get; set; }

        public Consultant Consultant { get; set; }
        public User User { get; set; }
    }
}
