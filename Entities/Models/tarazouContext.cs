using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using  Tarazou4.Entities;
namespace Tarazou4.Data
{
    public partial class tarazouContext : DbContext
    {
        public tarazouContext()
        {
        }

        public tarazouContext(DbContextOptions<tarazouContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityLog> ActivityLog { get; set; }
        public virtual DbSet<ActivityLogType> ActivityLogType { get; set; }
        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<AnswerAttachment> AnswerAttachment { get; set; }
        public virtual DbSet<AnswerConsultant> AnswerConsultant { get; set; }
        public virtual DbSet<AnswerStatus> AnswerStatus { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Consultant> Consultant { get; set; }
        public virtual DbSet<ConsultantQuestion> ConsultantQuestion { get; set; }
        public virtual DbSet<ConsultantQuestionCategory> ConsultantQuestionCategory { get; set; }
        public virtual DbSet<ConsultantQuestionStatus> ConsultantQuestionStatus { get; set; }
        public virtual DbSet<ConsultantUpload> ConsultantUpload { get; set; }
        public virtual DbSet<Coupon> Coupon { get; set; }
        public virtual DbSet<EmailAccount> EmailAccount { get; set; }
        public virtual DbSet<EmailPriority> EmailPriority { get; set; }
        public virtual DbSet<EmailQueue> EmailQueue { get; set; }
        public virtual DbSet<EmailStatus> EmailStatus { get; set; }
        public virtual DbSet<ExternalAuthenticationRecord> ExternalAuthenticationRecord { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<GenericAttribute> GenericAttribute { get; set; }
        public virtual DbSet<GiftCard> GiftCard { get; set; }
        public virtual DbSet<GiftCardUsage> GiftCardUsage { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LocaleStringResource> LocaleStringResource { get; set; }
        public virtual DbSet<LocaleStringResourceType> LocaleStringResourceType { get; set; }
        public virtual DbSet<LocalizedProperty> LocalizedProperty { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderConsultant> OrderConsultant { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<PaymentStatus> PaymentStatus { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PermissionEntity> PermissionEntity { get; set; }
        public virtual DbSet<PermissionRole> PermissionRole { get; set; }
        public virtual DbSet<PermissionType> PermissionType { get; set; }
        public virtual DbSet<Picture> Picture { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<QuestionAttachment> QuestionAttachment { get; set; }
        public virtual DbSet<QuestionCategory> QuestionCategory { get; set; }
        public virtual DbSet<QuestionStatus> QuestionStatus { get; set; }
        public virtual DbSet<QuestionType> QuestionType { get; set; }
        public virtual DbSet<QuestionView> QuestionView { get; set; }
        public virtual DbSet<QueuedEmail> QueuedEmail { get; set; }
        public virtual DbSet<ReportQuestion> ReportQuestion { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleType> RoleType { get; set; }
        public virtual DbSet<Satisfaction> Satisfaction { get; set; }
        public virtual DbSet<ScheduleTask> ScheduleTask { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<SettingModule> SettingModule { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public virtual DbSet<Site> Site { get; set; }
        public virtual DbSet<SiteMapping> SiteMapping { get; set; }
        public virtual DbSet<SmsAccount> SmsAccount { get; set; }
        public virtual DbSet<SmsAccountType> SmsAccountType { get; set; }
        public virtual DbSet<SmsPriority> SmsPriority { get; set; }
        public virtual DbSet<SmsQueue> SmsQueue { get; set; }
        public virtual DbSet<SmsStatus> SmsStatus { get; set; }
        public virtual DbSet<Template> Template { get; set; }
        public virtual DbSet<TemplateType> TemplateType { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<TicketSection> TicketSection { get; set; }
        public virtual DbSet<TicketStatus> TicketStatus { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<TransactionStatus> TransactionStatus { get; set; }
        public virtual DbSet<TransactionType> TransactionType { get; set; }
        public virtual DbSet<UrlRecord> UrlRecord { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserForgetPassword> UserForgetPassword { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-HPUJ150\\SQLEXPRESS;Database=tarazouApi2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.HasIndex(e => e.CreatedOnUtc);

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.IpAddress).HasMaxLength(200);

                entity.HasOne(d => d.ActivityLogType)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => d.ActivityLogTypeId)
                    .HasConstraintName("ActivityLog_ActivityLogType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("ActivityLog_Customer");
            });

            modelBuilder.Entity<ActivityLogType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.DissatisfactionComment).HasMaxLength(500);

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.Answer)
                    .HasForeignKey(d => d.ConsultantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Answer_Consultant");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answer)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Answer_Question");

                entity.HasOne(d => d.Satisfaction)
                    .WithMany(p => p.Answer)
                    .HasForeignKey(d => d.SatisfactionId)
                    .HasConstraintName("FK_Answer_Satisfaction");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Answer)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Answer_User");
            });

            modelBuilder.Entity<AnswerAttachment>(entity =>
            {
                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.AnswerAttachment)
                    .HasForeignKey(d => d.AnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnswerAttachment_Answer");
            });

            modelBuilder.Entity<AnswerConsultant>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DissatisfactionComment).HasMaxLength(500);

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.AnswerConsultant)
                    .HasForeignKey(d => d.AnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnswerConsultant_Answer");

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.AnswerConsultant)
                    .HasForeignKey(d => d.ConsultantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnswerConsultant_Consultant");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.AnswerConsultant)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnswerConsultant_Question");

                entity.HasOne(d => d.Satisfaction)
                    .WithMany(p => p.AnswerConsultant)
                    .HasForeignKey(d => d.SatisfactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnswerConsultant_Satisfaction");
            });

            modelBuilder.Entity<AnswerStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_City_Province");
            });

            modelBuilder.Entity<Consultant>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Sheba)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VekalatCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VekalatLocation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Consultant)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Consultant_User");
            });

            modelBuilder.Entity<ConsultantQuestion>(entity =>
            {
                entity.Property(e => e.StatusId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.ConsultantQuestion)
                    .HasForeignKey(d => d.ConsultantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsultantQuestion_Consultant");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.ConsultantQuestion)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsultantQuestion_Question");

                entity.HasOne(d => d.QuestionStatus)
                    .WithMany(p => p.ConsultantQuestion)
                    .HasForeignKey(d => d.QuestionStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsultantQuestion_QuestionStatus");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ConsultantQuestion)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsultantQuestion_ConsultantQuestionStatus");
            });

            modelBuilder.Entity<ConsultantQuestionCategory>(entity =>
            {
                entity.ToTable("Consultant_QuestionCategory");

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.ConsultantQuestionCategory)
                    .HasForeignKey(d => d.ConsultantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Consultant_QuestionCategory_Consultant");

                entity.HasOne(d => d.QuestionCategory)
                    .WithMany(p => p.ConsultantQuestionCategory)
                    .HasForeignKey(d => d.QuestionCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Consultant_QuestionCategory_QuestionCategory");
            });

            modelBuilder.Entity<ConsultantQuestionStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ConsultantUpload>(entity =>
            {
                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.ConsultantUpload)
                    .HasForeignKey(d => d.ConsultantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsultantUpload_Consultant");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ConsultantUpload)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsultantUpload_User");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Coupon)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Coupon_User");
            });

            modelBuilder.Entity<EmailAccount>(entity =>
            {
                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<EmailPriority>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmailQueue>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.EmailAccount)
                    .WithMany(p => p.EmailQueue)
                    .HasForeignKey(d => d.EmailAccountId)
                    .HasConstraintName("FK_EmailQueue_EmailAccount");

                entity.HasOne(d => d.EmailPriority)
                    .WithMany(p => p.EmailQueue)
                    .HasForeignKey(d => d.EmailPriorityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailQueue_EmailPriority");

                entity.HasOne(d => d.EmailStatus)
                    .WithMany(p => p.EmailQueue)
                    .HasForeignKey(d => d.EmailStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailQueue_EmailStatus");

                entity.HasOne(d => d.ReceiverUser)
                    .WithMany(p => p.EmailQueue)
                    .HasForeignKey(d => d.ReceiverUserId)
                    .HasConstraintName("FK_EmailQueue_User");
            });

            modelBuilder.Entity<EmailStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ExternalAuthenticationRecord>(entity =>
            {
                entity.Property(e => e.OauthAccessToken).HasColumnName("OAuthAccessToken");

                entity.Property(e => e.OauthToken).HasColumnName("OAuthToken");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ExternalAuthenticationRecord)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("ExternalAuthenticationRecord_Customer");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GenericAttribute>(entity =>
            {
                entity.HasIndex(e => new { e.EntityId, e.KeyGroup })
                    .HasName("IX_GenericAttribute_EntityId_and_KeyGroup");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.KeyGroup)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.GenericAttribute)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_GenericAttribute_Site");
            });

            modelBuilder.Entity<GiftCard>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GiftCard)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_GiftCard_User");
            });

            modelBuilder.Entity<GiftCardUsage>(entity =>
            {
                entity.HasOne(d => d.GiftCard)
                    .WithMany(p => p.GiftCardUsage)
                    .HasForeignKey(d => d.GiftCardId)
                    .HasConstraintName("GiftCardUsageHistory_GiftCard");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.GiftCardUsage)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("GiftCardUsageHistory_UsedWithOrder");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasIndex(e => e.DisplayOrder);

                entity.Property(e => e.FlagImageFileName).HasMaxLength(50);

                entity.Property(e => e.LanguageCulture)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UniqueSeoCode).HasMaxLength(2);
            });

            modelBuilder.Entity<LocaleStringResource>(entity =>
            {
                entity.HasIndex(e => new { e.ResourceName, e.LanguageId })
                    .HasName("IX_LocaleStringResource");

                entity.Property(e => e.LocaleStringResourceTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ResourceValue).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LocaleStringResource)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("LocaleStringResource_Language");

                entity.HasOne(d => d.LocaleStringResourceType)
                    .WithMany(p => p.LocaleStringResource)
                    .HasForeignKey(d => d.LocaleStringResourceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocaleStringResource_LocaleStringResourceType");
            });

            modelBuilder.Entity<LocaleStringResourceType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LocalizedProperty>(entity =>
            {
                entity.Property(e => e.LocaleKey)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.LocaleKeyGroup)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.LocaleValue).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LocalizedProperty)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("LocalizedProperty_Language");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasIndex(e => e.CreatedOnUtc);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.IpAddress).HasMaxLength(200);

                entity.Property(e => e.ShortMessage).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Log)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Log_User");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.PaidDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.OrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_OrderStatus");

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_PaymentStatus");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Question");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Site");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_User");
            });

            modelBuilder.Entity<OrderConsultant>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDescription).HasMaxLength(2000);

                entity.Property(e => e.Peygiri)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.OrderConsultant)
                    .HasForeignKey(d => d.ConsultantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderConsultant_Consultant");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.OrderConsultant)
                    .HasForeignKey(d => d.OrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderConsultant_OrderStatus");

                entity.HasOne(d => d.TransactionStatus)
                    .WithMany(p => p.OrderConsultant)
                    .HasForeignKey(d => d.TransactionStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderConsultant_TransactionStatus");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrderConsultant)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderConsultant_User");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("OrderItem_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("OrderItem_Product");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SystemName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.PermissionType)
                    .WithMany(p => p.Permission)
                    .HasForeignKey(d => d.PermissionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permission_PermissionType");
            });

            modelBuilder.Entity<PermissionEntity>(entity =>
            {
                entity.HasIndex(e => new { e.EntityId, e.EntityName })
                    .HasName("IX_AclRecord_EntityId_EntityName");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PermissionEntity)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AclRecord_Role");
            });

            modelBuilder.Entity<PermissionRole>(entity =>
            {
                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.PermissionRole)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionRole_Permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PermissionRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionRole_Role");
            });

            modelBuilder.Entity<PermissionType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.SeoFilename).HasMaxLength(300);
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.LastStatus)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.LastStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_QuestionStatus");

                entity.HasOne(d => d.QuestionCategory)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.QuestionCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_QuestionCategory");

                entity.HasOne(d => d.QuestionType)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.QuestionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_QuestionType");

                entity.HasOne(d => d.SelectConsultant)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.SelectConsultantId)
                    .HasConstraintName("FK_Question_Consultant");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_User");
            });

            modelBuilder.Entity<QuestionAttachment>(entity =>
            {
                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionAttachment)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionAttachment_Question");
            });

            modelBuilder.Entity<QuestionCategory>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<QuestionStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QuestionType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ImageUrl).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<QuestionView>(entity =>
            {
                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.QuestionView)
                    .HasForeignKey(d => d.AttachmentId)
                    .HasConstraintName("FK_QuestionView_QuestionAttachment");

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.QuestionView)
                    .HasForeignKey(d => d.ConsultantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionView_Consultant");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionView)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionView_Question");
            });

            modelBuilder.Entity<QueuedEmail>(entity =>
            {
                entity.Property(e => e.Bcc).HasMaxLength(500);

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.DontSendBeforeDateUtc).HasColumnType("datetime");

                entity.Property(e => e.From)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FromName).HasMaxLength(500);

                entity.Property(e => e.ReplyTo).HasMaxLength(500);

                entity.Property(e => e.ReplyToName).HasMaxLength(500);

                entity.Property(e => e.SentOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(1000);

                entity.Property(e => e.To)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ToName).HasMaxLength(500);

                entity.HasOne(d => d.EmailAccount)
                    .WithMany(p => p.QueuedEmail)
                    .HasForeignKey(d => d.EmailAccountId)
                    .HasConstraintName("QueuedEmail_EmailAccount");
            });

            modelBuilder.Entity<ReportQuestion>(entity =>
            {
                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.ReportQuestion)
                    .HasForeignKey(d => d.ConsultantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportQuestion_Consultant");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.ReportQuestion)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportQuestion_Question");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.Property(e => e.TypeId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Role)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_RoleType");
            });

            modelBuilder.Entity<RoleType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Satisfaction>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ScheduleTask>(entity =>
            {
                entity.Property(e => e.LastEndUtc).HasColumnType("datetime");

                entity.Property(e => e.LastStartUtc).HasColumnType("datetime");

                entity.Property(e => e.LastSuccessUtc).HasColumnType("datetime");

                entity.Property(e => e.LeasedUntilUtc).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.SettingModule)
                    .WithMany(p => p.Setting)
                    .HasForeignKey(d => d.SettingModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Setting_SettingModule");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Setting)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_Setting_Site");
            });

            modelBuilder.Entity<SettingModule>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShoppingCartItem>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShoppingCartItem)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCartItem_Product");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.ShoppingCartItem)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCartItem_Site");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ShoppingCartItem)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCartItem_User");
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.Property(e => e.CompanyAddress).HasMaxLength(1000);

                entity.Property(e => e.CompanyName).HasMaxLength(1000);

                entity.Property(e => e.CompanyPhoneNumber).HasMaxLength(1000);

                entity.Property(e => e.Hosts).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.SecureUrl).HasMaxLength(400);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.DefaultLanguage)
                    .WithMany(p => p.Site)
                    .HasForeignKey(d => d.DefaultLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Portal_Language");
            });

            modelBuilder.Entity<SiteMapping>(entity =>
            {
                entity.HasIndex(e => new { e.EntityId, e.EntityName })
                    .HasName("IX_StoreMapping_EntityId_EntityName");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.SiteMapping)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SiteMapping_Site");
            });

            modelBuilder.Entity<SmsAccount>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Api)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SmsAccountType)
                    .WithMany(p => p.SmsAccount)
                    .HasForeignKey(d => d.SmsAccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SmsAccount_SmsAccountType");
            });

            modelBuilder.Entity<SmsAccountType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmsPriority>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SmsQueue>(entity =>
            {
                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SmsQueueCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SmsQueue_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SmsQueueModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_SmsQueue_User1");

                entity.HasOne(d => d.SmsPriority)
                    .WithMany(p => p.SmsQueue)
                    .HasForeignKey(d => d.SmsPriorityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SmsQueue_SmsPriority");
            });

            modelBuilder.Entity<SmsStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Template>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Tokens)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TemplateCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Template_User");

                entity.HasOne(d => d.EmailAccount)
                    .WithMany(p => p.Template)
                    .HasForeignKey(d => d.EmailAccountId)
                    .HasConstraintName("FK_Template_EmailAccount");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.TemplateModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Template_User1");

                entity.HasOne(d => d.SmsAccount)
                    .WithMany(p => p.Template)
                    .HasForeignKey(d => d.SmsAccountId)
                    .HasConstraintName("FK_Template_SmsAccount");

                entity.HasOne(d => d.TemplateType)
                    .WithMany(p => p.Template)
                    .HasForeignKey(d => d.TemplateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Template_TemplateType");
            });

            modelBuilder.Entity<TemplateType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.TicketSection)
                    .WithMany(p => p.Ticket)
                    .HasForeignKey(d => d.TicketSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticket_TicketSection");

                entity.HasOne(d => d.TicketStatus)
                    .WithMany(p => p.Ticket)
                    .HasForeignKey(d => d.TicketStatusId)
                    .HasConstraintName("FK_Ticket_TicketStatus");
            });

            modelBuilder.Entity<TicketSection>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sms).IsUnicode(false);
            });

            modelBuilder.Entity<TicketStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.Property(e => e.Peygiri)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RefId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.OrderConsultant)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.OrderConsultantId)
                    .HasConstraintName("FK_Transaction_OrderConsultant");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Transaction_Invoice");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_Transaction_Question");

                entity.HasOne(d => d.TransactionStatus)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.TransactionStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_TransactionStatus");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_TransactionType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_User");
            });

            modelBuilder.Entity<TransactionStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UrlRecord>(entity =>
            {
                entity.HasIndex(e => e.Slug);

                entity.HasIndex(e => new { e.EntityId, e.EntityName, e.LanguageId, e.IsActive })
                    .HasName("IX_UrlRecord_Custom_1");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ImageUrl).HasMaxLength(500);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MobileVerificationCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SystemName).HasMaxLength(400);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_User_City");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Province");
            });

            modelBuilder.Entity<UserForgetPassword>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserForgetPassword)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserForgetPassword_User");
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.GenderNavigation)
                    .WithMany(p => p.UserProfile)
                    .HasForeignKey(d => d.Gender)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProfile_Gender");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserProfile)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProfile_User");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_User");
            });
        }
    }
}
