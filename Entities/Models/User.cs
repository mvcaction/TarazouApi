using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tarazou4.Entities
{
    public partial class User
    {
        public User()
        {
            ActivityLog = new HashSet<ActivityLog>();
            Answer = new HashSet<Answer>();
            Consultant = new HashSet<Consultant>();
            ConsultantUpload = new HashSet<ConsultantUpload>();
            Coupon = new HashSet<Coupon>();
            EmailQueue = new HashSet<EmailQueue>();
            ExternalAuthenticationRecord = new HashSet<ExternalAuthenticationRecord>();
            GiftCard = new HashSet<GiftCard>();
            Log = new HashSet<Log>();
            Order = new HashSet<Order>();
            OrderConsultant = new HashSet<OrderConsultant>();
            Question = new HashSet<Question>();
            ShoppingCartItem = new HashSet<ShoppingCartItem>();
            SmsQueueCreatedByNavigation = new HashSet<SmsQueue>();
            SmsQueueModifiedByNavigation = new HashSet<SmsQueue>();
            TemplateCreatedByNavigation = new HashSet<Template>();
            TemplateModifiedByNavigation = new HashSet<Template>();
            Transaction = new HashSet<Transaction>();
            UserForgetPassword = new HashSet<UserForgetPassword>();
            UserProfile = new HashSet<UserProfile>();
            UserRole = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string Mobile { get; set; }
        public string MobileVerificationCode { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public bool? IsSystemAccount { get; set; }
        public string SystemName { get; set; }
        public string ImageUrl { get; set; }
        public int ProvinceId { get; set; }
        public int? CityId { get; set; }
        public bool IsVerify { get; set; }
        public int Credit { get; set; }
        [Required]
        public DateTime CreatedOnUtc { get; set; }
        public bool Active { get; set; }
        public bool? Deleted { get; set; }
        public DateTimeOffset? LastLoginDate { get; set; }

        public City City { get; set; }
        public Province Province { get; set; }
        public ICollection<ActivityLog> ActivityLog { get; set; }
        public ICollection<Answer> Answer { get; set; }
        public ICollection<Consultant> Consultant { get; set; }
        public ICollection<ConsultantUpload> ConsultantUpload { get; set; }
        public ICollection<Coupon> Coupon { get; set; }
        public ICollection<EmailQueue> EmailQueue { get; set; }
        public ICollection<ExternalAuthenticationRecord> ExternalAuthenticationRecord { get; set; }
        public ICollection<GiftCard> GiftCard { get; set; }
        public ICollection<Log> Log { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<OrderConsultant> OrderConsultant { get; set; }
        public ICollection<Question> Question { get; set; }
        public ICollection<ShoppingCartItem> ShoppingCartItem { get; set; }
        public ICollection<SmsQueue> SmsQueueCreatedByNavigation { get; set; }
        public ICollection<SmsQueue> SmsQueueModifiedByNavigation { get; set; }
        public ICollection<Template> TemplateCreatedByNavigation { get; set; }
        public ICollection<Template> TemplateModifiedByNavigation { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
        public ICollection<UserForgetPassword> UserForgetPassword { get; set; }
        public ICollection<UserProfile> UserProfile { get; set; }
        public ICollection<UserRole> UserRole { get; set; }
    }
}
