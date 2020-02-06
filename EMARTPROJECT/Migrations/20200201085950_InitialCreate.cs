using Microsoft.EntityFrameworkCore.Migrations;

namespace EMARTPROJECT.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    s_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    s_username = table.Column<string>(nullable: true),
                    s_pwd = table.Column<string>(nullable: true),
                    GSTIN = table.Column<int>(nullable: false),
                    s_email_id = table.Column<string>(nullable: true),
                    sbank_accno = table.Column<long>(nullable: false),
                    photopath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.s_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}
