using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_Form
{
    public class PhieuPhat
    {
        public string MaPhieuPhat { get; set; }
        public DateTime NgayPhat { get; set; }
        public string LyDoPhat { get; set; }
        public double SoTienPhat { get; set; }
        public string MaNhanVien { get; set; }
        public string MaPhieuMuon { get; set; }
        public NhanVien NhanVien { get; set; }
        public PhieuMuon PhieuMuon { get; set; }
    }
}
