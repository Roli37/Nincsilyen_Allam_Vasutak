using Microsoft.EntityFrameworkCore.Migrations;

namespace VasuthalozatPublicApplication.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Wonoharjo" },
                    { 20, "Kalilangan" },
                    { 19, "Upper San Mateo" },
                    { 18, "Elliot" },
                    { 17, "Arruda dos Vinhos" },
                    { 16, "Dongshi" },
                    { 14, "Normanton" },
                    { 13, "San Lorenzo" },
                    { 12, "Caoxi" },
                    { 11, "Kabardinka" },
                    { 15, "Sao Joao del Rei" },
                    { 9, "Nova Kakhovka" },
                    { 10, "Dollard-Des Ormeaux" },
                    { 3, "Chivhu" },
                    { 4, "Beni" },
                    { 5, "Manicaragua" },
                    { 2, "Miaoyu" },
                    { 7, "Golcuv Jeníkov" },
                    { 8, "Kuantan" },
                    { 6, "Bentar" }
                });

            migrationBuilder.InsertData(
                table: "Railways",
                columns: new[] { "ID", "FromID", "Km", "ToID" },
                values: new object[,]
                {
                    { 58, null, 11, null },
                    { 65, null, 49, null },
                    { 64, null, 115, null },
                    { 63, null, 129, null },
                    { 62, null, 83, null },
                    { 61, null, 46, null },
                    { 60, null, 129, null },
                    { 59, null, 2, null },
                    { 57, null, 1, null },
                    { 47, null, 115, null },
                    { 55, null, 2, null },
                    { 54, null, 96, null },
                    { 53, null, 56, null },
                    { 52, null, 112, null },
                    { 51, null, 47, null },
                    { 50, null, 11, null },
                    { 49, null, 56, null },
                    { 48, null, 148, null },
                    { 66, null, 78, null },
                    { 56, null, 55, null },
                    { 67, null, 46, null },
                    { 77, null, 45, null },
                    { 69, null, 46, null },
                    { 88, null, 47, null },
                    { 87, null, 148, null },
                    { 86, null, 131, null },
                    { 85, null, 2, null },
                    { 84, null, 14, null },
                    { 83, null, 99, null },
                    { 82, null, 67, null },
                    { 81, null, 42, null },
                    { 80, null, 115, null },
                    { 79, null, 115, null },
                    { 78, null, 75, null },
                    { 46, null, 130, null },
                    { 76, null, 145, null },
                    { 75, null, 132, null },
                    { 74, null, 112, null },
                    { 73, null, 130, null },
                    { 72, null, 75, null },
                    { 71, null, 115, null },
                    { 70, null, 132, null },
                    { 68, null, 55, null },
                    { 45, null, 117, null },
                    { 35, null, 98, null },
                    { 43, null, 46, null },
                    { 19, null, 75, null },
                    { 18, null, 116, null },
                    { 17, null, 66, null },
                    { 16, null, 38, null },
                    { 15, null, 14, null },
                    { 14, null, 67, null },
                    { 13, null, 1, null },
                    { 12, null, 34, null },
                    { 11, null, 66, null },
                    { 10, null, 49, null },
                    { 9, null, 42, null },
                    { 8, null, 95, null },
                    { 7, null, 92, null },
                    { 6, null, 82, null },
                    { 5, null, 49, null },
                    { 4, null, 145, null },
                    { 3, null, 83, null },
                    { 2, null, 56, null },
                    { 1, null, 38, null },
                    { 20, null, 82, null },
                    { 44, null, 148, null },
                    { 21, null, 134, null },
                    { 23, null, 148, null },
                    { 42, null, 96, null },
                    { 41, null, 117, null },
                    { 40, null, 89, null },
                    { 39, null, 68, null },
                    { 38, null, 75, null },
                    { 37, null, 78, null },
                    { 36, null, 89, null },
                    { 89, null, 115, null },
                    { 34, null, 134, null },
                    { 33, null, 95, null },
                    { 32, null, 131, null },
                    { 31, null, 45, null },
                    { 30, null, 34, null },
                    { 29, null, 49, null },
                    { 28, null, 56, null },
                    { 27, null, 98, null },
                    { 26, null, 116, null },
                    { 25, null, 92, null },
                    { 24, null, 2, null },
                    { 22, null, 68, null },
                    { 90, null, 99, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Railways",
                keyColumn: "ID",
                keyValue: 90);
        }
    }
}
