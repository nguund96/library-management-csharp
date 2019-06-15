using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_Form
{
    public partial class FORM_MAIN : Form
    {
        public FORM_MAIN()
        {
            InitializeComponent();
        }
        public static List<Sach> Sachs = new List<Sach>();
        public static List<ViTri> ViTris = new List<ViTri>();
        public static List<TacGia> TacGias = new List<TacGia>();
        public static List<NhaXuatBan> NhaXuatBans = new List<NhaXuatBan>();
        public static List<TheLoai> TheLoais = new List<TheLoai>();
        public static List<NhanVien> NhanViens = new List<NhanVien>();
        public static List<LoaiDocGia> LoaiDocGias = new List<LoaiDocGia>();
        public static List<DocGia> DocGias = new List<DocGia>();
        public static List<PhieuMuon> PhieuMuons = new List<PhieuMuon>();
        public static List<PhieuTra> PhieuTras = new List<PhieuTra>();
        public static List<PhieuPhat> PhieuPhats = new List<PhieuPhat>();
        public static List<ChiTietPhieuMuon> ChiTietPhieuMuons = new List<ChiTietPhieuMuon>();
        
        private void FORM_MAIN_Load(object sender, EventArgs e)
        {
            TaoDataBase();
        }

        private void TSMI_NhanVien_Click(object sender, EventArgs e)
        {
            FORM_NhanVien nv = new FORM_NhanVien();
            nv.ShowDialog();
        }

        public static void TaoDSViTri()
        {
            ViTris.Add(new ViTri()
            {
                MaViTri = "A1"
            });
            ViTris.Add(new ViTri()
            {
                MaViTri = "A2"
            });
            ViTris.Add(new ViTri()
            {
                MaViTri = "A3"
            });
            ViTris.Add(new ViTri()
            {
                MaViTri = "B1"
            });
            ViTris.Add(new ViTri()
            {
                MaViTri = "B2"
            });
            ViTris.Add(new ViTri()
            {
                MaViTri = "B3"
            });
            ViTris.Add(new ViTri()
            {
                MaViTri = "C1"
            });
            ViTris.Add(new ViTri()
            {
                MaViTri = "C2"
            });
            ViTris.Add(new ViTri()
            {
                MaViTri = "C3"
            });
        }
        public static void TaoDSTacGia()
        {
            TacGias.Add(new TacGia()
            {
                MaTacGia = "TG001",
                TenTacGia = "To Hoai"
            });
            TacGias.Add(new TacGia()
            {
                MaTacGia = "TG002",
                TenTacGia = "To Huu"
            });
            TacGias.Add(new TacGia()
            {
                MaTacGia = "TG003",
                TenTacGia = "Dang Tran Con"
            });
            TacGias.Add(new TacGia()
            {
                MaTacGia = "TG004",
                TenTacGia = "Ho Chi Minh"
            });
            TacGias.Add(new TacGia()
            {
                MaTacGia = "TG005",
                TenTacGia = "Nam Cao"
            });
        }
        public static void TaoDSNhaXuatBan()
        {
            NhaXuatBans.Add(new NhaXuatBan()
            {
                MaNXB = "NXB001",
                TenNXB = "NXB Hoi Nha Van"
            });
            NhaXuatBans.Add(new NhaXuatBan()
            {
                MaNXB = "NXB002",
                TenNXB = "NXB Van Hoc"
            });
            NhaXuatBans.Add(new NhaXuatBan()
            {
                MaNXB = "NXB003",
                TenNXB = "NXB Kim Dong"
            });

        }
        public static void TaoDSTheLoai()
        {
            TheLoais.Add(new TheLoai()
            {
                MaTheLoai = "TL001",
                TenTheLoai = "Truyen Ngan"
            });
            TheLoais.Add(new TheLoai()
            {
                MaTheLoai = "TL002",
                TenTheLoai = "Van Xuoi"
            });
            TheLoais.Add(new TheLoai()
            {
                MaTheLoai = "TL003",
                TenTheLoai = "Tho"
            });
            TheLoais.Add(new TheLoai()
            {
                MaTheLoai = "TL004",
                TenTheLoai = "Tru Tinh"
            });
            TheLoais.Add(new TheLoai()
            {
                MaTheLoai = "TL005",
                TenTheLoai = "Tieu Thuyet"
            });
            TheLoais.Add(new TheLoai()
            {
                MaTheLoai = "TL006",
                TenTheLoai = "Van Hoc"
            });
            TheLoais.Add(new TheLoai()
            {
                MaTheLoai = "TL007",
                TenTheLoai = "Hoi Ky"
            });
        }
        public static void TaoDSSach()
        {
            Sachs.Add(new Sach()
            {
                MaSach = "S001",
                TenSach = "De Men Phieu Luu Ky",
                NgonNgu = "Tieng Viet",
                MaViTri = "A1",
                MaTheLoai = "TL001",
                MaNXB = "NXB002",
                MaTacGia = "TG001",
                SoTrang = 360,
                TheLoai = (from tl in TheLoais where tl.MaTheLoai == "TL001" select tl).First(),
                NhaXuatBan = (from nxb in NhaXuatBans where nxb.MaNXB == "NXB002" select nxb).First(),
                ViTri = (from vt in ViTris where vt.MaViTri == "A1" select vt).First(),
                TacGia = (from tg in TacGias where tg.MaTacGia == "TG001" select tg).First()
            });
            Sachs.Add(new Sach()
            {
                MaSach = "S002",
                TenSach = "Viet Bac",
                NgonNgu = "Tieng Viet",
                MaViTri = "A2",
                MaTheLoai = "TL003",
                MaNXB = "NXB001",
                MaTacGia = "TG002",
                SoTrang = 270,
                TheLoai = (from tl in TheLoais where tl.MaTheLoai == "TL003" select tl).First(),
                NhaXuatBan = (from nxb in NhaXuatBans where nxb.MaNXB == "NXB001" select nxb).First(),
                ViTri = (from vt in ViTris where vt.MaViTri == "A2" select vt).First(),
                TacGia = (from tg in TacGias where tg.MaTacGia == "TG002" select tg).First()
            });
            Sachs.Add(new Sach()
            {
                MaSach = "S003",
                TenSach = "Tu Ay",
                NgonNgu = "Tieng Viet",
                MaViTri = "A1",
                MaTheLoai = "TL003",
                MaNXB = "NXB002",
                MaTacGia = "TG002",
                SoTrang = 150,
                TheLoai = (from tl in TheLoais where tl.MaTheLoai == "TL003" select tl).First(),
                NhaXuatBan = (from nxb in NhaXuatBans where nxb.MaNXB == "NXB002" select nxb).First(),
                ViTri = (from vt in ViTris where vt.MaViTri == "A1" select vt).First(),
                TacGia = (from tg in TacGias where tg.MaTacGia == "TG002" select tg).First()
            });
            Sachs.Add(new Sach()
            {
                MaSach = "S004",
                TenSach = "Chinh Phu Ngam Khuc",
                NgonNgu = "Chu Han Viet",
                MaViTri = "B1",
                MaTheLoai = "TL004",
                MaNXB = "NXB002",
                MaTacGia = "TG003",
                SoTrang = 240,
                TheLoai = (from tl in TheLoais where tl.MaTheLoai == "TL004" select tl).First(),
                NhaXuatBan = (from nxb in NhaXuatBans where nxb.MaNXB == "NXB002" select nxb).First(),
                ViTri = (from vt in ViTris where vt.MaViTri == "B1" select vt).First(),
                TacGia = (from tg in TacGias where tg.MaTacGia == "TG003" select tg).First()
            });
            Sachs.Add(new Sach()
            {
                MaSach = "S005",
                TenSach = "Nhat Ky Trong Tu",
                NgonNgu = "Tieng Viet",
                MaViTri = "B2",
                MaTheLoai = "TL003",
                MaNXB = "NXB002",
                MaTacGia = "TG004",
                SoTrang = 300,
                TheLoai = (from tl in TheLoais where tl.MaTheLoai == "TL003" select tl).First(),
                NhaXuatBan = (from nxb in NhaXuatBans where nxb.MaNXB == "NXB002" select nxb).First(),
                ViTri = (from vt in ViTris where vt.MaViTri == "B2" select vt).First(),
                TacGia = (from tg in TacGias where tg.MaTacGia == "TG004" select tg).First()
            });
            Sachs.Add(new Sach()
            {
                MaSach = "S006",
                TenSach = "Tho To Huu",
                NgonNgu = "Tieng Viet",
                MaViTri = "B3",
                MaTheLoai = "TL003",
                MaNXB = "NXB002",
                MaTacGia = "TG002",
                SoTrang = 300,
                TheLoai = (from tl in TheLoais where tl.MaTheLoai == "TL003" select tl).First(),
                NhaXuatBan = (from nxb in NhaXuatBans where nxb.MaNXB == "NXB002" select nxb).First(),
                ViTri = (from vt in ViTris where vt.MaViTri == "B3" select vt).First(),
                TacGia = (from tg in TacGias where tg.MaTacGia == "TG002" select tg).First()
            });
            Sachs.Add(new Sach()
            {
                MaSach = "S007",
                TenSach = "Dao Hoang",
                NgonNgu = "Tieng Viet",
                MaViTri = "B2",
                MaTheLoai = "TL001",
                MaNXB = "NXB003",
                MaTacGia = "TG001",
                SoTrang = 420,
                TheLoai = (from tl in TheLoais where tl.MaTheLoai == "TL001" select tl).First(),
                NhaXuatBan = (from nxb in NhaXuatBans where nxb.MaNXB == "NXB003" select nxb).First(),
                ViTri = (from vt in ViTris where vt.MaViTri == "B2" select vt).First(),
                TacGia = (from tg in TacGias where tg.MaTacGia == "TG001" select tg).First()
            });
            Sachs.Add(new Sach()
            {
                MaSach = "S008",
                TenSach = "Que Nguoi",
                NgonNgu = "Tieng Viet",
                MaViTri = "C1",
                MaTheLoai = "TL002",
                MaNXB = "NXB002",
                MaTacGia = "TG001",
                SoTrang = 262,
                TheLoai = (from tl in TheLoais where tl.MaTheLoai == "TL002" select tl).First(),
                NhaXuatBan = (from nxb in NhaXuatBans where nxb.MaNXB == "NXB002" select nxb).First(),
                ViTri = (from vt in ViTris where vt.MaViTri == "C1" select vt).First(),
                TacGia = (from tg in TacGias where tg.MaTacGia == "TG001" select tg).First()
            });
            Sachs.Add(new Sach()
            {
                MaSach = "S009",
                TenSach = "Khach No",
                NgonNgu = "Tieng Viet",
                MaViTri = "C2",
                MaTheLoai = "TL005",
                MaNXB = "NXB002",
                MaTacGia = "TG001",
                SoTrang = 273,
                TheLoai = (from tl in TheLoais where tl.MaTheLoai == "TL005" select tl).First(),
                NhaXuatBan = (from nxb in NhaXuatBans where nxb.MaNXB == "NXB002" select nxb).First(),
                ViTri = (from vt in ViTris where vt.MaViTri == "C2" select vt).First(),
                TacGia = (from tg in TacGias where tg.MaTacGia == "TG001" select tg).First()
            });
            Sachs.Add(new Sach()
            {
                MaSach = "S010",
                TenSach = "Gio Long",
                NgonNgu = "Tieng Viet",
                MaViTri = "B3",
                MaTheLoai = "TL003",
                MaNXB = "NXB002",
                MaTacGia = "TG003",
                SoTrang = 240,
                TheLoai = (from tl in TheLoais where tl.MaTheLoai == "TL003" select tl).First(),
                NhaXuatBan = (from nxb in NhaXuatBans where nxb.MaNXB == "NXB002" select nxb).First(),
                ViTri = (from vt in ViTris where vt.MaViTri == "B3" select vt).First(),
                TacGia = (from tg in TacGias where tg.MaTacGia == "TG003" select tg).First()
            });
            Sachs.Add(new Sach()
            {
                MaSach = "S011",
                TenSach = "Chi Pheo",
                NgonNgu = "Tieng Viet",
                MaViTri = "B2",
                MaTheLoai = "TL005",
                MaNXB = "NXB002",
                MaTacGia = "TG005",
                SoTrang = 240,
                TheLoai = (from tl in TheLoais where tl.MaTheLoai == "TL005" select tl).First(),
                NhaXuatBan = (from nxb in NhaXuatBans where nxb.MaNXB == "NXB002" select nxb).First(),
                ViTri = (from vt in ViTris where vt.MaViTri == "B2" select vt).First(),
                TacGia = (from tg in TacGias where tg.MaTacGia == "TG005" select tg).First()
            });
            Sachs.Add(new Sach()
            {
                MaSach = "S012",
                TenSach = "Luom",
                NgonNgu = "Tieng Viet",
                MaViTri = "A1",
                MaTheLoai = "TL003",
                MaNXB = "NXB002",
                MaTacGia = "TG002",
                SoTrang = 150,
                TheLoai = (from tl in TheLoais where tl.MaTheLoai == "TL003" select tl).First(),
                NhaXuatBan = (from nxb in NhaXuatBans where nxb.MaNXB == "NXB002" select nxb).First(),
                ViTri = (from vt in ViTris where vt.MaViTri == "A1" select vt).First(),
                TacGia = (from tg in TacGias where tg.MaTacGia == "TG002" select tg).First()
            });
            Sachs.Add(new Sach()
            {
                MaSach = "S013",
                TenSach = "Chieu Chieu",
                NgonNgu = "Tieng Viet",
                MaViTri = "A1",
                MaTheLoai = "TL007",
                MaNXB = "NXB002",
                MaTacGia = "TG001",
                SoTrang = 245,
                TheLoai = (from tl in TheLoais where tl.MaTheLoai == "TL007" select tl).First(),
                NhaXuatBan = (from nxb in NhaXuatBans where nxb.MaNXB == "NXB002" select nxb).First(),
                ViTri = (from vt in ViTris where vt.MaViTri == "A1" select vt).First(),
                TacGia = (from tg in TacGias where tg.MaTacGia == "TG001" select tg).First()
            });
        }
        public static void TaoDSNhanVien()
        {
            NhanViens.Add(new NhanVien()
            {
                MaNhanVien = "NV001",
                TenNhanVien = "Nguyen Thi Kim A",
                SDT = "01674574574",
                HeSoLuong = 2.0
            });
            NhanViens.Add(new NhanVien()
            {
                MaNhanVien = "NV002",
                TenNhanVien = "Le Thi B",
                SDT = "01679995599",
                HeSoLuong = 3.0
            });
            NhanViens.Add(new NhanVien()
            {
                MaNhanVien = "NV003",
                TenNhanVien = "Tran Van C",
                SDT = "0969789789",
                HeSoLuong = 2.0
            });
            NhanViens.Add(new NhanVien()
            {
                MaNhanVien = "NV004",
                TenNhanVien = "Nguyen Hoang D",
                SDT = "0969941941",
                HeSoLuong = 2.0
            });
        }
        public static void TaoDSLoaiDocGia()
        {
            LoaiDocGias.Add(new LoaiDocGia()
            {
                MaLoaiDocGia = "LDG001",
                TenLoaiDocGia = "HS-SV"
            });
            LoaiDocGias.Add(new LoaiDocGia()
            {
                MaLoaiDocGia = "LDG002",
                TenLoaiDocGia = "Nguoi cao tuoi"
            });
            LoaiDocGias.Add(new LoaiDocGia()
            {
                MaLoaiDocGia = "LDG003",
                TenLoaiDocGia = "Hoi vien"
            });
            LoaiDocGias.Add(new LoaiDocGia()
            {
                MaLoaiDocGia = "LDG004",
                TenLoaiDocGia = "Tre em duoi 12 tuoi"
            });
        }
        public static void TaoDSDocGia()
        {
            DocGias.Add(new DocGia()
            {
                MaDocGia = "DG001",
                TenDocGia = "Nguyen Duc Nguu",
                DiaChi = "Thu Duc",
                SoCMND = "241587935",
                SDT = "0969741193",
                MaLoaiDocGia = "LDG004",
                LoaiDocGia = (from ldg in LoaiDocGias where ldg.MaLoaiDocGia == "LDG004" select ldg).First()
            });
            DocGias.Add(new DocGia()
            {
                MaDocGia = "DG002",
                TenDocGia = "Tran Anh Son",
                DiaChi = "Quan 1",
                SoCMND = "212470855",
                SDT = "0169443473",
                MaLoaiDocGia = "LDG001",
                LoaiDocGia = (from ldg in LoaiDocGias where ldg.MaLoaiDocGia == "LDG001" select ldg).First()
            });
            DocGias.Add(new DocGia()
            {
                MaDocGia = "DG003",
                TenDocGia = "Huynh Nhat Thanh",
                DiaChi = "Binh Thanh",
                SoCMND = "212470863",
                SDT = "0169443578",
                MaLoaiDocGia = "LDG003",
                LoaiDocGia = (from ldg in LoaiDocGias where ldg.MaLoaiDocGia == "LDG003" select ldg).First()
            });
            DocGias.Add(new DocGia()
            {
                MaDocGia = "DG004",
                TenDocGia = "Nguyen Minh Dao",
                DiaChi = "Quan 9",
                SoCMND = "21247084",
                SDT = "0169458234",
                MaLoaiDocGia = "LDG002",
                LoaiDocGia = (from ldg in LoaiDocGias where ldg.MaLoaiDocGia == "LDG002" select ldg).First()
            });
            DocGias.Add(new DocGia()
            {
                MaDocGia = "DG005",
                TenDocGia = "Heu Ly",
                DiaChi = "Go Vap",
                SoCMND = "21244562",
                SDT = "0169447895",
                MaLoaiDocGia = "LDG001",
                LoaiDocGia = (from ldg in LoaiDocGias where ldg.MaLoaiDocGia == "LDG001" select ldg).First()
            });
            DocGias.Add(new DocGia()
            {
                MaDocGia = "DG006",
                TenDocGia = "Hoai Thuong",
                DiaChi = "Quan 7",
                SoCMND = "21244102",
                SDT = "0169474155",
                MaLoaiDocGia = "LDG002",
                LoaiDocGia = (from ldg in LoaiDocGias where ldg.MaLoaiDocGia == "LDG002" select ldg).First()
            });
            DocGias.Add(new DocGia()
            {
                MaDocGia = "DG007",
                TenDocGia = "Vo Huu Nhan",
                DiaChi = "Thu Duc",
                SoCMND = "21412852",
                SDT = "016944897",
                MaLoaiDocGia = "LDG003",
                LoaiDocGia = (from ldg in LoaiDocGias where ldg.MaLoaiDocGia == "LDG003" select ldg).First()
            });
            DocGias.Add(new DocGia()
            {
                MaDocGia = "DG008",
                TenDocGia = "Hoang Bao",
                DiaChi = "Quan 7",
                SoCMND = "21247894",
                SDT = "0169654295",
                MaLoaiDocGia = "LDG004",
                LoaiDocGia = (from ldg in LoaiDocGias where ldg.MaLoaiDocGia == "LDG004" select ldg).First()
            });
        }
        public static void TaoDSChiTietPhieuMuon()
        {
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM001",
                MaSach = "S001",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM001" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S001" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM001",
                MaSach = "S013",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM001" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S013" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM001",
                MaSach = "S003",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM001" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S003" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM001",
                MaSach = "S005",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM001" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S005" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM002",
                MaSach = "S002",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM002" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S002" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM002",
                MaSach = "S004",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM002" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S004" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM002",
                MaSach = "S007",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM002" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S007" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM003",
                MaSach = "S006",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM003" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S006" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM003",
                MaSach = "S008",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM003" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S008" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM003",
                MaSach = "S009",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM003" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S009" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM003",
                MaSach = "S010",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM003" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S010" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM003",
                MaSach = "S012",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM003" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S012" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM004",
                MaSach = "S011",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM004" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S011" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM004",
                MaSach = "S012",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM004" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S012" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM004",
                MaSach = "S013",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM004" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S013" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM005",
                MaSach = "S001",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM005" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S001" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM005",
                MaSach = "S005",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM005" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S005" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM006",
                MaSach = "S006",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM006" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S006" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM007",
                MaSach = "S002",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM007" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S002" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM007",
                MaSach = "S009",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM007" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S009" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM008",
                MaSach = "S003",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM008" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S003" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM008",
                MaSach = "S005",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM008" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S005" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM008",
                MaSach = "S008",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM008" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S008" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM009",
                MaSach = "S006",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM009" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S006" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM010",
                MaSach = "S005",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM010" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S005" select s).First()
            });
            ChiTietPhieuMuons.Add(new ChiTietPhieuMuon()
            {
                MaPhieuMuon = "PM010",
                MaSach = "S006",
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM010" select pm).First(),
                Sach = (from s in Sachs where s.MaSach == "S006" select s).First()
            });
        }
        public static void TaoDSPhieuMuon()
        {
            PhieuMuons.Add(new PhieuMuon()
            {
                MaPhieuMuon = "PM001",
                NgayMuon = new DateTime(2015, 03, 10),
                ThoiGianMuon = 12,
                MaDocGia = "DG001",
                MaNhanVien = "NV004",
                DocGia = (from dg in DocGias where dg.MaDocGia == "DG001" select dg).First(),
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV004" select nv).First()
            });
            PhieuMuons.Add(new PhieuMuon()
            {
                MaPhieuMuon = "PM002",
                NgayMuon = new DateTime(2015, 12, 2),
                ThoiGianMuon = 20,
                MaDocGia = "DG002",
                MaNhanVien = "NV003",
                DocGia = (from dg in DocGias where dg.MaDocGia == "DG002" select dg).First(),
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV003" select nv).First()
            });
            PhieuMuons.Add(new PhieuMuon()
            {
                MaPhieuMuon = "PM003",
                NgayMuon = new DateTime(2015, 11, 15),
                ThoiGianMuon = 15,
                MaDocGia = "DG003",
                MaNhanVien = "NV002",
                DocGia = (from dg in DocGias where dg.MaDocGia == "DG003" select dg).First(),
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV002" select nv).First()
            });
            PhieuMuons.Add(new PhieuMuon()
            {
                MaPhieuMuon = "PM004",
                NgayMuon = new DateTime(2015, 09, 10),
                ThoiGianMuon = 30,
                MaDocGia = "DG004",
                MaNhanVien = "NV001",
                DocGia = (from dg in DocGias where dg.MaDocGia == "DG004" select dg).First(),
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV001" select nv).First()
            });
            PhieuMuons.Add(new PhieuMuon()
            {
                MaPhieuMuon = "PM005",
                NgayMuon = new DateTime(2015, 11, 8),
                ThoiGianMuon = 22,
                MaDocGia = "DG005",
                MaNhanVien = "NV001",
                DocGia = (from dg in DocGias where dg.MaDocGia == "DG005" select dg).First(),
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV001" select nv).First()
            });
            PhieuMuons.Add(new PhieuMuon()
            {
                MaPhieuMuon = "PM006",
                NgayMuon = new DateTime(2015, 02, 10),
                ThoiGianMuon = 2,
                MaDocGia = "DG006",
                MaNhanVien = "NV002",
                DocGia = (from dg in DocGias where dg.MaDocGia == "DG006" select dg).First(),
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV002" select nv).First()
            });
            PhieuMuons.Add(new PhieuMuon()
            {
                MaPhieuMuon = "PM007",
                NgayMuon = new DateTime(2015, 03, 30),
                ThoiGianMuon = 12,
                MaDocGia = "DG007",
                MaNhanVien = "NV003",
                DocGia = (from dg in DocGias where dg.MaDocGia == "DG007" select dg).First(),
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV003" select nv).First()
            });
            PhieuMuons.Add(new PhieuMuon()
            {
                MaPhieuMuon = "PM008",
                NgayMuon = new DateTime(2015, 03, 25),
                ThoiGianMuon = 12,
                MaDocGia = "DG008",
                MaNhanVien = "NV004",
                DocGia = (from dg in DocGias where dg.MaDocGia == "DG008" select dg).First(),
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV004" select nv).First()
            });
            PhieuMuons.Add(new PhieuMuon()
            {
                MaPhieuMuon = "PM009",
                NgayMuon = new DateTime(2015, 03, 21),
                ThoiGianMuon = 3,
                MaDocGia = "DG001",
                MaNhanVien = "NV004",
                DocGia = (from dg in DocGias where dg.MaDocGia == "DG001" select dg).First(),
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV004" select nv).First()
            });
            PhieuMuons.Add(new PhieuMuon()
            {
                MaPhieuMuon = "PM010",
                NgayMuon = new DateTime(2015, 04, 6),
                ThoiGianMuon = 12,
                MaDocGia = "DG007",
                MaNhanVien = "NV002",
                DocGia = (from dg in DocGias where dg.MaDocGia == "DG007" select dg).First(),
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV002" select nv).First()
            });
        }
        public static void TaoDSPhieuTra()
        {
            PhieuTras.Add(new PhieuTra()
            {
                MaPhieuTra = "PT001",
                NgayTra = new DateTime(2015, 3, 21),
                SoLuongSachTra = 2,
                MaNhanVien = "NV001",
                MaPhieuMuon = "PM001",
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV001" select nv).First(),
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM001" select pm).First(),
            });
            PhieuTras.Add(new PhieuTra()
            {
                MaPhieuTra = "PT002",
                NgayTra = new DateTime(2015, 3, 25),
                SoLuongSachTra = 1,
                MaNhanVien = "NV002",
                MaPhieuMuon = "PM001",
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV002" select nv).First(),
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM001" select pm).First(),
            });
            PhieuTras.Add(new PhieuTra()
            {
                MaPhieuTra = "PT003",
                NgayTra = new DateTime(2015, 4, 30),
                SoLuongSachTra = 1,
                MaNhanVien = "NV003",
                MaPhieuMuon = "PM010",
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV003" select nv).First(),
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM010" select pm).First(),
            });
            PhieuTras.Add(new PhieuTra()
            {
                MaPhieuTra = "PT004",
                NgayTra = new DateTime(2015, 11, 28),
                SoLuongSachTra = 2,
                MaNhanVien = "NV004",
                MaPhieuMuon = "PM005",
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV004" select nv).First(),
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM005" select pm).First(),
            });
            PhieuTras.Add(new PhieuTra()
            {
                MaPhieuTra = "PT005",
                NgayTra = new DateTime(2015, 12, 1),
                SoLuongSachTra = 3,
                MaNhanVien = "NV004",
                MaPhieuMuon = "PM003",
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV004" select nv).First(),
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM003" select pm).First(),
            });


        }
        public static void TaoDSPhieuPhat()
        {
            PhieuPhats.Add(new PhieuPhat()
            {
                MaPhieuPhat = "PP001",
                NgayPhat = new DateTime(2015, 4, 10),
                MaPhieuMuon = "PM001",
                MaNhanVien = "NV002",
                LyDoPhat = "Tra sach tre han!",
                SoTienPhat = 20000,
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV002" select nv).First(),
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM001" select pm).First()
            });
            PhieuPhats.Add(new PhieuPhat()
            {
                MaPhieuPhat = "PP002",
                NgayPhat = new DateTime(2015, 6, 25),
                MaPhieuMuon = "PM001",
                MaNhanVien = "NV002",
                LyDoPhat = "Lam hong sach!",
                SoTienPhat = 100000,
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV002" select nv).First(),
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM001" select pm).First()
            });
            PhieuPhats.Add(new PhieuPhat()
            {
                MaPhieuPhat = "PP003",
                NgayPhat = new DateTime(2015, 8, 22),
                MaPhieuMuon = "PM005",
                MaNhanVien = "NV004",
                LyDoPhat = "Tra sach tre han!",
                SoTienPhat = 20000,
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV004" select nv).First(),
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM005" select pm).First()
            });
            PhieuPhats.Add(new PhieuPhat()
            {
                MaPhieuPhat = "PP004",
                NgayPhat = new DateTime(2015, 9, 21),
                MaPhieuMuon = "PM002",
                MaNhanVien = "NV003",
                LyDoPhat = "Ve bay vao sach!",
                SoTienPhat = 200000,
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV003" select nv).First(),
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM002" select pm).First()
            });
            PhieuPhats.Add(new PhieuPhat()
            {
                MaPhieuPhat = "PP005",
                NgayPhat = new DateTime(2015, 10, 30),
                MaPhieuMuon = "PM009",
                MaNhanVien = "NV004",
                LyDoPhat = "Lam mat sach!",
                SoTienPhat = 200000,
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV004" select nv).First(),
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM009" select pm).First()
            });
            PhieuPhats.Add(new PhieuPhat()
            {
                MaPhieuPhat = "PP006",
                NgayPhat = new DateTime(2015, 12, 1),
                MaPhieuMuon = "PM010",
                MaNhanVien = "NV001",
                LyDoPhat = "Lam rach sach!",
                SoTienPhat = 100000,
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV001" select nv).First(),
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM010" select pm).First()
            });
            PhieuPhats.Add(new PhieuPhat()
            {
                MaPhieuPhat = "PP007",
                NgayPhat = new DateTime(2015, 12, 5),
                MaPhieuMuon = "PM003",
                MaNhanVien = "NV001",
                LyDoPhat = "Tra sach tre han!",
                SoTienPhat = 20000,
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV001" select nv).First(),
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM003" select pm).First()
            });
            PhieuPhats.Add(new PhieuPhat()
            {
                MaPhieuPhat = "PP008",
                NgayPhat = new DateTime(2015, 12, 28),
                MaPhieuMuon = "PM003",
                MaNhanVien = "NV002",
                LyDoPhat = "Sach nhau nat!",
                SoTienPhat = 50000,
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV002" select nv).First(),
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM003" select pm).First()
            });
            PhieuPhats.Add(new PhieuPhat()
            {
                MaPhieuPhat = "PP009",
                NgayPhat = new DateTime(2015, 11, 30),
                MaPhieuMuon = "PM007",
                MaNhanVien = "NV004",
                LyDoPhat = "Lam mat sach!",
                SoTienPhat = 100000,
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV004" select nv).First(),
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM007" select pm).First()
            });
            PhieuPhats.Add(new PhieuPhat()
            {
                MaPhieuPhat = "PP010",
                NgayPhat = new DateTime(2015, 10, 21),
                MaPhieuMuon = "PM008",
                MaNhanVien = "NV004",
                LyDoPhat = "Lam mat sach!",
                SoTienPhat = 100000,
                NhanVien = (from nv in NhanViens where nv.MaNhanVien == "NV004" select nv).First(),
                PhieuMuon = (from pm in PhieuMuons where pm.MaPhieuMuon == "PM008" select pm).First()
            });
        }
        public static void TaoDataBase()
        {
            TaoDSViTri();
            TaoDSTheLoai();
            TaoDSTacGia();
            TaoDSNhaXuatBan();
            TaoDSSach();
            TaoDSLoaiDocGia();
            TaoDSDocGia();
            TaoDSNhanVien();
            TaoDSPhieuMuon();
            TaoDSChiTietPhieuMuon();
            TaoDSPhieuTra();
            TaoDSPhieuPhat();
            //Sắp xếp sách vào vị trí
            ViTris[0].Sachs = (from s in Sachs where s.MaViTri == "A1" select s).ToList();
            ViTris[1].Sachs = (from s in Sachs where s.MaViTri == "A2" select s).ToList();
            ViTris[2].Sachs = (from s in Sachs where s.MaViTri == "A3" select s).ToList();
            ViTris[3].Sachs = (from s in Sachs where s.MaViTri == "B1" select s).ToList();
            ViTris[4].Sachs = (from s in Sachs where s.MaViTri == "B2" select s).ToList();
            ViTris[5].Sachs = (from s in Sachs where s.MaViTri == "B3" select s).ToList();
            ViTris[6].Sachs = (from s in Sachs where s.MaViTri == "C1" select s).ToList();
            ViTris[7].Sachs = (from s in Sachs where s.MaViTri == "C2" select s).ToList();
            ViTris[8].Sachs = (from s in Sachs where s.MaViTri == "C3" select s).ToList();
            //Sắp xếp sách theo từng tác giả
            TacGias[0].Sachs = (from s in Sachs where s.MaTacGia == "TG001" select s).ToList();
            TacGias[1].Sachs = (from s in Sachs where s.MaTacGia == "TG002" select s).ToList();
            TacGias[2].Sachs = (from s in Sachs where s.MaTacGia == "TG003" select s).ToList();
            TacGias[3].Sachs = (from s in Sachs where s.MaTacGia == "TG004" select s).ToList();
            TacGias[4].Sachs = (from s in Sachs where s.MaTacGia == "TG005" select s).ToList();
            //Săp xếp sách theo từng NXB
            NhaXuatBans[0].Sachs = (from s in Sachs where s.MaNXB == "NXB001" select s).ToList();
            NhaXuatBans[1].Sachs = (from s in Sachs where s.MaNXB == "NXB002" select s).ToList();
            NhaXuatBans[2].Sachs = (from s in Sachs where s.MaNXB == "NXB003" select s).ToList();
            //Sắp xếp sách theo từng thể loại
            TheLoais[0].Sachs = (from s in Sachs where s.MaTheLoai == "TL001" select s).ToList();
            TheLoais[1].Sachs = (from s in Sachs where s.MaTheLoai == "TL002" select s).ToList();
            TheLoais[2].Sachs = (from s in Sachs where s.MaTheLoai == "TL003" select s).ToList();
            TheLoais[3].Sachs = (from s in Sachs where s.MaTheLoai == "TL004" select s).ToList();
            TheLoais[4].Sachs = (from s in Sachs where s.MaTheLoai == "TL005" select s).ToList();
            TheLoais[5].Sachs = (from s in Sachs where s.MaTheLoai == "TL006" select s).ToList();
            TheLoais[6].Sachs = (from s in Sachs where s.MaTheLoai == "TL007" select s).ToList();
            //Sách-Chi tiết phiếu mượn
            Sachs[0].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaSach == "S001" select ct).ToList();
            Sachs[1].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaSach == "S002" select ct).ToList();
            Sachs[2].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaSach == "S003" select ct).ToList();
            Sachs[3].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaSach == "S004" select ct).ToList();
            Sachs[4].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaSach == "S005" select ct).ToList();
            Sachs[5].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaSach == "S006" select ct).ToList();
            Sachs[6].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaSach == "S007" select ct).ToList();
            Sachs[7].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaSach == "S008" select ct).ToList();
            Sachs[8].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaSach == "S009" select ct).ToList();
            Sachs[9].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaSach == "S010" select ct).ToList();
            Sachs[10].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaSach == "S011" select ct).ToList();
            Sachs[11].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaSach == "S012" select ct).ToList();
            Sachs[12].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaSach == "S013" select ct).ToList();
            //Phiếu mượn - Chi tiết phiếu mượn
            PhieuMuons[0].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaPhieuMuon == "PM001" select ct).ToList();
            PhieuMuons[1].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaPhieuMuon == "PM002" select ct).ToList();
            PhieuMuons[2].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaPhieuMuon == "PM003" select ct).ToList();
            PhieuMuons[3].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaPhieuMuon == "PM004" select ct).ToList();
            PhieuMuons[4].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaPhieuMuon == "PM005" select ct).ToList();
            PhieuMuons[5].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaPhieuMuon == "PM006" select ct).ToList();
            PhieuMuons[6].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaPhieuMuon == "PM007" select ct).ToList();
            PhieuMuons[7].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaPhieuMuon == "PM008" select ct).ToList();
            PhieuMuons[8].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaPhieuMuon == "PM009" select ct).ToList();
            PhieuMuons[9].ChiTietPhieuMuons = (from ct in ChiTietPhieuMuons where ct.MaPhieuMuon == "PM010" select ct).ToList();
            //Phiếu mượn - Phiếu trả
            PhieuMuons[0].PhieuTras = (from pt in PhieuTras where pt.MaPhieuMuon == "PM001" select pt).ToList();
            PhieuMuons[1].PhieuTras = (from pt in PhieuTras where pt.MaPhieuMuon == "PM002" select pt).ToList();
            PhieuMuons[2].PhieuTras = (from pt in PhieuTras where pt.MaPhieuMuon == "PM003" select pt).ToList();
            PhieuMuons[3].PhieuTras = (from pt in PhieuTras where pt.MaPhieuMuon == "PM004" select pt).ToList();
            PhieuMuons[4].PhieuTras = (from pt in PhieuTras where pt.MaPhieuMuon == "PM005" select pt).ToList();
            PhieuMuons[5].PhieuTras = (from pt in PhieuTras where pt.MaPhieuMuon == "PM006" select pt).ToList();
            PhieuMuons[6].PhieuTras = (from pt in PhieuTras where pt.MaPhieuMuon == "PM007" select pt).ToList();
            PhieuMuons[7].PhieuTras = (from pt in PhieuTras where pt.MaPhieuMuon == "PM008" select pt).ToList();
            PhieuMuons[8].PhieuTras = (from pt in PhieuTras where pt.MaPhieuMuon == "PM009" select pt).ToList();
            PhieuMuons[9].PhieuTras = (from pt in PhieuTras where pt.MaPhieuMuon == "PM010" select pt).ToList();
            //Phiếu mượn - phiếu phạt
            PhieuMuons[0].PhieuPhats = (from pp in PhieuPhats where pp.MaPhieuMuon == "PM001" select pp).ToList();
            PhieuMuons[1].PhieuPhats = (from pp in PhieuPhats where pp.MaPhieuMuon == "PM002" select pp).ToList();
            PhieuMuons[2].PhieuPhats = (from pp in PhieuPhats where pp.MaPhieuMuon == "PM003" select pp).ToList();
            PhieuMuons[3].PhieuPhats = (from pp in PhieuPhats where pp.MaPhieuMuon == "PM004" select pp).ToList();
            PhieuMuons[4].PhieuPhats = (from pp in PhieuPhats where pp.MaPhieuMuon == "PM005" select pp).ToList();
            PhieuMuons[5].PhieuPhats = (from pp in PhieuPhats where pp.MaPhieuMuon == "PM006" select pp).ToList();
            PhieuMuons[6].PhieuPhats = (from pp in PhieuPhats where pp.MaPhieuMuon == "PM007" select pp).ToList();
            PhieuMuons[7].PhieuPhats = (from pp in PhieuPhats where pp.MaPhieuMuon == "PM008" select pp).ToList();
            PhieuMuons[8].PhieuPhats = (from pp in PhieuPhats where pp.MaPhieuMuon == "PM009" select pp).ToList();
            PhieuMuons[9].PhieuPhats = (from pp in PhieuPhats where pp.MaPhieuMuon == "PM010" select pp).ToList();
            //Độc giả - phiếu mượn
            DocGias[0].PhieuMuons = (from pm in PhieuMuons where pm.MaDocGia == "DG001" select pm).ToList();
            DocGias[1].PhieuMuons = (from pm in PhieuMuons where pm.MaDocGia == "DG002" select pm).ToList();
            DocGias[2].PhieuMuons = (from pm in PhieuMuons where pm.MaDocGia == "DG003" select pm).ToList();
            DocGias[3].PhieuMuons = (from pm in PhieuMuons where pm.MaDocGia == "DG004" select pm).ToList();
            DocGias[4].PhieuMuons = (from pm in PhieuMuons where pm.MaDocGia == "DG005" select pm).ToList();
            DocGias[5].PhieuMuons = (from pm in PhieuMuons where pm.MaDocGia == "DG006" select pm).ToList();
            DocGias[6].PhieuMuons = (from pm in PhieuMuons where pm.MaDocGia == "DG007" select pm).ToList();
            DocGias[7].PhieuMuons = (from pm in PhieuMuons where pm.MaDocGia == "DG008" select pm).ToList();
            //Loại độc giả - độc giả
            LoaiDocGias[0].DocGias = (from dg in DocGias where dg.MaLoaiDocGia == "LDG001" select dg).ToList();
            LoaiDocGias[1].DocGias = (from dg in DocGias where dg.MaLoaiDocGia == "LDG002" select dg).ToList();
            LoaiDocGias[2].DocGias = (from dg in DocGias where dg.MaLoaiDocGia == "LDG003" select dg).ToList();
            LoaiDocGias[3].DocGias = (from dg in DocGias where dg.MaLoaiDocGia == "LDG004" select dg).ToList();
            //Nhân Viên - Phiếu mượn
            NhanViens[0].PhieuMuons = (from pm in PhieuMuons where pm.MaNhanVien == "NV001" select pm).ToList();
            NhanViens[1].PhieuMuons = (from pm in PhieuMuons where pm.MaNhanVien == "NV002" select pm).ToList();
            NhanViens[2].PhieuMuons = (from pm in PhieuMuons where pm.MaNhanVien == "NV003" select pm).ToList();
            NhanViens[3].PhieuMuons = (from pm in PhieuMuons where pm.MaNhanVien == "NV004" select pm).ToList();
            //Nhân Viên - Phiếu trả
            NhanViens[0].PhieuTras = (from pt in PhieuTras where pt.MaNhanVien == "NV001" select pt).ToList();
            NhanViens[1].PhieuTras = (from pt in PhieuTras where pt.MaNhanVien == "NV002" select pt).ToList();
            NhanViens[2].PhieuTras = (from pt in PhieuTras where pt.MaNhanVien == "NV003" select pt).ToList();
            NhanViens[3].PhieuTras = (from pt in PhieuTras where pt.MaNhanVien == "NV004" select pt).ToList();
            //Nhân Viên - Phiếu phạt
            NhanViens[0].PhieuPhats = (from pp in PhieuPhats where pp.MaNhanVien == "NV001" select pp).ToList();
            NhanViens[1].PhieuPhats = (from pp in PhieuPhats where pp.MaNhanVien == "NV002" select pp).ToList();
            NhanViens[2].PhieuPhats = (from pp in PhieuPhats where pp.MaNhanVien == "NV003" select pp).ToList();
            NhanViens[3].PhieuPhats = (from pp in PhieuPhats where pp.MaNhanVien == "NV004" select pp).ToList();

            ////Tạo sách trả của PT001 ứng với PM001
            //PhieuTras[0].SachTras.Add((from s in Sachs where s.MaSach == "S001" select s).First());
            //PhieuTras[0].SachTras.Add((from s in Sachs where s.MaSach == "S003" select s).First());
            ////Tạo sách trả của PT002 ứng với PM001
            //PhieuTras[1].SachTras.Add((from s in Sachs where s.MaSach == "S005" select s).First());
            ////Tạo sách trả của PT003 ứng với PM010
            //PhieuTras[2].SachTras.Add((from s in Sachs where s.MaSach == "S005" select s).First());
            ////Tạo sách trả của PT004 ứng với PM005
            //PhieuTras[3].SachTras.Add((from s in Sachs where s.MaSach == "S001" select s).First());
            //PhieuTras[3].SachTras.Add((from s in Sachs where s.MaSach == "S005" select s).First());
            ////Tạo sách trả của PT005 ứng với PM003
            //PhieuTras[4].SachTras.Add((from s in Sachs where s.MaSach == "S006" select s).First());
            //PhieuTras[4].SachTras.Add((from s in Sachs where s.MaSach == "S008" select s).First());
            //PhieuTras[4].SachTras.Add((from s in Sachs where s.MaSach == "S009" select s).First());
        }

        public static string ChuanHoaTen(string Ten)
        {
            string KetQua = "";
            Ten = Ten.Trim().ToLower();//.Trim(): xóa khoảng trắng ở đầu và cuối chuỗi. .ToLower(): chuyển chuỗi về chữ thường
            for (int i = 0; i < Ten.Length; i++)
            {
                if (i == 0)
                {
                    KetQua += Ten[i].ToString().ToUpper(); // .ToUpper(): chuyển thành chữ in hoa
                }
                else
                {
                    KetQua += Ten[i];
                }
                if (Ten[i] == ' ')
                {
                    while (Ten[i] == ' ')
                    {
                        i++;
                    }
                    KetQua += Ten[i].ToString().ToUpper();
                }
            }
            return KetQua.ToString();
        }
        public static string ChuanHoaMa(string Ma)
        {
            int length = Ma.Length;
            string str = "";
            for (int i = 0; i < length; i++)
            {
                if (Ma[i] != ' ') str += Ma[i];
            }
            return str.ToUpper();
        }

        private void TSMI_DocGia_Click(object sender, EventArgs e)
        {
            FORM_DocGia dg = new FORM_DocGia();
            dg.ShowDialog();
        }
        private void TSMI_Sach_Click(object sender, EventArgs e)
        {
            FORM_Sach frm_Sach = new FORM_Sach();
            frm_Sach.ShowDialog();
        }
    }
}
