using System;
using System.Collections.Generic;

namespace Tarazou4.Entities
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? OrderId { get; set; }
        public int Price { get; set; }
        public int TransactionTypeId { get; set; }
        public int TransactionStatusId { get; set; }
        public string Peygiri { get; set; }
        public string RefId { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int? QuestionId { get; set; }
        public int? CurrentConsultantScore { get; set; }
        public int? QuestionColor { get; set; }
        public int? QuestionColorPercent { get; set; }
        public int? ConsultantScorePrice { get; set; }
        public int? ConsultantQuestionColorPrice { get; set; }
        public int? OrderConsultantId { get; set; }

        public Order Order { get; set; }
        public OrderConsultant OrderConsultant { get; set; }
        public Question Question { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        public TransactionType TransactionType { get; set; }
        public User User { get; set; }
    }
}
