using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class hieus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHUCVU",
                columns: table => new
                {
                    MACHUCVU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENCHUCVU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MOTACHUCVU = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHUCVU__9FA9FD6AF8D6D99D", x => x.MACHUCVU);
                });

            migrationBuilder.CreateTable(
                name: "GIAOCA",
                columns: table => new
                {
                    MAGIAOCA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENCA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    THOIGIANBATDAU = table.Column<TimeSpan>(type: "time", nullable: true),
                    THOIGIANKETTHUC = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GIAOCA__7D3545CC4C51D60B", x => x.MAGIAOCA);
                });

            migrationBuilder.CreateTable(
                name: "GIAY",
                columns: table => new
                {
                    MAGIAY = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENGIAY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GIAY__0C880C58F246FA74", x => x.MAGIAY);
                });

            migrationBuilder.CreateTable(
                name: "HINHTHUCTHANHTOAN",
                columns: table => new
                {
                    MAHINHTHUCTHANHTOAN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENHINHTHUC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HINHTHUC__C3B2561F2C27251D", x => x.MAHINHTHUCTHANHTOAN);
                });

            migrationBuilder.CreateTable(
                name: "KHACHHANG",
                columns: table => new
                {
                    MAKHACHHANG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENKHACHHANG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SDT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DIEMKHACHHANG = table.Column<int>(type: "int", nullable: true),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KHACHHAN__30035C2F2F2CC38D", x => x.MAKHACHHANG);
                });

            migrationBuilder.CreateTable(
                name: "TAIKHOAN",
                columns: table => new
                {
                    MATAIKHOAN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USERNAME = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    PASWORD = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    HOVATEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GIOITINH = table.Column<bool>(type: "bit", nullable: true),
                    SODIENTHOAI = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DIACHI = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NGAYSINH = table.Column<DateTime>(type: "date", nullable: true),
                    NGAYTAOTAIKHOAN = table.Column<DateTime>(type: "date", nullable: true),
                    MACHUCVU = table.Column<int>(type: "int", nullable: false),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TAIKHOAN__2ED8B51783411548", x => x.MATAIKHOAN);
                    table.ForeignKey(
                        name: "FK__TAIKHOAN__MACHUC__6A30C649",
                        column: x => x.MACHUCVU,
                        principalTable: "CHUCVU",
                        principalColumn: "MACHUCVU");
                });

            migrationBuilder.CreateTable(
                name: "BANGLUONG",
                columns: table => new
                {
                    MALUONG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    THANGLAM = table.Column<DateTime>(type: "date", nullable: true),
                    LUONGCOBAN = table.Column<double>(type: "float", nullable: true),
                    TIENTHUONG = table.Column<double>(type: "float", nullable: true),
                    TIENKHAUTRU = table.Column<double>(type: "float", nullable: true),
                    TONGTHUNHAP = table.Column<double>(type: "float", nullable: true),
                    MATAIKHOAN = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BANGLUON__D9BA4D005F975731", x => x.MALUONG);
                    table.ForeignKey(
                        name: "FK__BANGLUONG__MATAI__5629CD9C",
                        column: x => x.MATAIKHOAN,
                        principalTable: "TAIKHOAN",
                        principalColumn: "MATAIKHOAN");
                });

            migrationBuilder.CreateTable(
                name: "CHATLIEU",
                columns: table => new
                {
                    MACHATLIEU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENCHATLIEU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: true),
                    MATAIKHOAN = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHATLIEU__80F939F89D630D0C", x => x.MACHATLIEU);
                    table.ForeignKey(
                        name: "FK__CHATLIEU__MATAIK__571DF1D5",
                        column: x => x.MATAIKHOAN,
                        principalTable: "TAIKHOAN",
                        principalColumn: "MATAIKHOAN");
                });

            migrationBuilder.CreateTable(
                name: "GIAOCANHANVIEN",
                columns: table => new
                {
                    MAGIAOCANHANVIEN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MATAIKHOAN = table.Column<int>(type: "int", nullable: true),
                    MAGIAOCA = table.Column<int>(type: "int", nullable: true),
                    NGAYGIAOCA = table.Column<DateTime>(type: "date", nullable: true),
                    THOIGIANDEN = table.Column<TimeSpan>(type: "time", nullable: true),
                    THOIGIANVE = table.Column<TimeSpan>(type: "time", nullable: true),
                    SANPHAMDAGIAO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TIENDAGIAO = table.Column<double>(type: "float", nullable: true),
                    GHICHU = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    TRANGTHAI = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GIAOCANH__B0F1BCFD2684AAE1", x => x.MAGIAOCANHANVIEN);
                    table.ForeignKey(
                        name: "FK__GIAOCANHA__MAGIA__5812160E",
                        column: x => x.MAGIAOCA,
                        principalTable: "GIAOCA",
                        principalColumn: "MAGIAOCA");
                    table.ForeignKey(
                        name: "FK__GIAOCANHA__MATAI__59063A47",
                        column: x => x.MATAIKHOAN,
                        principalTable: "TAIKHOAN",
                        principalColumn: "MATAIKHOAN");
                });

            migrationBuilder.CreateTable(
                name: "KICHCO",
                columns: table => new
                {
                    MAKICHCO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENKICHCO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: true),
                    MATAIKHOAN = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KICHCO__7EDFFF29EF6EA5B0", x => x.MAKICHCO);
                    table.ForeignKey(
                        name: "FK__KICHCO__MATAIKHO__6754599E",
                        column: x => x.MATAIKHOAN,
                        principalTable: "TAIKHOAN",
                        principalColumn: "MATAIKHOAN");
                });

            migrationBuilder.CreateTable(
                name: "KIEUDANG",
                columns: table => new
                {
                    MAKIEUDANG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENKIEUDANG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: true),
                    MATAIKHOAN = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KIEUDANG__877F27F20BB7C69B", x => x.MAKIEUDANG);
                    table.ForeignKey(
                        name: "FK__KIEUDANG__MATAIK__68487DD7",
                        column: x => x.MATAIKHOAN,
                        principalTable: "TAIKHOAN",
                        principalColumn: "MATAIKHOAN");
                });

            migrationBuilder.CreateTable(
                name: "MAUSAC",
                columns: table => new
                {
                    MAMAUSAC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENMAUSAC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: true),
                    MATAIKHOAN = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MAUSAC__99E7A68FD4EBC4CB", x => x.MAMAUSAC);
                    table.ForeignKey(
                        name: "FK__MAUSAC__MATAIKHO__693CA210",
                        column: x => x.MATAIKHOAN,
                        principalTable: "TAIKHOAN",
                        principalColumn: "MATAIKHOAN");
                });

            migrationBuilder.CreateTable(
                name: "THUONGHIEU",
                columns: table => new
                {
                    MATHUONGHIEU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENTHUONGHIEU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SDT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MATAIKHOAN = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__THUONGHI__B319F638CB3C0B76", x => x.MATHUONGHIEU);
                    table.ForeignKey(
                        name: "FK__THUONGHIE__MATAI__6B24EA82",
                        column: x => x.MATAIKHOAN,
                        principalTable: "TAIKHOAN",
                        principalColumn: "MATAIKHOAN");
                });

            migrationBuilder.CreateTable(
                name: "UUDAI",
                columns: table => new
                {
                    MAUUDAI = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENUUDAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NGAYBATDAU = table.Column<DateTime>(type: "datetime", nullable: true),
                    NGAYKETTHUC = table.Column<DateTime>(type: "datetime", nullable: true),
                    PHANTRAM = table.Column<int>(type: "int", nullable: true),
                    TRANGTHAI = table.Column<int>(type: "int", nullable: true),
                    SOLUONG = table.Column<int>(type: "int", nullable: true),
                    MATAIKHOAN = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UUDAI__3F58B4FD7443E6FD", x => x.MAUUDAI);
                    table.ForeignKey(
                        name: "FK__UUDAI__MATAIKHOA__6C190EBB",
                        column: x => x.MATAIKHOAN,
                        principalTable: "TAIKHOAN",
                        principalColumn: "MATAIKHOAN");
                });

            migrationBuilder.CreateTable(
                name: "GIAYCHITIET",
                columns: table => new
                {
                    MAGIAYCHITIET = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MAGIAY = table.Column<int>(type: "int", nullable: true),
                    MACHATLIEU = table.Column<int>(type: "int", nullable: true),
                    MAMAUSAC = table.Column<int>(type: "int", nullable: true),
                    MAKICHCO = table.Column<int>(type: "int", nullable: true),
                    MATHUONGHIEU = table.Column<int>(type: "int", nullable: true),
                    MAKIEUDANG = table.Column<int>(type: "int", nullable: true),
                    SOLUONGCON = table.Column<int>(type: "int", nullable: true),
                    NGAYTAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    NGAYSUA = table.Column<DateTime>(type: "datetime", nullable: true),
                    NGUOITAO = table.Column<int>(type: "int", nullable: true),
                    NGUOISUA = table.Column<int>(type: "int", nullable: true),
                    GIA = table.Column<double>(type: "float", nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GIAYCHIT__196AD7039127283A", x => x.MAGIAYCHITIET);
                    table.ForeignKey(
                        name: "FK__GIAYCHITI__MACHA__59FA5E80",
                        column: x => x.MACHATLIEU,
                        principalTable: "CHATLIEU",
                        principalColumn: "MACHATLIEU");
                    table.ForeignKey(
                        name: "FK__GIAYCHITI__MAGIA__5AEE82B9",
                        column: x => x.MAGIAY,
                        principalTable: "GIAY",
                        principalColumn: "MAGIAY");
                    table.ForeignKey(
                        name: "FK__GIAYCHITI__MAKIC__5BE2A6F2",
                        column: x => x.MAKICHCO,
                        principalTable: "KICHCO",
                        principalColumn: "MAKICHCO");
                    table.ForeignKey(
                        name: "FK__GIAYCHITI__MAKIE__5CD6CB2B",
                        column: x => x.MAKIEUDANG,
                        principalTable: "KIEUDANG",
                        principalColumn: "MAKIEUDANG");
                    table.ForeignKey(
                        name: "FK__GIAYCHITI__MAMAU__5DCAEF64",
                        column: x => x.MAMAUSAC,
                        principalTable: "MAUSAC",
                        principalColumn: "MAMAUSAC");
                    table.ForeignKey(
                        name: "FK__GIAYCHITI__MATHU__5EBF139D",
                        column: x => x.MATHUONGHIEU,
                        principalTable: "THUONGHIEU",
                        principalColumn: "MATHUONGHIEU");
                    table.ForeignKey(
                        name: "FK__GIAYCHITI__NGUOI__5FB337D6",
                        column: x => x.NGUOITAO,
                        principalTable: "TAIKHOAN",
                        principalColumn: "MATAIKHOAN");
                    table.ForeignKey(
                        name: "FK__GIAYCHITI__NGUOI__60A75C0F",
                        column: x => x.NGUOISUA,
                        principalTable: "TAIKHOAN",
                        principalColumn: "MATAIKHOAN");
                });

            migrationBuilder.CreateTable(
                name: "HOADON",
                columns: table => new
                {
                    MAHOADON = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MATAIKHOAN = table.Column<int>(type: "int", nullable: true),
                    MAUUDAI = table.Column<int>(type: "int", nullable: true),
                    MAKHACHHANG = table.Column<int>(type: "int", nullable: true),
                    MAHINHTHUCTHANHTOAN = table.Column<int>(type: "int", nullable: true),
                    TENCUAHANG = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DIACHICUAHANG = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SDTCUAHANG = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    EMAILCUAHANG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NGAYTAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    TONGTIEN = table.Column<double>(type: "float", nullable: true),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: true),
                    GHICHU = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HOADON__A4999DF5068B15D4", x => x.MAHOADON);
                    table.ForeignKey(
                        name: "FK__HOADON__MAHINHTH__619B8048",
                        column: x => x.MAHINHTHUCTHANHTOAN,
                        principalTable: "HINHTHUCTHANHTOAN",
                        principalColumn: "MAHINHTHUCTHANHTOAN");
                    table.ForeignKey(
                        name: "FK__HOADON__MAKHACHH__628FA481",
                        column: x => x.MAKHACHHANG,
                        principalTable: "KHACHHANG",
                        principalColumn: "MAKHACHHANG");
                    table.ForeignKey(
                        name: "FK__HOADON__MATAIKHO__6383C8BA",
                        column: x => x.MATAIKHOAN,
                        principalTable: "TAIKHOAN",
                        principalColumn: "MATAIKHOAN");
                    table.ForeignKey(
                        name: "FK__HOADON__MAUUDAI__6477ECF3",
                        column: x => x.MAUUDAI,
                        principalTable: "UUDAI",
                        principalColumn: "MAUUDAI");
                });

            migrationBuilder.CreateTable(
                name: "HOADONCHITIET",
                columns: table => new
                {
                    MAHOADONCHITIET = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MAGIAYCHITIET = table.Column<int>(type: "int", nullable: true),
                    MAHOADON = table.Column<int>(type: "int", nullable: true),
                    SOLUONGMUA = table.Column<int>(type: "int", nullable: true),
                    GIA = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HOADONCH__EF957FF0F67F56CB", x => x.MAHOADONCHITIET);
                    table.ForeignKey(
                        name: "FK__HOADONCHI__MAGIA__656C112C",
                        column: x => x.MAGIAYCHITIET,
                        principalTable: "GIAYCHITIET",
                        principalColumn: "MAGIAYCHITIET");
                    table.ForeignKey(
                        name: "FK__HOADONCHI__MAHOA__66603565",
                        column: x => x.MAHOADON,
                        principalTable: "HOADON",
                        principalColumn: "MAHOADON");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BANGLUONG_MATAIKHOAN",
                table: "BANGLUONG",
                column: "MATAIKHOAN");

            migrationBuilder.CreateIndex(
                name: "IX_CHATLIEU_MATAIKHOAN",
                table: "CHATLIEU",
                column: "MATAIKHOAN");

            migrationBuilder.CreateIndex(
                name: "IX_GIAOCANHANVIEN_MAGIAOCA",
                table: "GIAOCANHANVIEN",
                column: "MAGIAOCA");

            migrationBuilder.CreateIndex(
                name: "IX_GIAOCANHANVIEN_MATAIKHOAN",
                table: "GIAOCANHANVIEN",
                column: "MATAIKHOAN");

            migrationBuilder.CreateIndex(
                name: "IX_GIAYCHITIET_MACHATLIEU",
                table: "GIAYCHITIET",
                column: "MACHATLIEU");

            migrationBuilder.CreateIndex(
                name: "IX_GIAYCHITIET_MAGIAY",
                table: "GIAYCHITIET",
                column: "MAGIAY");

            migrationBuilder.CreateIndex(
                name: "IX_GIAYCHITIET_MAKICHCO",
                table: "GIAYCHITIET",
                column: "MAKICHCO");

            migrationBuilder.CreateIndex(
                name: "IX_GIAYCHITIET_MAKIEUDANG",
                table: "GIAYCHITIET",
                column: "MAKIEUDANG");

            migrationBuilder.CreateIndex(
                name: "IX_GIAYCHITIET_MAMAUSAC",
                table: "GIAYCHITIET",
                column: "MAMAUSAC");

            migrationBuilder.CreateIndex(
                name: "IX_GIAYCHITIET_MATHUONGHIEU",
                table: "GIAYCHITIET",
                column: "MATHUONGHIEU");

            migrationBuilder.CreateIndex(
                name: "IX_GIAYCHITIET_NGUOISUA",
                table: "GIAYCHITIET",
                column: "NGUOISUA");

            migrationBuilder.CreateIndex(
                name: "IX_GIAYCHITIET_NGUOITAO",
                table: "GIAYCHITIET",
                column: "NGUOITAO");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_MAHINHTHUCTHANHTOAN",
                table: "HOADON",
                column: "MAHINHTHUCTHANHTOAN");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_MAKHACHHANG",
                table: "HOADON",
                column: "MAKHACHHANG");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_MATAIKHOAN",
                table: "HOADON",
                column: "MATAIKHOAN");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_MAUUDAI",
                table: "HOADON",
                column: "MAUUDAI");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONCHITIET_MAGIAYCHITIET",
                table: "HOADONCHITIET",
                column: "MAGIAYCHITIET");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONCHITIET_MAHOADON",
                table: "HOADONCHITIET",
                column: "MAHOADON");

            migrationBuilder.CreateIndex(
                name: "IX_KICHCO_MATAIKHOAN",
                table: "KICHCO",
                column: "MATAIKHOAN");

            migrationBuilder.CreateIndex(
                name: "IX_KIEUDANG_MATAIKHOAN",
                table: "KIEUDANG",
                column: "MATAIKHOAN");

            migrationBuilder.CreateIndex(
                name: "IX_MAUSAC_MATAIKHOAN",
                table: "MAUSAC",
                column: "MATAIKHOAN");

            migrationBuilder.CreateIndex(
                name: "IX_TAIKHOAN_MACHUCVU",
                table: "TAIKHOAN",
                column: "MACHUCVU");

            migrationBuilder.CreateIndex(
                name: "IX_THUONGHIEU_MATAIKHOAN",
                table: "THUONGHIEU",
                column: "MATAIKHOAN");

            migrationBuilder.CreateIndex(
                name: "IX_UUDAI_MATAIKHOAN",
                table: "UUDAI",
                column: "MATAIKHOAN");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BANGLUONG");

            migrationBuilder.DropTable(
                name: "GIAOCANHANVIEN");

            migrationBuilder.DropTable(
                name: "HOADONCHITIET");

            migrationBuilder.DropTable(
                name: "GIAOCA");

            migrationBuilder.DropTable(
                name: "GIAYCHITIET");

            migrationBuilder.DropTable(
                name: "HOADON");

            migrationBuilder.DropTable(
                name: "CHATLIEU");

            migrationBuilder.DropTable(
                name: "GIAY");

            migrationBuilder.DropTable(
                name: "KICHCO");

            migrationBuilder.DropTable(
                name: "KIEUDANG");

            migrationBuilder.DropTable(
                name: "MAUSAC");

            migrationBuilder.DropTable(
                name: "THUONGHIEU");

            migrationBuilder.DropTable(
                name: "HINHTHUCTHANHTOAN");

            migrationBuilder.DropTable(
                name: "KHACHHANG");

            migrationBuilder.DropTable(
                name: "UUDAI");

            migrationBuilder.DropTable(
                name: "TAIKHOAN");

            migrationBuilder.DropTable(
                name: "CHUCVU");
        }
    }
}
