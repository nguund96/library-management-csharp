using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string NgonNgu { get; set; }
        public string MaViTri { get; set; }
        public string MaTheLoai { get; set; }
        public string MaNXB { get; set; }
        public string MaTacGia { get; set; }
        public int SoTrang { get; set; }
        public ViTri ViTri { get; set; }
        public TheLoai TheLoai { get; set; }
        public NhaXuatBan NhaXuatBan { get; set; }
        public TacGia TacGia { get; set; }
        public List<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }
    }
}
