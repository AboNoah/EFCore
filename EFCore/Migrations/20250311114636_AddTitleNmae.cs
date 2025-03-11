using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddTitleNmae : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostTag_Tag_TagsId",
                table: "PostTag");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTag_TestPosts_PostsId",
                table: "PostTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTag",
                table: "PostTag");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "PostTag",
                newName: "PostTags");

            migrationBuilder.RenameIndex(
                name: "IX_PostTag_PostsId",
                table: "PostTags",
                newName: "IX_PostTags_PostsId");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "TestPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTags",
                table: "PostTags",
                columns: new[] { "TagsId", "PostsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PostTags_Tags_TagsId",
                table: "PostTags",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTags_TestPosts_PostsId",
                table: "PostTags",
                column: "PostsId",
                principalTable: "TestPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostTags_Tags_TagsId",
                table: "PostTags");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTags_TestPosts_PostsId",
                table: "PostTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTags",
                table: "PostTags");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "TestPosts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Tags");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.RenameTable(
                name: "PostTags",
                newName: "PostTag");

            migrationBuilder.RenameIndex(
                name: "IX_PostTags_PostsId",
                table: "PostTag",
                newName: "IX_PostTag_PostsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTag",
                table: "PostTag",
                columns: new[] { "TagsId", "PostsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PostTag_Tag_TagsId",
                table: "PostTag",
                column: "TagsId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTag_TestPosts_PostsId",
                table: "PostTag",
                column: "PostsId",
                principalTable: "TestPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
