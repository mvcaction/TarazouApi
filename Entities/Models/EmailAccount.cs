using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class EmailAccount
    {
        public EmailAccount()
        {
            EmailQueue = new HashSet<EmailQueue>();
            QueuedEmail = new HashSet<QueuedEmail>();
            Template = new HashSet<Template>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool EnableSsl { get; set; }
        public bool UseDefaultCredentials { get; set; }

        public ICollection<EmailQueue> EmailQueue { get; set; }
        public ICollection<QueuedEmail> QueuedEmail { get; set; }
        public ICollection<Template> Template { get; set; }
    }
}
