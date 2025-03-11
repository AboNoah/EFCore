using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class defualtvalueKeyCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "compiost_Book",
                table: "Books");

            migrationBuilder.EnsureSchema(
                name: "Blogging");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "Post",
                newSchema: "Blogging");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Books",
                newSchema: "Blogging");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "Blogs",
                newSchema: "Blogging");

            migrationBuilder.AlterColumn<int>(
                name: "BookKey",
                schema: "Blogging",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                schema: "Blogging",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Blogging",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "rating",
                schema: "Blogging",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 2);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                schema: "Blogging",
                table: "Books",
                column: "BookKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                schema: "Blogging",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "rating",
                schema: "Blogging",
                table: "Blogs");

            migrationBuilder.RenameTable(
                name: "Post",
                schema: "Blogging",
                newName: "Post");

            migrationBuilder.RenameTable(
                name: "Books",
                schema: "Blogging",
                newName: "Books");

            migrationBuilder.RenameTable(
                name: "Blogs",
                schema: "Blogging",
                newName: "Blogs");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Books",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Books",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "BookKey",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "compiost_Book",
                table: "Books",
                columns: new[] { "Name", "Author" });
        }
    }
}
