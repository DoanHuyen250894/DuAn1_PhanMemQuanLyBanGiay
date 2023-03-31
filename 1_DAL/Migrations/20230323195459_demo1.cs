using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL.Migrations
{
    public partial class demo1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiaChi",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "GioiTinh",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "Ho",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "NgaySinh",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "QuocGia",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "Ten",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "ThanhPho",
                table: "KhachHang");

            migrationBuilder.RenameColumn(
                name: "TenDem",
                table: "KhachHang",
                newName: "HovaTen");

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "KhachHang",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HovaTen",
                table: "KhachHang",
                newName: "TenDem");

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "KhachHang",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiaChi",
                table: "KhachHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GioiTinh",
                table: "KhachHang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ho",
                table: "KhachHang",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySinh",
                table: "KhachHang",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "QuocGia",
                table: "KhachHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ten",
                table: "KhachHang",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ThanhPho",
                table: "KhachHang",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
