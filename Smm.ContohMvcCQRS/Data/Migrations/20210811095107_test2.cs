using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Smm.ContohMvcCQRS.Data.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agama",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgamaKeterangan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agama", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataKonsumen",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoKTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TanggalLahir = table.Column<DateTime>(type: "datetime", nullable: false),
                    JenisKelamin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nama_NamaDepan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Nama_NamaBelakang = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    NamaBPKB_NamaDepan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    NamaBPKB_NamaBelakang = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    AlamatTinggal_Jalan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatTinggal_Kelurahan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatTinggal_Kecamatan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatTinggal_Kota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatTinggal_Propinsi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatTinggal_KodePos = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    AlamatTinggal_NoTelepon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatTinggal_NoFax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatTinggal_NoHandphone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatKirim_Jalan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatKirim_Kelurahan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatKirim_Kecamatan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatKirim_Kota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatKirim_Propinsi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatKirim_KodePos = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    AlamatKirim_NoTelepon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatKirim_NoFax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatKirim_NoHandphone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetUtcDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKonsumen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JenisKelamin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JenisKelaminKeterangan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JenisKelamin", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agama");

            migrationBuilder.DropTable(
                name: "DataKonsumen");

            migrationBuilder.DropTable(
                name: "JenisKelamin");
        }
    }
}
