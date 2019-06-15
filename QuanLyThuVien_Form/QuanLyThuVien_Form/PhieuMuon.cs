using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_Form
{
    public class PhieuMuon
    {
        public string MaPhieuMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public int ThoiGianMuon { get; set; }
        public string MaDocGia { get; set; }
        public string MaNhanVien { get; set; }
        public DocGia DocGia { get; set; }
        public NhanVien NhanVien { get; set; }
        public List<PhieuTra> PhieuTras { get; set; }
        public List<PhieuPhat> PhieuPhats { get; set; }
        public List<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }
    }
}
