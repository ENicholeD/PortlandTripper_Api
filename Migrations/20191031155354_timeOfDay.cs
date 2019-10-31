using Microsoft.EntityFrameworkCore.Migrations;

namespace PortlandTripperApi.Migrations
{
    public partial class timeOfDay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TimeOfDay",
                table: "TripAdvisor",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TripAdvisor",
                keyColumn: "TripAdvisorId",
                keyValue: 1,
                column: "TimeOfDay",
                value: "Morning");

            migrationBuilder.UpdateData(
                table: "TripAdvisor",
                keyColumn: "TripAdvisorId",
                keyValue: 2,
                column: "TimeOfDay",
                value: "Morning");

            migrationBuilder.UpdateData(
                table: "TripAdvisor",
                keyColumn: "TripAdvisorId",
                keyValue: 3,
                column: "TimeOfDay",
                value: "Afternoon");

            migrationBuilder.UpdateData(
                table: "TripAdvisor",
                keyColumn: "TripAdvisorId",
                keyValue: 4,
                column: "TimeOfDay",
                value: "Afternoon");

            migrationBuilder.UpdateData(
                table: "TripAdvisor",
                keyColumn: "TripAdvisorId",
                keyValue: 5,
                column: "TimeOfDay",
                value: "Evening");

            migrationBuilder.UpdateData(
                table: "TripAdvisor",
                keyColumn: "TripAdvisorId",
                keyValue: 6,
                column: "TimeOfDay",
                value: "Evening");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeOfDay",
                table: "TripAdvisor");
        }
    }
}
