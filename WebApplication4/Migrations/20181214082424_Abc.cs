using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class Abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Docgias",
                columns: table => new
                {
                    MaKH = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SoSachMuon = table.Column<int>(nullable: false),
                    LoaiDG = table.Column<int>(nullable: false),
                    GioiHanSach = table.Column<int>(nullable: false),
                    GioiHanTG = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docgias", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "Quanlys",
                columns: table => new
                {
                    MaQL = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quanlys", x => x.MaQL);
                });

            migrationBuilder.CreateTable(
                name: "ThuViens",
                columns: table => new
                {
                    MaChiNhanh = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenChiNhanh = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuViens", x => x.MaChiNhanh);
                });

            migrationBuilder.CreateTable(
                name: "Sachs",
                columns: table => new
                {
                    MaSach = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TuaSach = table.Column<string>(nullable: true),
                    TacGia = table.Column<string>(nullable: true),
                    NhaXuatBan = table.Column<string>(nullable: true),
                    GioiThieu = table.Column<string>(nullable: true),
                    DanhGia = table.Column<string>(nullable: true),
                    SoLuong = table.Column<string>(nullable: true),
                    NamXuatBan = table.Column<string>(nullable: true),
                    MaChiNhanh = table.Column<int>(nullable: false),
                    Hinh = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sachs", x => x.MaSach);
                    table.ForeignKey(
                        name: "FK_Sachs_ThuViens_MaChiNhanh",
                        column: x => x.MaChiNhanh,
                        principalTable: "ThuViens",
                        principalColumn: "MaChiNhanh",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThuThus",
                columns: table => new
                {
                    MaTT = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaChiNhanh = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuThus", x => x.MaTT);
                    table.ForeignKey(
                        name: "FK_ThuThus_ThuViens_MaChiNhanh",
                        column: x => x.MaChiNhanh,
                        principalTable: "ThuViens",
                        principalColumn: "MaChiNhanh",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sachs_MaChiNhanh",
                table: "Sachs",
                column: "MaChiNhanh");

            migrationBuilder.CreateIndex(
                name: "IX_ThuThus_MaChiNhanh",
                table: "ThuThus",
                column: "MaChiNhanh");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Docgias");

            migrationBuilder.DropTable(
                name: "Quanlys");

            migrationBuilder.DropTable(
                name: "Sachs");

            migrationBuilder.DropTable(
                name: "ThuThus");

            migrationBuilder.DropTable(
                name: "ThuViens");
        }
    }
}
