using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cars_AracID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AracID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AracID",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AracID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_AracID",
                table: "Users",
                column: "AracID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cars_AracID",
                table: "Users",
                column: "AracID",
                principalTable: "Cars",
                principalColumn: "AracID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
