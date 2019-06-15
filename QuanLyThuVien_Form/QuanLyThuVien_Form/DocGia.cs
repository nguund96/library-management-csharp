using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_Form
{
    public class DocGia
    {
        public string MaDocGia { get; set; }
        public string MaLoaiDocGia { get; set; }
        public string TenDocGia { get; set; }
        public string SoCMND { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public LoaiDocGia LoaiDocGia { get; set; }
        public List<PhieuMuon> PhieuMuons { get; set; }
    }
}
