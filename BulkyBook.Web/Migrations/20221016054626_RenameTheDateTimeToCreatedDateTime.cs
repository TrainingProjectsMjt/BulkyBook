using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBook.Web.Migrations
{
    /// <inheritdoc />
    public partial class RenameTheDateTimeToCreatedDateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Categories",
                newName: "CreatedDateTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDateTime",
                table: "Categories",
                newName: "DateTime");
        }
    }
}
