using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VasuthalozatPublicApplication.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Railways",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FromID = table.Column<int>(type: "int", nullable: false),
                    ToID = table.Column<int>(type: "int", nullable: false),
                    Km = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Railways", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Railways_Cities_FromID",
                        column: x => x.FromID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Railways_Cities_ToID",
                        column: x => x.ToID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Foglalasok",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    RailwayID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foglalasok", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Foglalasok_Railways_RailwayID",
                        column: x => x.RailwayID,
                        principalTable: "Railways",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Foglalasok_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Wonoharjo" },
                    { 18, "Elliot" },
                    { 17, "Arruda dos Vinhos" },
                    { 16, "Dongshi" },
                    { 15, "Sao Joao del Rei" },
                    { 14, "Normanton" },
                    { 13, "San Lorenzo" },
                    { 12, "Caoxi" },
                    { 11, "Kabardinka" },
                    { 10, "Dollard-Des Ormeaux" },
                    { 9, "Nova Kakhovka" },
                    { 8, "Kuantan" },
                    { 7, "Golcuv Jeníkov" },
                    { 6, "Bentar" },
                    { 5, "Manicaragua" },
                    { 4, "Beni" },
                    { 3, "Chivhu" },
                    { 2, "Miaoyu" },
                    { 19, "Upper San Mateo" },
                    { 20, "Kalilangan" }
                });

            migrationBuilder.InsertData(
                table: "Railways",
                columns: new[] { "ID", "FromID", "Km", "ToID" },
                values: new object[,]
                {
                    { 5, 2, 49, 3 },
                    { 38, 8, 75, 18 },
                    { 31, 7, 45, 18 },
                    { 4, 1, 145, 18 },
                    { 75, 17, 132, 16 },
                    { 74, 17, 112, 12 },
                    { 73, 17, 130, 10 },
                    { 72, 17, 75, 4 },
                    { 70, 16, 132, 17 },
                    { 47, 10, 115, 18 },
                    { 52, 12, 112, 17 },
                    { 19, 4, 75, 17 },
                    { 69, 16, 46, 14 },
                    { 68, 16, 55, 13 },
                    { 67, 16, 46, 9 },
                    { 66, 16, 78, 8 },
                    { 65, 16, 49, 6 },
                    { 61, 14, 46, 16 },
                    { 56, 13, 55, 16 },
                    { 46, 10, 130, 17 },
                    { 71, 16, 115, 18 },
                    { 76, 18, 145, 1 },
                    { 77, 18, 45, 7 },
                    { 88, 20, 47, 11 },
                    { 87, 20, 148, 9 },
                    { 86, 20, 131, 7 },
                    { 85, 20, 2, 5 },
                    { 84, 20, 14, 3 },
                    { 83, 19, 99, 20 },
                    { 64, 15, 115, 20 },
                    { 51, 11, 47, 20 },
                    { 44, 9, 148, 20 },
                    { 32, 7, 131, 20 },
                    { 24, 5, 2, 20 },
                    { 15, 3, 14, 20 },
                    { 82, 19, 67, 3 },
                    { 81, 19, 42, 2 },
                    { 14, 3, 67, 19 },
                    { 9, 2, 42, 19 },
                    { 80, 18, 115, 16 },
                    { 79, 18, 115, 10 },
                    { 78, 18, 75, 8 },
                    { 43, 9, 46, 16 },
                    { 37, 8, 78, 16 },
                    { 29, 6, 49, 16 },
                    { 63, 15, 129, 14 },
                    { 35, 8, 98, 6 },
                    { 34, 8, 134, 5 },
                    { 33, 8, 95, 2 },
                    { 27, 6, 98, 8 },
                    { 21, 5, 134, 8 },
                    { 8, 2, 95, 8 },
                    { 30, 7, 34, 3 },
                    { 12, 3, 34, 7 },
                    { 26, 6, 116, 4 },
                    { 25, 6, 92, 2 },
                    { 18, 4, 116, 6 },
                    { 7, 2, 92, 6 },
                    { 20, 5, 82, 2 },
                    { 6, 2, 82, 5 },
                    { 17, 4, 66, 3 },
                    { 16, 4, 38, 1 },
                    { 11, 3, 66, 4 },
                    { 1, 1, 38, 4 },
                    { 10, 3, 49, 2 },
                    { 22, 5, 68, 9 },
                    { 89, 20, 115, 15 },
                    { 36, 8, 89, 9 },
                    { 40, 9, 89, 8 },
                    { 62, 15, 83, 1 },
                    { 60, 14, 129, 15 },
                    { 3, 1, 83, 15 },
                    { 59, 14, 2, 13 },
                    { 58, 14, 11, 11 },
                    { 57, 14, 1, 3 },
                    { 55, 13, 2, 14 },
                    { 50, 11, 11, 14 },
                    { 13, 3, 1, 14 },
                    { 54, 13, 96, 9 },
                    { 53, 13, 56, 1 },
                    { 42, 9, 96, 13 },
                    { 2, 1, 56, 13 },
                    { 49, 11, 56, 6 },
                    { 48, 11, 148, 5 },
                    { 28, 6, 56, 11 },
                    { 23, 5, 148, 11 },
                    { 45, 10, 117, 9 },
                    { 41, 9, 117, 10 },
                    { 39, 9, 68, 5 },
                    { 90, 20, 99, 19 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foglalasok_RailwayID",
                table: "Foglalasok",
                column: "RailwayID");

            migrationBuilder.CreateIndex(
                name: "IX_Foglalasok_UserID",
                table: "Foglalasok",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Railways_FromID",
                table: "Railways",
                column: "FromID");

            migrationBuilder.CreateIndex(
                name: "IX_Railways_ToID",
                table: "Railways",
                column: "ToID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foglalasok");

            migrationBuilder.DropTable(
                name: "Railways");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
