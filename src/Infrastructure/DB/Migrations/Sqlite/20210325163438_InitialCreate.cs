using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ECommerceSample.Infrastructure.DB.Migrations.Sqlite
{
#pragma warning disable CS1591 // 公開されている型またはメンバーの XML コメントがありません
    public partial class InitialCreate : Migration
#pragma warning restore CS1591 // 公開されている型またはメンバーの XML コメントがありません
    {
#pragma warning disable CS1591 // 公開されている型またはメンバーの XML コメントがありません
        protected override void Up(MigrationBuilder migrationBuilder)
#pragma warning restore CS1591 // 公開されている型またはメンバーの XML コメントがありません
        {
            migrationBuilder.CreateTable(
                name: "AdminAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountName = table.Column<string>(type: "TEXT", nullable: false),
                    Enabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdminPermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PermissionName = table.Column<string>(type: "TEXT", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminPermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdminRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleName = table.Column<string>(type: "TEXT", nullable: false),
                    Enabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdminAccountRoles",
                columns: table => new
                {
                    AdminAccountId = table.Column<int>(type: "INTEGER", nullable: false),
                    AdminRoleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminAccountRoles", x => new { x.AdminAccountId, x.AdminRoleId });
                    table.ForeignKey(
                        name: "FK_AdminAccountRoles_AdminAccounts_AdminAccountId",
                        column: x => x.AdminAccountId,
                        principalTable: "AdminAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminAccountRoles_AdminRoles_AdminRoleId",
                        column: x => x.AdminRoleId,
                        principalTable: "AdminRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminRolePermissions",
                columns: table => new
                {
                    AdminRoleId = table.Column<int>(type: "INTEGER", nullable: false),
                    AdminPermissionId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminRolePermissions", x => new { x.AdminRoleId, x.AdminPermissionId });
                    table.ForeignKey(
                        name: "FK_AdminRolePermissions_AdminPermissions_AdminPermissionId",
                        column: x => x.AdminPermissionId,
                        principalTable: "AdminPermissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminRolePermissions_AdminRoles_AdminRoleId",
                        column: x => x.AdminRoleId,
                        principalTable: "AdminRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminAccountRoles_AdminRoleId",
                table: "AdminAccountRoles",
                column: "AdminRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminPermissions_PermissionName",
                table: "AdminPermissions",
                column: "PermissionName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdminRolePermissions_AdminPermissionId",
                table: "AdminRolePermissions",
                column: "AdminPermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminRoles_RoleName",
                table: "AdminRoles",
                column: "RoleName",
                unique: true);
        }

#pragma warning disable CS1591 // 公開されている型またはメンバーの XML コメントがありません
        protected override void Down(MigrationBuilder migrationBuilder)
#pragma warning restore CS1591 // 公開されている型またはメンバーの XML コメントがありません
        {
            migrationBuilder.DropTable(
                name: "AdminAccountRoles");

            migrationBuilder.DropTable(
                name: "AdminRolePermissions");

            migrationBuilder.DropTable(
                name: "AdminAccounts");

            migrationBuilder.DropTable(
                name: "AdminPermissions");

            migrationBuilder.DropTable(
                name: "AdminRoles");
        }
    }
}
