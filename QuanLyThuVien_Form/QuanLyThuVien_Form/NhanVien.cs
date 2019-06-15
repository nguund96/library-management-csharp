using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_Form
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string SDT { get; set; }
        public double HeSoLuong { get; set; }
        public List<PhieuMuon> PhieuMuons { get; set; }
        public List<PhieuTra> PhieuTras { get; set; }
        public List<PhieuPhat> PhieuPhats { get; set; }
    }
}
