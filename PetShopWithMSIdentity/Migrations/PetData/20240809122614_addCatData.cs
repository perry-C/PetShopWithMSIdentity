using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopWithMSIdentity.Migrations.PetData
{
    /// <inheritdoc />
    public partial class addCatData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Breed = table.Column<string>(type: "varchar(100)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Specie = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    DOB = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    SoundType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sound = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cat");
        }
    }
}
