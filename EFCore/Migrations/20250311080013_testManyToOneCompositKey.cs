using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class testManyToOneCompositKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyTest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestId = table.Column<int>(type: "int", nullable: false),
                    TestName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTest", x => x.Id);
                    table.UniqueConstraint("AK_CompanyTest_TestId_TestName", x => new { x.TestId, x.TestName });
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestId = table.Column<int>(type: "int", nullable: false),
                    TestName = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeTests_CompanyTest_TestId_TestName",
                        columns: x => new { x.TestId, x.TestName },
                        principalTable: "CompanyTest",
                        principalColumns: new[] { "TestId", "TestName" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTests_TestId_TestName",
                table: "EmployeeTests",
                columns: new[] { "TestId", "TestName" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTests");

            migrationBuilder.DropTable(
                name: "CompanyTest");
        }
    }
}
