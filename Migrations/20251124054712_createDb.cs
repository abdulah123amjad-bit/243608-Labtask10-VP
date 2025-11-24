using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _243506_Labtask10_VP.Migrations
{
    /// <inheritdoc />
    public partial class createDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fathername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cnic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salary = table.Column<int>(type: "int", nullable: false),
                    department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hiredate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee");
        }
    }
}
