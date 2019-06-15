using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_Form
{
    public class PhieuTra
    {
        public string MaPhieuTra { get; set; }
        public DateTime NgayTra { get; set; }
        public int SoLuongSachTra { get; set; }
        public string MaNhanVien { get; set; }
        public string MaPhieuMuon { get; set; }
        public NhanVien NhanVien { get; set; }
        public PhieuMuon PhieuMuon { get; set; }
        public List<Sach> SachTras { get; set; }
    }
}
