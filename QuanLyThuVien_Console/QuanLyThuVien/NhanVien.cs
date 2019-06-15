using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public List<PhieuMuon> PhieuMuons { get; set; }
        public List<PhieuTra> PhieuTras { get; set; }
        public List<PhieuPhat> PhieuPhats { get; set; }
    }
}
