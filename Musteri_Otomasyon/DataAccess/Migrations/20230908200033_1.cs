using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musteris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "varchar(25)", nullable: false),
                    Soyadi = table.Column<string>(type: "varchar(25)", nullable: false),
                    E_mail = table.Column<string>(type: "varchar(75)", nullable: false),
                    Telefon = table.Column<int>(type: "number(11)", nullable: false),
                    Doğum_Tarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Meslegi = table.Column<string>(type: "varchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteris", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musteris");
        }
    }
}
