using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Telefon = table.Column<decimal>(type: "decimal(18,2)", maxLength: 11, nullable: false),
                    E_mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kullanici_Adi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    rol = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
