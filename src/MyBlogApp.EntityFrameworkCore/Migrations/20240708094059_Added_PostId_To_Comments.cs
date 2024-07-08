using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlogApp.Migrations
{
    /// <inheritdoc />
    public partial class Added_PostId_To_Comments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PostId",
                table: "AppComments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_AppComments_PostId",
                table: "AppComments",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppComments_AppPosts_PostId",
                table: "AppComments",
                column: "PostId",
                principalTable: "AppPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppComments_AppPosts_PostId",
                table: "AppComments");

            migrationBuilder.DropIndex(
                name: "IX_AppComments_PostId",
                table: "AppComments");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "AppComments");
        }
    }
}
