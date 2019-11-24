using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar", maxLength: 50, nullable: true),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: true),
                    CarNumber = table.Column<string>(type: "nvarchar", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
