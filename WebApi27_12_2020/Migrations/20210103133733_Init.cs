using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi27_12_2020.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Color = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "ID", "Age", "Color", "Name", "Photo" },
                values: new object[] { 1, 5, 0, "Tom", null });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "ID", "Age", "Color", "Name", "Photo" },
                values: new object[] { 2, 24, 3, "Barsik", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");
        }
    }
}
