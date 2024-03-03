using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portfolio.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "details", "email", "title" },
                values: new object[] { 1, "I'm a CS undergrad who finds joy in coding. I like keeping things simple, turning complex problems into clean lines of logic. In the world of bits and bytes, I'm on a mission to make technology elegant and efficient.\r\n\r\nWhen I'm not immersed in code, I'm immersed in books. I love the simplicity of a well-crafted sentence as much as I love a clean piece of code. In a nutshell, a minimalist navigating the worlds of logic and language.", "moon2007093@stud.kuet.ac.bd", "CS Undergrad, Minimalist, Love to read" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");
        }
    }
}
