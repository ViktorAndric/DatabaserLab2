﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaserLab2.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumnToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Books");
        }
    }
}
