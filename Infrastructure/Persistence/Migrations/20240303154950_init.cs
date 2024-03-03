using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Links = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListAdsMedia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdsTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Centers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CenterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Media = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Centers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    TotalBalance = table.Column<double>(type: "float", nullable: false),
                    Debt = table.Column<double>(type: "float", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExternalCenters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExternalCenterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalBalance = table.Column<double>(type: "float", nullable: false),
                    Dept = table.Column<double>(type: "float", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalCenters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResEmployee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestaurantAccountId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalBalance = table.Column<double>(type: "float", nullable: false),
                    Debt = table.Column<double>(type: "float", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListSkills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainerSpecialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainerAccountId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HallName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenterId = table.Column<int>(type: "int", nullable: false),
                    ListDetials = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Halls_Centers_CenterId",
                        column: x => x.CenterId,
                        principalTable: "Centers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExternalReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExternalCenterId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExternalReservations_ExternalCenters_ExternalCenterId",
                        column: x => x.ExternalCenterId,
                        principalTable: "ExternalCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    TotalBalance = table.Column<double>(type: "float", nullable: false),
                    Debt = table.Column<double>(type: "float", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantAccounts_Restaurants_Id",
                        column: x => x.Id,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainerAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    TotalBalance = table.Column<double>(type: "float", nullable: false),
                    Debt = table.Column<double>(type: "float", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainerAccounts_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubTrainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubTrainingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTrainingDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingTypeId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTrainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubTrainings_TrainingTypes_TrainingTypeId",
                        column: x => x.TrainingTypeId,
                        principalTable: "TrainingTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReservationDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExternalReservationId = table.Column<int>(type: "int", nullable: false),
                    Services = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expense = table.Column<double>(type: "float", nullable: false),
                    ExpenseCost = table.Column<double>(type: "float", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationDays_ExternalReservations_ExternalReservationId",
                        column: x => x.ExternalReservationId,
                        principalTable: "ExternalReservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainerSubTraining",
                columns: table => new
                {
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    SubTrainingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerSubTraining", x => new { x.TrainerId, x.SubTrainingId });
                    table.ForeignKey(
                        name: "FK_TrainerSubTraining_SubTrainings_SubTrainingId",
                        column: x => x.SubTrainingId,
                        principalTable: "SubTrainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainerSubTraining_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalCosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    Detailes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhotoInvoiceURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TraningId = table.Column<int>(type: "int", nullable: false),
                    TrainingInvoiceId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalCosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendanceName = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainingId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    Deduct = table.Column<double>(type: "float", nullable: true),
                    AdvancePayment = table.Column<double>(type: "float", nullable: true),
                    Reward = table.Column<double>(type: "float", nullable: true),
                    TotalBalance = table.Column<double>(type: "float", nullable: false),
                    Debt = table.Column<double>(type: "float", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogisticCosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoInvoiceURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    CenterId = table.Column<int>(type: "int", nullable: false),
                    TotalBalance = table.Column<double>(type: "float", nullable: false),
                    Debt = table.Column<double>(type: "float", nullable: false),
                    TrainingInvoiceId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogisticCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogisticCosts_Centers_CenterId",
                        column: x => x.CenterId,
                        principalTable: "Centers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Receiver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogisticCostId = table.Column<int>(type: "int", nullable: true),
                    ClientAccountId = table.Column<int>(type: "int", nullable: true),
                    EmployeeAccountId = table.Column<int>(type: "int", nullable: true),
                    RestaurantAccountId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receipts_ClientAccounts_ClientAccountId",
                        column: x => x.ClientAccountId,
                        principalTable: "ClientAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receipts_EmployeeAccounts_EmployeeAccountId",
                        column: x => x.EmployeeAccountId,
                        principalTable: "EmployeeAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receipts_LogisticCosts_LogisticCostId",
                        column: x => x.LogisticCostId,
                        principalTable: "LogisticCosts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Receipts_RestaurantAccounts_RestaurantAccountId",
                        column: x => x.RestaurantAccountId,
                        principalTable: "RestaurantAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailPrice = table.Column<double>(type: "float", nullable: false),
                    MailPriceForORG = table.Column<double>(type: "float", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    TotalPriceForORG = table.Column<double>(type: "float", nullable: false),
                    RestaurantAccountId = table.Column<int>(type: "int", nullable: true),
                    TrainingInvoiceId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mails_RestaurantAccounts_RestaurantAccountId",
                        column: x => x.RestaurantAccountId,
                        principalTable: "RestaurantAccounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OtherExpenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    PhotoInvoiceURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherExpenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HallId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    TrainingId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: true),
                    ClientAccountId = table.Column<int>(type: "int", nullable: true),
                    CenterId = table.Column<int>(type: "int", nullable: true),
                    EmployeeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: true),
                    EmployeeAccountId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Centers_CenterId",
                        column: x => x.CenterId,
                        principalTable: "Centers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_ClientAccounts_ClientAccountId",
                        column: x => x.ClientAccountId,
                        principalTable: "ClientAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    NumberOfStudents = table.Column<int>(type: "int", nullable: false),
                    TrainingDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    ClientAccountId = table.Column<int>(type: "int", nullable: true),
                    TrainerAccountId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainings_ClientAccounts_ClientAccountId",
                        column: x => x.ClientAccountId,
                        principalTable: "ClientAccounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trainings_TrainerAccounts_TrainerAccountId",
                        column: x => x.TrainerAccountId,
                        principalTable: "TrainerAccounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trainings_Users_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TraineeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttendanceId = table.Column<int>(type: "int", nullable: false),
                    ListAttendanceStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainees_Attendance_AttendanceId",
                        column: x => x.AttendanceId,
                        principalTable: "Attendance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trainees_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingInvoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TraningId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    CenterId = table.Column<int>(type: "int", nullable: false),
                    MealsCost = table.Column<double>(type: "float", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    TrainerCost = table.Column<double>(type: "float", nullable: false),
                    PhotoInvoiceURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReservationsCost = table.Column<double>(type: "float", nullable: false),
                    TotalCost = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    FinalCost = table.Column<double>(type: "float", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingInvoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingInvoices_Centers_CenterId",
                        column: x => x.CenterId,
                        principalTable: "Centers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingInvoices_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingInvoices_Trainings_TraningId",
                        column: x => x.TraningId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingInvoices_Users_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalCosts_TrainingInvoiceId",
                table: "AdditionalCosts",
                column: "TrainingInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalCosts_TraningId",
                table: "AdditionalCosts",
                column: "TraningId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_TrainingId",
                table: "Attendance",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAccounts_EmployeeId",
                table: "EmployeeAccounts",
                column: "EmployeeId",
                unique: true,
                filter: "[EmployeeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalReservations_ExternalCenterId",
                table: "ExternalReservations",
                column: "ExternalCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Halls_CenterId",
                table: "Halls",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticCosts_CenterId",
                table: "LogisticCosts",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticCosts_TrainingInvoiceId",
                table: "LogisticCosts",
                column: "TrainingInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_LogisticCosts_UserId",
                table: "LogisticCosts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Mails_RestaurantAccountId",
                table: "Mails",
                column: "RestaurantAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Mails_TrainingInvoiceId",
                table: "Mails",
                column: "TrainingInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Mails_UserId",
                table: "Mails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherExpenses_EmployeeId",
                table: "OtherExpenses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_ClientAccountId",
                table: "Receipts",
                column: "ClientAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_EmployeeAccountId",
                table: "Receipts",
                column: "EmployeeAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_LogisticCostId",
                table: "Receipts",
                column: "LogisticCostId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_RestaurantAccountId",
                table: "Receipts",
                column: "RestaurantAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDays_ExternalReservationId",
                table: "ReservationDays",
                column: "ExternalReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_HallId",
                table: "Reservations",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_TrainingId",
                table: "Reservations",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTrainings_TrainingTypeId",
                table: "SubTrainings",
                column: "TrainingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_AttendanceId",
                table: "Trainees",
                column: "AttendanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_TrainingId",
                table: "Trainees",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerAccounts_TrainerId",
                table: "TrainerAccounts",
                column: "TrainerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainerSubTraining_SubTrainingId",
                table: "TrainerSubTraining",
                column: "SubTrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingInvoices_CenterId",
                table: "TrainingInvoices",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingInvoices_ClientId",
                table: "TrainingInvoices",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingInvoices_TrainerId",
                table: "TrainingInvoices",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingInvoices_TraningId",
                table: "TrainingInvoices",
                column: "TraningId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_ClientAccountId",
                table: "Trainings",
                column: "ClientAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_ClientId",
                table: "Trainings",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_TrainerAccountId",
                table: "Trainings",
                column: "TrainerAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CenterId",
                table: "Users",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ClientAccountId",
                table: "Users",
                column: "ClientAccountId",
                unique: true,
                filter: "[ClientAccountId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ReservationId",
                table: "Users",
                column: "ReservationId",
                unique: true,
                filter: "[ReservationId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalCosts_TrainingInvoices_TrainingInvoiceId",
                table: "AdditionalCosts",
                column: "TrainingInvoiceId",
                principalTable: "TrainingInvoices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalCosts_Trainings_TraningId",
                table: "AdditionalCosts",
                column: "TraningId",
                principalTable: "Trainings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Trainings_TrainingId",
                table: "Attendance",
                column: "TrainingId",
                principalTable: "Trainings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAccounts_Users_EmployeeId",
                table: "EmployeeAccounts",
                column: "EmployeeId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LogisticCosts_TrainingInvoices_TrainingInvoiceId",
                table: "LogisticCosts",
                column: "TrainingInvoiceId",
                principalTable: "TrainingInvoices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LogisticCosts_Users_UserId",
                table: "LogisticCosts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mails_TrainingInvoices_TrainingInvoiceId",
                table: "Mails",
                column: "TrainingInvoiceId",
                principalTable: "TrainingInvoices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mails_Users_UserId",
                table: "Mails",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OtherExpenses_Users_EmployeeId",
                table: "OtherExpenses",
                column: "EmployeeId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Trainings_TrainingId",
                table: "Reservations",
                column: "TrainingId",
                principalTable: "Trainings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Trainings_TrainingId",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "AboutUs");

            migrationBuilder.DropTable(
                name: "AdditionalCosts");

            migrationBuilder.DropTable(
                name: "Ads");

            migrationBuilder.DropTable(
                name: "Mails");

            migrationBuilder.DropTable(
                name: "OtherExpenses");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "ReservationDays");

            migrationBuilder.DropTable(
                name: "SupplierAccounts");

            migrationBuilder.DropTable(
                name: "Trainees");

            migrationBuilder.DropTable(
                name: "TrainerSubTraining");

            migrationBuilder.DropTable(
                name: "EmployeeAccounts");

            migrationBuilder.DropTable(
                name: "LogisticCosts");

            migrationBuilder.DropTable(
                name: "RestaurantAccounts");

            migrationBuilder.DropTable(
                name: "ExternalReservations");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "SubTrainings");

            migrationBuilder.DropTable(
                name: "TrainingInvoices");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "ExternalCenters");

            migrationBuilder.DropTable(
                name: "TrainingTypes");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "TrainerAccounts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "ClientAccounts");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "Centers");
        }
    }
}
