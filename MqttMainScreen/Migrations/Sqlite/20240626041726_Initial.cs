using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MqttMainScreen.Migrations.Sqlite
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MqttClients",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DeviceName = table.Column<string>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SubscribedTopics = table.Column<string>(type: "TEXT", nullable: false),
                    LastAccessed = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false),
                    KeepAlive = table.Column<int>(type: "INTEGER", nullable: false),
                    IpAddress = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MqttClients", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                table: "MqttClients",
                columns: new[] { "ClientId", "Created", "DeviceName", "IpAddress", "KeepAlive", "LastAccessed", "Status", "SubscribedTopics" },
                values: new object[,]
                {
                    { new Guid("16690cdd-c359-4487-b7ac-70bf4e7254df"), new DateTime(2023, 6, 11, 11, 20, 0, 0, DateTimeKind.Unspecified), "Device Beta", "192.168.1.2", 60, new DateTime(2024, 6, 23, 10, 15, 0, 0, DateTimeKind.Unspecified), false, "[\"topic3\",\"topic4\"]" },
                    { new Guid("4e38b1fa-a377-4eea-b9c2-09e98a11276e"), new DateTime(2023, 5, 12, 14, 30, 0, 0, DateTimeKind.Unspecified), "Device Alpha", "192.168.1.1", 60, new DateTime(2024, 6, 24, 9, 45, 0, 0, DateTimeKind.Unspecified), true, "[\"topic1\",\"topic2\"]" },
                    { new Guid("8c538f6c-155c-4103-95d6-644044026f74"), new DateTime(2023, 7, 21, 9, 45, 0, 0, DateTimeKind.Unspecified), "Device Gamma", "192.168.1.3", 60, new DateTime(2024, 6, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), true, "[\"topic5\",\"topic6\"]" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MqttClients");
        }
    }
}
