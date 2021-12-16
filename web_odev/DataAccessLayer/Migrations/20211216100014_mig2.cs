using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AracID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AracID",
                table: "Options",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AracID",
                table: "Gallerys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_AracID",
                table: "Users",
                column: "AracID");

            migrationBuilder.CreateIndex(
                name: "IX_Options_AracID",
                table: "Options",
                column: "AracID");

            migrationBuilder.CreateIndex(
                name: "IX_Gallerys_AracID",
                table: "Gallerys",
                column: "AracID");

            migrationBuilder.AddForeignKey(
                name: "FK_Gallerys_Cars_AracID",
                table: "Gallerys",
                column: "AracID",
                principalTable: "Cars",
                principalColumn: "AracID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Cars_AracID",
                table: "Options",
                column: "AracID",
                principalTable: "Cars",
                principalColumn: "AracID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cars_AracID",
                table: "Users",
                column: "AracID",
                principalTable: "Cars",
                principalColumn: "AracID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gallerys_Cars_AracID",
                table: "Gallerys");

            migrationBuilder.DropForeignKey(
                name: "FK_Options_Cars_AracID",
                table: "Options");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cars_AracID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AracID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Options_AracID",
                table: "Options");

            migrationBuilder.DropIndex(
                name: "IX_Gallerys_AracID",
                table: "Gallerys");

            migrationBuilder.DropColumn(
                name: "AracID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AracID",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "AracID",
                table: "Gallerys");
        }
    }
}
