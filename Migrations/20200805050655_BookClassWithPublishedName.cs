using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloWorldMVCWebApp.Migrations
{
    public partial class BookClassWithPublishedName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            MigrationBuilder.AddColumn<string>(
                name: "PublisheTitle",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            MigrationBuilder.DropColumn<string>(
                name: "PublisheTitle",
                table: "Books",
                nullable: true);
        }
    }
}
