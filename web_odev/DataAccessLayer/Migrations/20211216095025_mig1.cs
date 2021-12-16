using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    AracID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka_id = table.Column<int>(type: "int", nullable: false),
                    Model_id = table.Column<int>(type: "int", nullable: false),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Donanim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Motor_hacmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yakit_tipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vites_tipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracBg = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.AracID);
                });

            migrationBuilder.CreateTable(
                name: "Gallerys",
                columns: table => new
                {
                    GalleryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GalleryAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GalleryResim = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gallerys", x => x.GalleryID);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Opsiyon_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka_id = table.Column<int>(type: "int", nullable: false),
                    Model_id = table.Column<int>(type: "int", nullable: false),
                    Opsiyon_Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opsiyon_Fiyati = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Opsiyon_ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kullanici_AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plaka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kullanici_Tarih = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.KullaniciID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Gallerys");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
