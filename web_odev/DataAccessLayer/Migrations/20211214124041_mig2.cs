using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AracID",
                table: "Options",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Options_AracID",
                table: "Options",
                column: "AracID");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Cars_AracID",
                table: "Options",
                column: "AracID",
                principalTable: "Cars",
                principalColumn: "AracID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Cars_AracID",
                table: "Options");

            migrationBuilder.DropIndex(
                name: "IX_Options_AracID",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "AracID",
                table: "Options");
        }
    }
}
