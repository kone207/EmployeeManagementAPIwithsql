using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressStreet",
                table: "EmployeeTable",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Street = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Surbub = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Street);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTable_AddressStreet",
                table: "EmployeeTable",
                column: "AddressStreet");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTable_Address_AddressStreet",
                table: "EmployeeTable",
                column: "AddressStreet",
                principalTable: "Address",
                principalColumn: "Street",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTable_Address_AddressStreet",
                table: "EmployeeTable");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTable_AddressStreet",
                table: "EmployeeTable");

            migrationBuilder.DropColumn(
                name: "AddressStreet",
                table: "EmployeeTable");
        }
    }
}
