using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceManagementSystem.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Todoes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todoes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TCNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarsPlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApartmentOwner = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    ApartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    ApartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApartmentBlock = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeType = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.ApartmentId);
                    table.ForeignKey(
                        name: "FK_Apartments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dues",
                columns: table => new
                {
                    DuesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dues", x => x.DuesID);
                    table.ForeignKey(
                        name: "FK_Dues_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricityBills",
                columns: table => new
                {
                    ElectricityBillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElectricityBillSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricityBillSequenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricityBillCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricityBillPrice = table.Column<int>(type: "int", nullable: false),
                    ElectricityBillDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ElectricityBillDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricityBillStatus = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricityBills", x => x.ElectricityBillID);
                    table.ForeignKey(
                        name: "FK_ElectricityBills_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NaturalGasBills",
                columns: table => new
                {
                    NaturalGasBillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NaturalGasBillSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NaturalGasBillSequenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NaturalGasBillCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NaturalGasBillPrice = table.Column<int>(type: "int", nullable: false),
                    NaturalGasBillDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NaturalGasBilllDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NaturalGasBillStatus = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaturalGasBills", x => x.NaturalGasBillID);
                    table.ForeignKey(
                        name: "FK_NaturalGasBills_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterBills",
                columns: table => new
                {
                    WaterBillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WaterBillSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterBillSequenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterBillCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterBillPrice = table.Column<int>(type: "int", nullable: false),
                    WaterBillDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WaterBillDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterBillStatus = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterBills", x => x.WaterBillID);
                    table.ForeignKey(
                        name: "FK_WaterBills_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_UserId",
                table: "Apartments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Dues_UserID",
                table: "Dues",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityBills_UserID",
                table: "ElectricityBills",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_NaturalGasBills_UserID",
                table: "NaturalGasBills",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_WaterBills_UserID",
                table: "WaterBills",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Dues");

            migrationBuilder.DropTable(
                name: "ElectricityBills");

            migrationBuilder.DropTable(
                name: "NaturalGasBills");

            migrationBuilder.DropTable(
                name: "Todoes");

            migrationBuilder.DropTable(
                name: "WaterBills");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
