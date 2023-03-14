using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL.Migrations
{
    public partial class dnb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "Size",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "NSX",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "NCC",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "MauSac",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "LoaiSanPham",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "HinhThucThanhToan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "ChucVu",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ma",
                table: "Size");

            migrationBuilder.DropColumn(
                name: "Ma",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "Ma",
                table: "NSX");

            migrationBuilder.DropColumn(
                name: "Ma",
                table: "NCC");

            migrationBuilder.DropColumn(
                name: "Ma",
                table: "MauSac");

            migrationBuilder.DropColumn(
                name: "Ma",
                table: "LoaiSanPham");

            migrationBuilder.DropColumn(
                name: "Ma",
                table: "HinhThucThanhToan");

            migrationBuilder.DropColumn(
                name: "Ma",
                table: "ChucVu");
        }
    }
}
