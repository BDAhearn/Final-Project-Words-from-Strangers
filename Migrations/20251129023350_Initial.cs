using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Words_from_Strangers.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "DateAdded", "Location", "MessageText", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 28, 21, 33, 49, 969, DateTimeKind.Local).AddTicks(5181), "Earth", "Hello World", "BDAhearn" },
                    { 2, new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antartica", "What's up everyone", null },
                    { 3, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hi, I'm Dave.", "Dave" },
                    { 4, new DateTime(2020, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "France", "Honhonhon qui qui", null },
                    { 5, new DateTime(2222, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mars", "Why am I on mars?", "Bek" },
                    { 6, new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lordran", "I can't wait to start this bonfire", null },
                    { 7, new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Londo", "I have not seen the sun for a long time. Perhaps I could do with a change... ", null },
                    { 8, new DateTime(2012, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hey guys, I think Im lost", null },
                    { 9, new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Universe B", "It's great an Earth day is 25 hours long", "Asher" },
                    { 10, new DateTime(2000, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Who am I? Where am I?", null },
                    { 11, new DateTime(2011, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "All your base are belong to us", "Aila" },
                    { 12, new DateTime(2014, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Have you really been far even as decided to use even go want to do look more like?", "Claire" },
                    { 13, new DateTime(2018, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canada", "Where did the geese go", null },
                    { 14, new DateTime(2009, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mirror Earth", "The moon is really cool", "Yue" },
                    { 15, new DateTime(2020, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slightly Better Florida", "Freedom", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
