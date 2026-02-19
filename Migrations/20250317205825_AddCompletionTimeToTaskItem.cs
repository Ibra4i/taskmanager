using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace taskManager.Migrations
{
    public partial class AddCompletionTimeToTaskItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CompletionTime",
                table: "Tasks",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletionTime",
                table: "Tasks");
        }
    }
}
