using Microsoft.EntityFrameworkCore.Migrations;

namespace KGSHOP.Data.Migrations
{
    public partial class addAppointment2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PSA_Customers_AppointmentId",
                table: "PSA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "CustomerBuys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerBuys",
                table: "CustomerBuys",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PSA_CustomerBuys_AppointmentId",
                table: "PSA",
                column: "AppointmentId",
                principalTable: "CustomerBuys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PSA_CustomerBuys_AppointmentId",
                table: "PSA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerBuys",
                table: "CustomerBuys");

            migrationBuilder.RenameTable(
                name: "CustomerBuys",
                newName: "Customers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PSA_Customers_AppointmentId",
                table: "PSA",
                column: "AppointmentId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
