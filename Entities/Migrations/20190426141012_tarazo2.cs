using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class tarazo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityLogType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SystemKeyword = table.Column<string>(maxLength: 100, nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Enabled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLogType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnswerStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsultantQuestionStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultantQuestionStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailAccount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 255, nullable: false),
                    Host = table.Column<string>(maxLength: 255, nullable: false),
                    Port = table.Column<int>(nullable: false),
                    Username = table.Column<string>(maxLength: 255, nullable: false),
                    Password = table.Column<string>(maxLength: 500, nullable: false),
                    EnableSsl = table.Column<bool>(nullable: false),
                    UseDefaultCredentials = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAccount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailPriority",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailPriority", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    LanguageCulture = table.Column<string>(maxLength: 20, nullable: false),
                    UniqueSeoCode = table.Column<string>(maxLength: 2, nullable: true),
                    FlagImageFileName = table.Column<string>(maxLength: 50, nullable: true),
                    Rtl = table.Column<bool>(nullable: false),
                    DefaultCurrencyId = table.Column<int>(nullable: false),
                    Published = table.Column<bool>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocaleStringResourceType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocaleStringResourceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermissionType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Picture",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PictureBinary = table.Column<byte[]>(nullable: true),
                    MimeType = table.Column<string>(maxLength: 40, nullable: false),
                    SeoFilename = table.Column<string>(maxLength: 300, nullable: true),
                    AltAttribute = table.Column<string>(nullable: true),
                    TitleAttribute = table.Column<string>(nullable: true),
                    IsNew = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    ImageUrl = table.Column<string>(maxLength: 500, nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Satisfaction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    ScoreConsultant = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satisfaction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleTask",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Seconds = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    StopOnError = table.Column<bool>(nullable: false),
                    LeasedByMachineName = table.Column<string>(nullable: true),
                    LeasedUntilUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastStartUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastEndUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSuccessUtc = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleTask", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SettingModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ModuleName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingModule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmsAccountType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsAccountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmsPriority",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsPriority", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmsStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemplateType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketSection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(unicode: false, nullable: true),
                    Sms = table.Column<string>(unicode: false, nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    IsPositive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UrlRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntityId = table.Column<int>(nullable: false),
                    EntityName = table.Column<string>(maxLength: 400, nullable: false),
                    Slug = table.Column<string>(maxLength: 400, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QueuedEmail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PriorityId = table.Column<int>(nullable: false),
                    From = table.Column<string>(maxLength: 500, nullable: false),
                    FromName = table.Column<string>(maxLength: 500, nullable: true),
                    To = table.Column<string>(maxLength: 500, nullable: false),
                    ToName = table.Column<string>(maxLength: 500, nullable: true),
                    ReplyTo = table.Column<string>(maxLength: 500, nullable: true),
                    ReplyToName = table.Column<string>(maxLength: 500, nullable: true),
                    CC = table.Column<string>(maxLength: 500, nullable: true),
                    Bcc = table.Column<string>(maxLength: 500, nullable: true),
                    Subject = table.Column<string>(maxLength: 1000, nullable: true),
                    Body = table.Column<string>(nullable: true),
                    AttachmentFilePath = table.Column<string>(nullable: true),
                    AttachmentFileName = table.Column<string>(nullable: true),
                    AttachedDownloadId = table.Column<int>(nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: false),
                    DontSendBeforeDateUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    SentTries = table.Column<int>(nullable: false),
                    SentOnUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmailAccountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueuedEmail", x => x.Id);
                    table.ForeignKey(
                        name: "QueuedEmail_EmailAccount",
                        column: x => x.EmailAccountId,
                        principalTable: "EmailAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocalizedProperty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntityId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    LocaleKeyGroup = table.Column<string>(maxLength: 400, nullable: false),
                    LocaleKey = table.Column<string>(maxLength: 400, nullable: false),
                    LocaleValue = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalizedProperty", x => x.Id);
                    table.ForeignKey(
                        name: "LocalizedProperty_Language",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 400, nullable: false),
                    Url = table.Column<string>(maxLength: 400, nullable: false),
                    SslEnabled = table.Column<bool>(nullable: false),
                    SecureUrl = table.Column<string>(maxLength: 400, nullable: true),
                    Hosts = table.Column<string>(maxLength: 1000, nullable: true),
                    DefaultLanguageId = table.Column<int>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false),
                    CompanyName = table.Column<string>(maxLength: 1000, nullable: true),
                    CompanyAddress = table.Column<string>(maxLength: 1000, nullable: true),
                    CompanyPhoneNumber = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Portal_Language",
                        column: x => x.DefaultLanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocaleStringResource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 500, nullable: true),
                    LocaleStringResourceTypeId = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    LanguageId = table.Column<int>(nullable: false),
                    ResourceName = table.Column<string>(maxLength: 200, nullable: false),
                    ResourceValue = table.Column<string>(nullable: false),
                    Editable = table.Column<bool>(nullable: false),
                    IsHtml = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocaleStringResource", x => x.Id);
                    table.ForeignKey(
                        name: "LocaleStringResource_Language",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocaleStringResource_LocaleStringResourceType",
                        column: x => x.LocaleStringResourceTypeId,
                        principalTable: "LocaleStringResourceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 500, nullable: false),
                    SystemName = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Area = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    LoginNeed = table.Column<bool>(nullable: false),
                    PermissionTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permission_PermissionType",
                        column: x => x.PermissionTypeId,
                        principalTable: "PermissionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ProvinceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Province",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    IsSystemRole = table.Column<bool>(nullable: false),
                    SystemName = table.Column<string>(maxLength: 255, nullable: true),
                    Deleted = table.Column<bool>(nullable: true),
                    TypeId = table.Column<int>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_RoleType",
                        column: x => x.TypeId,
                        principalTable: "RoleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SmsAccount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Username = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Tel = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Api = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SmsAccountTypeId = table.Column<int>(nullable: false),
                    Active = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SmsAccount_SmsAccountType",
                        column: x => x.SmsAccountTypeId,
                        principalTable: "SmsAccountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(maxLength: 100, nullable: false),
                    Subject = table.Column<string>(maxLength: 250, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Mobile = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    TicketSectionId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(maxLength: 2000, nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    TicketStatusId = table.Column<int>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_TicketSection",
                        column: x => x.TicketSectionId,
                        principalTable: "TicketSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_TicketStatus",
                        column: x => x.TicketStatusId,
                        principalTable: "TicketStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GenericAttribute",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntityId = table.Column<int>(nullable: false),
                    KeyGroup = table.Column<string>(maxLength: 400, nullable: false),
                    Key = table.Column<string>(maxLength: 400, nullable: false),
                    Value = table.Column<string>(nullable: false),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericAttribute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenericAttribute_Site",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Value = table.Column<string>(maxLength: 2000, nullable: false),
                    SettingModuleId = table.Column<int>(nullable: false),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Setting_SettingModule",
                        column: x => x.SettingModuleId,
                        principalTable: "SettingModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Setting_Site",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SiteMapping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntityId = table.Column<int>(nullable: false),
                    EntityName = table.Column<string>(maxLength: 400, nullable: false),
                    SiteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SiteMapping_Site",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Username = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    Mobile = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    MobileVerificationCode = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    PasswordSalt = table.Column<string>(maxLength: 20, nullable: false),
                    IsSystemAccount = table.Column<bool>(nullable: true),
                    SystemName = table.Column<string>(maxLength: 400, nullable: true),
                    ImageUrl = table.Column<string>(maxLength: 500, nullable: true),
                    ProvinceId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: true),
                    IsVerify = table.Column<bool>(nullable: false),
                    Credit = table.Column<int>(nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: true),
                    LastLoginDate = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_City",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Province",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PermissionEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntityId = table.Column<int>(nullable: false),
                    EntityName = table.Column<string>(maxLength: 400, nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AclRecord_Role",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PermissionRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermissionRole_Permission",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermissionRole_Role",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActivityLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActivityLogTypeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: false),
                    IpAddress = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLog", x => x.Id);
                    table.ForeignKey(
                        name: "ActivityLog_ActivityLogType",
                        column: x => x.ActivityLogTypeId,
                        principalTable: "ActivityLogType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "ActivityLog_Customer",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consultant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    VekalatCode = table.Column<string>(maxLength: 50, nullable: false),
                    VekalatLocation = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 500, nullable: false),
                    Sheba = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    MaxSelectQuestionInDay = table.Column<int>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    ImmediateQuestionAllowed = table.Column<bool>(nullable: false),
                    ScoreConsultant = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consultant_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Coupon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Code = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ExpiredTime = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    IsValid = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coupon_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailQueue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailAccountId = table.Column<int>(nullable: true),
                    IsQueue = table.Column<bool>(nullable: false),
                    ReceiverUserId = table.Column<int>(nullable: true),
                    EmailStatusId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    Text = table.Column<string>(nullable: false),
                    EmailPriorityId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailQueue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailQueue_EmailAccount",
                        column: x => x.EmailAccountId,
                        principalTable: "EmailAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailQueue_EmailPriority",
                        column: x => x.EmailPriorityId,
                        principalTable: "EmailPriority",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailQueue_EmailStatus",
                        column: x => x.EmailStatusId,
                        principalTable: "EmailStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailQueue_User",
                        column: x => x.ReceiverUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExternalAuthenticationRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    ExternalIdentifier = table.Column<string>(nullable: true),
                    ExternalDisplayIdentifier = table.Column<string>(nullable: true),
                    OAuthToken = table.Column<string>(nullable: true),
                    OAuthAccessToken = table.Column<string>(nullable: true),
                    ProviderSystemName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalAuthenticationRecord", x => x.Id);
                    table.ForeignKey(
                        name: "ExternalAuthenticationRecord_Customer",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiftCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Remain = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    Code = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiftCard_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LogLevelId = table.Column<int>(nullable: false),
                    ShortMessage = table.Column<string>(nullable: false),
                    FullMessage = table.Column<string>(nullable: true),
                    IpAddress = table.Column<string>(maxLength: 200, nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    PageUrl = table.Column<string>(nullable: true),
                    ReferrerUrl = table.Column<string>(nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Log_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SmsQueue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SmsAccountId = table.Column<int>(nullable: true),
                    IsQueue = table.Column<bool>(nullable: false),
                    ReceiverUserId = table.Column<int>(nullable: true),
                    SmsStatusId = table.Column<int>(nullable: false),
                    Mobile = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    Text = table.Column<string>(nullable: false),
                    SmsPriorityId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsQueue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SmsQueue_User",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SmsQueue_User1",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SmsQueue_SmsPriority",
                        column: x => x.SmsPriorityId,
                        principalTable: "SmsPriority",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Template",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Subject = table.Column<string>(maxLength: 1000, nullable: false),
                    Body = table.Column<string>(nullable: false),
                    TemplateTypeId = table.Column<int>(nullable: false),
                    Tokens = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    IsQueued = table.Column<bool>(nullable: false),
                    EmailAccountId = table.Column<int>(nullable: true),
                    SmsAccountId = table.Column<int>(nullable: true),
                    IsFlash = table.Column<bool>(nullable: false),
                    IsFlashSupport = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    ModifiedBy = table.Column<int>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Template", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Template_User",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Template_EmailAccount",
                        column: x => x.EmailAccountId,
                        principalTable: "EmailAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Template_User1",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Template_SmsAccount",
                        column: x => x.SmsAccountId,
                        principalTable: "SmsAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Template_TemplateType",
                        column: x => x.TemplateTypeId,
                        principalTable: "TemplateType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserForgetPassword",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserForgetPassword", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserForgetPassword_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    CompanyName = table.Column<string>(maxLength: 100, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    Zipcode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Phone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Fax = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfile_Gender",
                        column: x => x.Gender,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserProfile_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_Role",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRole_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consultant_QuestionCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConsultantId = table.Column<int>(nullable: false),
                    QuestionCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultant_QuestionCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consultant_QuestionCategory_Consultant",
                        column: x => x.ConsultantId,
                        principalTable: "Consultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultant_QuestionCategory_QuestionCategory",
                        column: x => x.QuestionCategoryId,
                        principalTable: "QuestionCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConsultantUpload",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConsultantId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Url = table.Column<string>(maxLength: 250, nullable: false),
                    FileName = table.Column<string>(maxLength: 50, nullable: true),
                    Size = table.Column<int>(nullable: false),
                    ContentType = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    FileType = table.Column<string>(unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultantUpload", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsultantUpload_Consultant",
                        column: x => x.ConsultantId,
                        principalTable: "Consultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConsultantUpload_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderConsultant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderGuid = table.Column<Guid>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ConsultantId = table.Column<int>(nullable: false),
                    OrderStatusId = table.Column<int>(nullable: false),
                    TransactionStatusId = table.Column<int>(nullable: false),
                    PaymentMethodSystemName = table.Column<string>(nullable: true),
                    Peygiri = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Price = table.Column<int>(nullable: false),
                    PaidDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    PaymentDescription = table.Column<string>(maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderConsultant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderConsultant_Consultant",
                        column: x => x.ConsultantId,
                        principalTable: "Consultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderConsultant_OrderStatus",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderConsultant_TransactionStatus",
                        column: x => x.TransactionStatusId,
                        principalTable: "TransactionStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderConsultant_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: false),
                    QuestionCategoryId = table.Column<int>(nullable: false),
                    QuestionTypeId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsPay = table.Column<bool>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: true),
                    LastStatusId = table.Column<int>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: true),
                    SelectConsultantId = table.Column<int>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    LastAnsweringTime = table.Column<DateTime>(nullable: true),
                    Immediate = table.Column<bool>(nullable: false),
                    AllowedAnsweringTime = table.Column<DateTime>(nullable: true),
                    ScoreConsultant = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_QuestionStatus",
                        column: x => x.LastStatusId,
                        principalTable: "QuestionStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Question_QuestionCategory",
                        column: x => x.QuestionCategoryId,
                        principalTable: "QuestionCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Question_QuestionType",
                        column: x => x.QuestionTypeId,
                        principalTable: "QuestionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Question_Consultant",
                        column: x => x.SelectConsultantId,
                        principalTable: "Consultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Question_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionId = table.Column<int>(nullable: false),
                    ConsultantId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: false),
                    SatisfactionId = table.Column<int>(nullable: true),
                    DissatisfactionComment = table.Column<string>(maxLength: 500, nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    SatisfactionTime = table.Column<DateTime>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    ScoreConsultant = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answer_Consultant",
                        column: x => x.ConsultantId,
                        principalTable: "Consultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Answer_Question",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Answer_Satisfaction",
                        column: x => x.SatisfactionId,
                        principalTable: "Satisfaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Answer_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConsultantQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConsultantId = table.Column<int>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    Immediate = table.Column<bool>(nullable: false),
                    QuestionStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultantQuestion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsultantQuestion_Consultant",
                        column: x => x.ConsultantId,
                        principalTable: "Consultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConsultantQuestion_Question",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConsultantQuestion_QuestionStatus",
                        column: x => x.QuestionStatusId,
                        principalTable: "QuestionStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConsultantQuestion_ConsultantQuestionStatus",
                        column: x => x.StatusId,
                        principalTable: "ConsultantQuestionStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderGuid = table.Column<Guid>(nullable: false),
                    SiteId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    OrderStatusId = table.Column<int>(nullable: false),
                    PaymentStatusId = table.Column<int>(nullable: false),
                    PaymentMethodSystemName = table.Column<string>(nullable: true),
                    OrderDiscountPrice = table.Column<int>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false),
                    OrderPrice = table.Column<int>(nullable: false),
                    OrderTotalPrice = table.Column<int>(nullable: false),
                    PaidDateUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    Deleted = table.Column<bool>(nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_OrderStatus",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_PaymentStatus",
                        column: x => x.PaymentStatusId,
                        principalTable: "PaymentStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Question",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Site",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionId = table.Column<int>(nullable: false),
                    Url = table.Column<string>(maxLength: 250, nullable: false),
                    FileName = table.Column<string>(maxLength: 50, nullable: false),
                    Size = table.Column<int>(nullable: false),
                    ContentType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    FileType = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionAttachment_Question",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReportQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionId = table.Column<int>(nullable: false),
                    ConsultantId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(maxLength: 500, nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportQuestion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportQuestion_Consultant",
                        column: x => x.ConsultantId,
                        principalTable: "Consultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReportQuestion_Question",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SiteId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItem_Product",
                        column: x => x.ProductId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItem_Site",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItem_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnswerAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnswerId = table.Column<int>(nullable: false),
                    Url = table.Column<string>(maxLength: 250, nullable: false),
                    FileName = table.Column<string>(maxLength: 50, nullable: false),
                    Size = table.Column<int>(nullable: false),
                    ContentType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    FileType = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnswerAttachment_Answer",
                        column: x => x.AnswerId,
                        principalTable: "Answer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnswerConsultant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnswerId = table.Column<int>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false),
                    ConsultantId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    SatisfactionId = table.Column<int>(nullable: false),
                    DissatisfactionComment = table.Column<string>(maxLength: 500, nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ScoreConsultant = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerConsultant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnswerConsultant_Answer",
                        column: x => x.AnswerId,
                        principalTable: "Answer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnswerConsultant_Consultant",
                        column: x => x.ConsultantId,
                        principalTable: "Consultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnswerConsultant_Question",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnswerConsultant_Satisfaction",
                        column: x => x.SatisfactionId,
                        principalTable: "Satisfaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GiftCardUsage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GiftCardId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    UsedValue = table.Column<int>(nullable: false),
                    IsTemp = table.Column<bool>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ModifiedTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftCardUsage", x => x.Id);
                    table.ForeignKey(
                        name: "GiftCardUsageHistory_GiftCard",
                        column: x => x.GiftCardId,
                        principalTable: "GiftCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "GiftCardUsageHistory_UsedWithOrder",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderItemGuid = table.Column<Guid>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "OrderItem_Order",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "OrderItem_Product",
                        column: x => x.ProductId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    TransactionTypeId = table.Column<int>(nullable: false),
                    TransactionStatusId = table.Column<int>(nullable: false),
                    Peygiri = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    RefId = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    QuestionId = table.Column<int>(nullable: true),
                    CurrentConsultantScore = table.Column<int>(nullable: true),
                    QuestionColor = table.Column<int>(nullable: true),
                    QuestionColorPercent = table.Column<int>(nullable: true),
                    ConsultantScorePrice = table.Column<int>(nullable: true),
                    ConsultantQuestionColorPrice = table.Column<int>(nullable: true),
                    OrderConsultantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_OrderConsultant",
                        column: x => x.OrderConsultantId,
                        principalTable: "OrderConsultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transaction_Invoice",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transaction_Question",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transaction_TransactionStatus",
                        column: x => x.TransactionStatusId,
                        principalTable: "TransactionStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transaction_TransactionType",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transaction_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionView",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionId = table.Column<int>(nullable: false),
                    AttachmentId = table.Column<int>(nullable: true),
                    ConsultantId = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionView", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionView_QuestionAttachment",
                        column: x => x.AttachmentId,
                        principalTable: "QuestionAttachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuestionView_Consultant",
                        column: x => x.ConsultantId,
                        principalTable: "Consultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuestionView_Question",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityLog_ActivityLogTypeId",
                table: "ActivityLog",
                column: "ActivityLogTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityLog_CreatedOnUtc",
                table: "ActivityLog",
                column: "CreatedOnUtc");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityLog_UserId",
                table: "ActivityLog",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_ConsultantId",
                table: "Answer",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_SatisfactionId",
                table: "Answer",
                column: "SatisfactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_UserId",
                table: "Answer",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerAttachment_AnswerId",
                table: "AnswerAttachment",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerConsultant_AnswerId",
                table: "AnswerConsultant",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerConsultant_ConsultantId",
                table: "AnswerConsultant",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerConsultant_QuestionId",
                table: "AnswerConsultant",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerConsultant_SatisfactionId",
                table: "AnswerConsultant",
                column: "SatisfactionId");

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceId",
                table: "City",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultant_UserId",
                table: "Consultant",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultant_QuestionCategory_ConsultantId",
                table: "Consultant_QuestionCategory",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultant_QuestionCategory_QuestionCategoryId",
                table: "Consultant_QuestionCategory",
                column: "QuestionCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultantQuestion_ConsultantId",
                table: "ConsultantQuestion",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultantQuestion_QuestionId",
                table: "ConsultantQuestion",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultantQuestion_QuestionStatusId",
                table: "ConsultantQuestion",
                column: "QuestionStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultantQuestion_StatusId",
                table: "ConsultantQuestion",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultantUpload_ConsultantId",
                table: "ConsultantUpload",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultantUpload_UserId",
                table: "ConsultantUpload",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupon_UserId",
                table: "Coupon",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailQueue_EmailAccountId",
                table: "EmailQueue",
                column: "EmailAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailQueue_EmailPriorityId",
                table: "EmailQueue",
                column: "EmailPriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailQueue_EmailStatusId",
                table: "EmailQueue",
                column: "EmailStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailQueue_ReceiverUserId",
                table: "EmailQueue",
                column: "ReceiverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalAuthenticationRecord_UserId",
                table: "ExternalAuthenticationRecord",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericAttribute_SiteId",
                table: "GenericAttribute",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericAttribute_EntityId_and_KeyGroup",
                table: "GenericAttribute",
                columns: new[] { "EntityId", "KeyGroup" });

            migrationBuilder.CreateIndex(
                name: "IX_GiftCard_UserId",
                table: "GiftCard",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GiftCardUsage_GiftCardId",
                table: "GiftCardUsage",
                column: "GiftCardId");

            migrationBuilder.CreateIndex(
                name: "IX_GiftCardUsage_OrderId",
                table: "GiftCardUsage",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Language_DisplayOrder",
                table: "Language",
                column: "DisplayOrder");

            migrationBuilder.CreateIndex(
                name: "IX_LocaleStringResource_LanguageId",
                table: "LocaleStringResource",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_LocaleStringResource_LocaleStringResourceTypeId",
                table: "LocaleStringResource",
                column: "LocaleStringResourceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LocaleStringResource",
                table: "LocaleStringResource",
                columns: new[] { "ResourceName", "LanguageId" });

            migrationBuilder.CreateIndex(
                name: "IX_LocalizedProperty_LanguageId",
                table: "LocalizedProperty",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Log_CreatedOnUtc",
                table: "Log",
                column: "CreatedOnUtc");

            migrationBuilder.CreateIndex(
                name: "IX_Log_UserId",
                table: "Log",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderStatusId",
                table: "Order",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentStatusId",
                table: "Order",
                column: "PaymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_QuestionId",
                table: "Order",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_SiteId",
                table: "Order",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderConsultant_ConsultantId",
                table: "OrderConsultant",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderConsultant_OrderStatusId",
                table: "OrderConsultant",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderConsultant_TransactionStatusId",
                table: "OrderConsultant",
                column: "TransactionStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderConsultant_UserId",
                table: "OrderConsultant",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_PermissionTypeId",
                table: "Permission",
                column: "PermissionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionEntity_RoleId",
                table: "PermissionEntity",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AclRecord_EntityId_EntityName",
                table: "PermissionEntity",
                columns: new[] { "EntityId", "EntityName" });

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRole_PermissionId",
                table: "PermissionRole",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRole_RoleId",
                table: "PermissionRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_LastStatusId",
                table: "Question",
                column: "LastStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_QuestionCategoryId",
                table: "Question",
                column: "QuestionCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_QuestionTypeId",
                table: "Question",
                column: "QuestionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_SelectConsultantId",
                table: "Question",
                column: "SelectConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_UserId",
                table: "Question",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAttachment_QuestionId",
                table: "QuestionAttachment",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionView_AttachmentId",
                table: "QuestionView",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionView_ConsultantId",
                table: "QuestionView",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionView_QuestionId",
                table: "QuestionView",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QueuedEmail_EmailAccountId",
                table: "QueuedEmail",
                column: "EmailAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportQuestion_ConsultantId",
                table: "ReportQuestion",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportQuestion_QuestionId",
                table: "ReportQuestion",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_TypeId",
                table: "Role",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Setting_SettingModuleId",
                table: "Setting",
                column: "SettingModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Setting_SiteId",
                table: "Setting",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItem_ProductId",
                table: "ShoppingCartItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItem_SiteId",
                table: "ShoppingCartItem",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItem_UserId",
                table: "ShoppingCartItem",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Site_DefaultLanguageId",
                table: "Site",
                column: "DefaultLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteMapping_SiteId",
                table: "SiteMapping",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreMapping_EntityId_EntityName",
                table: "SiteMapping",
                columns: new[] { "EntityId", "EntityName" });

            migrationBuilder.CreateIndex(
                name: "IX_SmsAccount_SmsAccountTypeId",
                table: "SmsAccount",
                column: "SmsAccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SmsQueue_CreatedBy",
                table: "SmsQueue",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SmsQueue_ModifiedBy",
                table: "SmsQueue",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SmsQueue_SmsPriorityId",
                table: "SmsQueue",
                column: "SmsPriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Template_CreatedBy",
                table: "Template",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Template_EmailAccountId",
                table: "Template",
                column: "EmailAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Template_ModifiedBy",
                table: "Template",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Template_SmsAccountId",
                table: "Template",
                column: "SmsAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Template_TemplateTypeId",
                table: "Template",
                column: "TemplateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TicketSectionId",
                table: "Ticket",
                column: "TicketSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TicketStatusId",
                table: "Ticket",
                column: "TicketStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_OrderConsultantId",
                table: "Transaction",
                column: "OrderConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_OrderId",
                table: "Transaction",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_QuestionId",
                table: "Transaction",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_TransactionStatusId",
                table: "Transaction",
                column: "TransactionStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_TransactionTypeId",
                table: "Transaction",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_UserId",
                table: "Transaction",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UrlRecord_Slug",
                table: "UrlRecord",
                column: "Slug");

            migrationBuilder.CreateIndex(
                name: "IX_UrlRecord_Custom_1",
                table: "UrlRecord",
                columns: new[] { "EntityId", "EntityName", "LanguageId", "IsActive" });

            migrationBuilder.CreateIndex(
                name: "IX_User_CityId",
                table: "User",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ProvinceId",
                table: "User",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserForgetPassword_UserId",
                table: "UserForgetPassword",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_Gender",
                table: "UserProfile",
                column: "Gender");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_UserId",
                table: "UserProfile",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityLog");

            migrationBuilder.DropTable(
                name: "AnswerAttachment");

            migrationBuilder.DropTable(
                name: "AnswerConsultant");

            migrationBuilder.DropTable(
                name: "AnswerStatus");

            migrationBuilder.DropTable(
                name: "Consultant_QuestionCategory");

            migrationBuilder.DropTable(
                name: "ConsultantQuestion");

            migrationBuilder.DropTable(
                name: "ConsultantUpload");

            migrationBuilder.DropTable(
                name: "Coupon");

            migrationBuilder.DropTable(
                name: "EmailQueue");

            migrationBuilder.DropTable(
                name: "ExternalAuthenticationRecord");

            migrationBuilder.DropTable(
                name: "GenericAttribute");

            migrationBuilder.DropTable(
                name: "GiftCardUsage");

            migrationBuilder.DropTable(
                name: "LocaleStringResource");

            migrationBuilder.DropTable(
                name: "LocalizedProperty");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "PermissionEntity");

            migrationBuilder.DropTable(
                name: "PermissionRole");

            migrationBuilder.DropTable(
                name: "Picture");

            migrationBuilder.DropTable(
                name: "QuestionView");

            migrationBuilder.DropTable(
                name: "QueuedEmail");

            migrationBuilder.DropTable(
                name: "ReportQuestion");

            migrationBuilder.DropTable(
                name: "ScheduleTask");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "ShoppingCartItem");

            migrationBuilder.DropTable(
                name: "SiteMapping");

            migrationBuilder.DropTable(
                name: "SmsQueue");

            migrationBuilder.DropTable(
                name: "SmsStatus");

            migrationBuilder.DropTable(
                name: "Template");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "UrlRecord");

            migrationBuilder.DropTable(
                name: "UserForgetPassword");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "ActivityLogType");

            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "ConsultantQuestionStatus");

            migrationBuilder.DropTable(
                name: "EmailPriority");

            migrationBuilder.DropTable(
                name: "EmailStatus");

            migrationBuilder.DropTable(
                name: "GiftCard");

            migrationBuilder.DropTable(
                name: "LocaleStringResourceType");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "QuestionAttachment");

            migrationBuilder.DropTable(
                name: "SettingModule");

            migrationBuilder.DropTable(
                name: "SmsPriority");

            migrationBuilder.DropTable(
                name: "EmailAccount");

            migrationBuilder.DropTable(
                name: "SmsAccount");

            migrationBuilder.DropTable(
                name: "TemplateType");

            migrationBuilder.DropTable(
                name: "TicketSection");

            migrationBuilder.DropTable(
                name: "TicketStatus");

            migrationBuilder.DropTable(
                name: "OrderConsultant");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "TransactionType");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Satisfaction");

            migrationBuilder.DropTable(
                name: "PermissionType");

            migrationBuilder.DropTable(
                name: "SmsAccountType");

            migrationBuilder.DropTable(
                name: "TransactionStatus");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "PaymentStatus");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropTable(
                name: "RoleType");

            migrationBuilder.DropTable(
                name: "QuestionStatus");

            migrationBuilder.DropTable(
                name: "QuestionCategory");

            migrationBuilder.DropTable(
                name: "QuestionType");

            migrationBuilder.DropTable(
                name: "Consultant");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Province");
        }
    }
}
