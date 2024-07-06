using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace denemproje.Migrations
{
    public partial class paket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Randevus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdiSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CepNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RandevuSaati = table.Column<DateTime>(type: "datetime2", nullable: true),
                    YapilanIslem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevus", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Randevus");
        }
    }
}
