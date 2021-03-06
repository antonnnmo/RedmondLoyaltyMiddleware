﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RedmondLoyaltyMiddleware.Migrations
{
    public partial class PromocodeAttemptStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "StatusId",
                table: "PromocodeUseAttempts",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "PromocodeUseAttempts");
        }
    }
}
