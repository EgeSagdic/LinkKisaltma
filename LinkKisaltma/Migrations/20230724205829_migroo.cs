using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinkKisaltma.Migrations
{
    /// <inheritdoc />
    public partial class migroo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBLLink",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UzunLink = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    KisaLink = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfClicks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLLink", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBLLink");
        }
    }
}
