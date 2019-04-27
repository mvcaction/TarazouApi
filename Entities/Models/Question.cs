using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class Question
    {
        public Question()
        {
            Answer = new HashSet<Answer>();
            AnswerConsultant = new HashSet<AnswerConsultant>();
            ConsultantQuestion = new HashSet<ConsultantQuestion>();
            Order = new HashSet<Order>();
            OrderItem = new HashSet<OrderItem>();
            QuestionAttachment = new HashSet<QuestionAttachment>();
            QuestionView = new HashSet<QuestionView>();
            ReportQuestion = new HashSet<ReportQuestion>();
            ShoppingCartItem = new HashSet<ShoppingCartItem>();
            Transaction = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int QuestionCategoryId { get; set; }
        public int QuestionTypeId { get; set; }
        public int Price { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
        public bool IsPay { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int LastStatusId { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public int? SelectConsultantId { get; set; }
        public int Score { get; set; }
        public DateTime? LastAnsweringTime { get; set; }
        public bool Immediate { get; set; }
        public DateTime? AllowedAnsweringTime { get; set; }
        public int ScoreConsultant { get; set; }

        public QuestionStatus LastStatus { get; set; }
        public QuestionCategory QuestionCategory { get; set; }
        public QuestionType QuestionType { get; set; }
        public Consultant SelectConsultant { get; set; }
        public User User { get; set; }
        public ICollection<Answer> Answer { get; set; }
        public ICollection<AnswerConsultant> AnswerConsultant { get; set; }
        public ICollection<ConsultantQuestion> ConsultantQuestion { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
        public ICollection<QuestionAttachment> QuestionAttachment { get; set; }
        public ICollection<QuestionView> QuestionView { get; set; }
        public ICollection<ReportQuestion> ReportQuestion { get; set; }
        public ICollection<ShoppingCartItem> ShoppingCartItem { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
    }
}
