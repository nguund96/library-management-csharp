using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    class Program
    {
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
                TenTheLoai = "Van hoc"
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
                TenSach = "Viet Bac           ",
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
                TenSach = "Tu Ay            ",
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
                TenSach = "Tho To Huu      ",
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
                TenSach = "Dao Hoang       ",
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
                TenSach = "Que Nguoi       ",
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
                TenSach = "Khach No        ",
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
                TenSach = "Gio Long        ",
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
                TenSach = "Chi Pheo        ",
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
                TenSach = "Luom            ",
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
                TenSach = "Chieu Chieu      ",
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
            });
            NhanViens.Add(new NhanVien()
            {
                MaNhanVien = "NV002",
                TenNhanVien = "Le Thi B",
            });
            NhanViens.Add(new NhanVien()
            {
                MaNhanVien = "NV003",
                TenNhanVien = "Tran Van C",
            });
            NhanViens.Add(new NhanVien()
            {
                MaNhanVien = "NV004",
                TenNhanVien = "Nguyen Hoang D",
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
                DiaChi = "Thu Duc ",
                SoCMND = "241587935",
                SDT = "0969741193",
                MaLoaiDocGia = "LDG004",
                LoaiDocGia = (from ldg in LoaiDocGias where ldg.MaLoaiDocGia == "LDG004" select ldg).First()
            });
            DocGias.Add(new DocGia()
            {
                MaDocGia = "DG002",
                TenDocGia = "Tran Anh Son  ",
                DiaChi = "Quan 1  ",
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
                DiaChi = "Quan 9  ",
                SoCMND = "21247084",
                SDT = "0169458234",
                MaLoaiDocGia = "LDG002",
                LoaiDocGia = (from ldg in LoaiDocGias where ldg.MaLoaiDocGia == "LDG002" select ldg).First()
            });
            DocGias.Add(new DocGia()
            {
                MaDocGia = "DG005",
                TenDocGia = "Heu Ly        ",
                DiaChi = "Go Vap     ",
                SoCMND = "21244562",
                SDT = "0169447895",
                MaLoaiDocGia = "LDG001",
                LoaiDocGia = (from ldg in LoaiDocGias where ldg.MaLoaiDocGia == "LDG001" select ldg).First()
            });
            DocGias.Add(new DocGia()
            {
                MaDocGia = "DG006",
                TenDocGia = "Hoai Thuong",
                DiaChi = "Quan 7  ",
                SoCMND = "21244102",
                SDT = "0169474155",
                MaLoaiDocGia = "LDG002",
                LoaiDocGia = (from ldg in LoaiDocGias where ldg.MaLoaiDocGia == "LDG002" select ldg).First()
            });
            DocGias.Add(new DocGia()
            {
                MaDocGia = "DG007",
                TenDocGia = "Vo Huu Nhan",
                DiaChi = "Thu Duc   ",
                SoCMND = "21412852",
                SDT = "016944897",
                MaLoaiDocGia = "LDG003",
                LoaiDocGia = (from ldg in LoaiDocGias where ldg.MaLoaiDocGia == "LDG003" select ldg).First()
            });
            DocGias.Add(new DocGia()
            {
                MaDocGia = "DG008",
                TenDocGia = "Hoang Bao  ",
                DiaChi = "Quan 7  ",
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
        

        public static void Nguu1()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 1: Danh sach cac doc gia bi tre han va so ngay tre");

            var DSPM_ChuaTraHetSach =
                from pm in PhieuMuons
                where pm.ChiTietPhieuMuons.Count() > pm.PhieuTras.Sum(pt => pt.SoLuongSachTra)
                select pm;

            var DS =
                from pm in DSPM_ChuaTraHetSach
                group pm by pm.DocGia into g
                select new { DocGia = g.Key, DanhSachPhieuMuons = g };
            foreach (var v in DS)
            {
                Console.WriteLine("\n-Ma Doc Gia: {0}      Ten Doc Gia: {1}", v.DocGia.MaDocGia, v.DocGia.TenDocGia);
                foreach (var pm in v.DanhSachPhieuMuons)
                {
                    TimeSpan SoNgayTre = DateTime.Now - pm.NgayMuon.AddDays(pm.ThoiGianMuon);
                    if (pm.NgayMuon.AddDays(pm.ThoiGianMuon) < DateTime.Now)
                    {
                        Console.WriteLine("   +Ma Phieu Muon: {0}     Ngay Muon: {1}    Thoi Gian Muon: {2}    So Ngay Tre: {3}",
                            pm.MaPhieuMuon, pm.NgayMuon.ToString("dd/MM/yyy"), pm.ThoiGianMuon, SoNgayTre.Days);
                    }
                }
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Nguu2()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 2: Danh sach cac sach dang duoc muon");
            var DS = (
                from ct in ChiTietPhieuMuons
                select ct.Sach).ToList();
            var DSSach = DS.Distinct(); // Loại bỏ sự trùng lặp. LinQ 46
            Console.WriteLine("Ma Sach |       Ten Sach     |    So Luong Muon");
            foreach (var s in DSSach)
            {
                Console.WriteLine("{0}\t{1}\t\t{2}", s.MaSach, s.TenSach, s.ChiTietPhieuMuons.Count());
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Nguu3()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 3: So tien phat cua cac doc gia bi phat");
            var DS =
                from pp in PhieuPhats
                group pp by pp.PhieuMuon.DocGia into g
                select new { _DocGia = g.Key, SoTienPhat = g.Sum(pp => pp.SoTienPhat) };
            foreach (var v in DS) 
            {
                Console.WriteLine("Ma Doc Gia: {0}\tTen Doc Gia: {1}\tSo Tien Phat: {2}",v._DocGia.MaDocGia,v._DocGia.TenDocGia,v.SoTienPhat);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Nguu4()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 4: Danh sach cac doc gia tra sach dung thoi han");
            var DS =
                from pt in PhieuTras
                where pt.NgayTra.Date <= pt.PhieuMuon.NgayMuon.AddDays(pt.PhieuMuon.ThoiGianMuon).Date
                select pt;
            var DSPT =
                from pt in DS
                group pt by pt.PhieuMuon.DocGia into g
                select new { _DocGia = g.Key, _PhieuTras = g };
            foreach(var v in DSPT)
            {
                Console.WriteLine("\n-Ma Doc Gia: {0}   Ten Doc Gia: {1}", v._DocGia.MaDocGia,v._DocGia.TenDocGia);
                foreach(var pt in v._PhieuTras)
                {
                    Console.WriteLine("   +Ma Phieu Tra: {0}  Ngay Tra: {1}   Ngay Muon: {2}   Thoi Gian Muon: {3}",
                        pt.MaPhieuTra, pt.NgayTra.ToString("dd/MM/yyyy"), pt.PhieuMuon.NgayMuon.ToString("dd/MM/yyyy"), pt.PhieuMuon.ThoiGianMuon);
                }
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Nguu5()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 5: Nhung tac gia co nhieu hon 2 sach trong thu vien");
            //var DSTG =
            //    from tg in TacGias
            //    orderby tg.Sachs.Count()
            //    select tg;
            var DSTG = TacGias.OrderBy(s => s.Sachs.Count()); //Sắp xếp tác giả theo số lượng sách tăng dần
            var DS = DSTG.SkipWhile(tg => tg.Sachs.Count() <= 2); //Bỏ qua những tác giả có ít hơn 3 sách
            foreach(var tg in DS)
            {
                Console.WriteLine("Ma Tac Gia: {0}\tTen Tac Gia: {1}\tSo Luong Sach: {2}", tg.MaTacGia,tg.TenTacGia,tg.Sachs.Count());
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Nguu6()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 6: Phieu muon gan day nhat");
            var PMGN = PhieuMuons.Max(pm => pm.NgayMuon);
            var DS =
                from pm in PhieuMuons
                where pm.NgayMuon.Date == PMGN.Date
                select pm;
            foreach(var pm in DS)
            {
                Console.WriteLine("Ma Phieu Muon: {0}\tNgay Muon: {1}\tThoi Gian Muon: {2}\tMa Doc Gia Muon: {3}\tMa NVQL: {4}",
                    pm.MaPhieuMuon,pm.NgayMuon.ToString("dd/MM/yyyy"),pm.ThoiGianMuon,pm.MaDocGia,pm.MaNhanVien);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Nguu7()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 7: Sach duoc muon nhieu nhat");
            var DS =
                from s in Sachs
                where s.ChiTietPhieuMuons.Count() == Sachs.Max(n => n.ChiTietPhieuMuons.Count())
                select s;
            foreach(var s in DS)
            {
                Console.WriteLine("Ma Sach: {0}\tTen Sach: {1}\tSo Lan Duoc Muon: {2}", s.MaSach, s.TenSach, s.ChiTietPhieuMuons.Count());
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Nguu8()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 8: Tac gia co nhieu sach nhat");
            /*
            var TG_NhieuSachNhat =
                    from tg in TacGias
                    where tg.Sachs.Count() == TacGias.Max(tg => tg.Sachs.Count())
                    select tg;
            */
            var DSTG =
                from tg in TacGias
                select new { _TacGia = tg, _SoLuongSach = tg.Sachs.Count() };
            var TG_NhieuSachNhat =
                from tg in DSTG
                where tg._SoLuongSach == DSTG.Max(t => t._SoLuongSach)
                select tg;
            foreach(var tg in TG_NhieuSachNhat)
            {
                Console.WriteLine("Ma TG: {0}\tTen Tac Gia: {1}\tSo Luong Sach: {2}", tg._TacGia.MaTacGia, tg._TacGia.TenTacGia, tg._SoLuongSach);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Nguu9()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 9: Nhung sach co ten bat dau bang chu D");
            var DS =
                from s in Sachs
                where s.TenSach.Trim().Substring(0, 1) == "D"
                select s;
            foreach(var s in DS)
            {
                Console.WriteLine("Ma Sach: {0}\tTen Sach: {1}", s.MaSach, s.TenSach);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Nguu10()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 10: So luong phieu muon, phieu tra va phieu phat do moi nhan vien lap");
            var DS =
                from nv in NhanViens
                select new {_NhanVien = nv ,SoLuongPhieuMuon = nv.PhieuMuons.Count(), SoLuongPhieuTra = nv.PhieuTras.Count(), SoLuongPhieuPhat = nv.PhieuPhats.Count() };
            foreach(var v in DS)
            {
                Console.WriteLine("-Ma NV: {0}\tTen NV: {1}", v._NhanVien.MaNhanVien, v._NhanVien.TenNhanVien);
                Console.WriteLine("   +SL Phieu Muon: {0}\tSL Phieu Tra: {1}\t   SL Phieu Phat: {2}", v.SoLuongPhieuMuon, v.SoLuongPhieuTra, v.SoLuongPhieuPhat);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        public static void Son1()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 11: Thong tin chi tiet cac doc gia\n");
            Console.WriteLine("MaDG\t|\tTenDG\t|SoCMND\t\t|SDT\t |\tDiaChi");
            foreach (var dg in DocGias)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", dg.MaDocGia, dg.TenDocGia, dg.SoCMND, dg.SDT, dg.DiaChi);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Son2()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            var DSTenDocGia =
                from w in DocGias
                orderby w.TenDocGia
                select w.TenDocGia;
            Console.WriteLine("Cau 12: Danh sach ten cac doc gia (alpha-be):\n");
            foreach (var w in DSTenDocGia)
            {
                Console.WriteLine(w);
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Son3()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 13: Sap xep ten cac quyen sach theo do dai ten");
            var DSQuyenSach =
                from w in Sachs
                orderby w.TenSach.Trim().Length
                select w;

            Console.WriteLine("Danh sach cac quyen sach (by length):");
            foreach (var w in DSQuyenSach)
            {
                Console.WriteLine(w.TenSach);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Son4()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            int stt = 1;
            Console.WriteLine("Cau 14: So luong sach va chi tiet sach cua tung nha xuat ban");

            foreach (var tl in NhaXuatBans)
            {
                Console.WriteLine("Nha xuat ban: {0}", tl.TenNXB);
                Console.WriteLine("Ma Sach |         Ten Sach          |   Ngon Ngu    | Vi Tri |  Ma TL | Ma NXB |Ma TG | So Trang");
                foreach (var s in tl.Sachs)
                {
                    Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", s.MaSach, s.TenSach, s.NgonNgu, s.MaViTri, s.MaTheLoai, s.MaNXB, s.MaTacGia, s.SoTrang);
                }
                Console.WriteLine("=> So luong sach cua nha xuat ban {0} la: {1}\n", tl.TenNXB, tl.Sachs.Count);
                stt++;
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
        public static void Son5()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 15: Liet ke cac sach theo tung the loai");
            var SachGroups =
                from s in Sachs
                group s by s.TheLoai into g
                select new { TheLoai = g.Key, S = g };

            foreach (var ls in SachGroups)
            {
                Console.WriteLine("- Ma the loai: {0} - Ten the loai: {1}", ls.TheLoai.MaTheLoai, ls.TheLoai.TenTheLoai);
                foreach (var s in ls.S)
                {
                    Console.WriteLine(" + Ma Sach: {0}              Ten sach: {1}", s.MaSach, s.TenSach);
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Son6()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 16: Liet ke cac doc gia theo tung loai doc gia");
            var DGGroups =
                from dg in DocGias
                group dg by dg.LoaiDocGia into g
                select new { Loai = g.Key, S = g };

            foreach (var ls in DGGroups)
            {
                Console.WriteLine("- Ma loai doc gia: {0} - Ten loai doc gia: {1}", ls.Loai.MaLoaiDocGia, ls.Loai.TenLoaiDocGia);
                foreach (var s in ls.S)
                {
                    Console.WriteLine(" + Ma Doc Gia: {0}              Ten doc gia: {1}", s.MaDocGia, s.TenDocGia);
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Son7()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 17: Chi Tiet Phieu Muon Sach Theo Tung Thang Do Nhan Vien Giao Dich");
            var HDGroups = from o in PhieuMuons
                           group o by o.NgayMuon.Month into mg
                           select new { Year = mg.Key, HDs = mg };
            foreach (var y in HDGroups)
            {
                Console.WriteLine("Thang: {0}   Phieu muon....", y.Year);
                foreach (var o in y.HDs)
                {
                    Console.WriteLine("Ma PHM: {0}              Ngay muon: {1:dd/MM/yy}       NV quan li: {2}", o.MaPhieuMuon, o.NgayMuon, o.NhanVien.TenNhanVien);
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Son8()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 18: Chi Tiet Phieu Tra Sach Theo Tung Ngay Do Nhan Vien Giao Dich");
            var HDGroups = from o in PhieuTras
                           group o by o.NgayTra.Day into ng
                           select new { Year = ng.Key, HDs = ng };
            foreach (var x in HDGroups)
            {
                Console.WriteLine("Ngay: {0}   Phieu tra....", x.Year);
                foreach (var o1 in x.HDs)
                {
                    Console.WriteLine("Ma PT: {0}              Ngay tra: {1:dd/MM/yy}       NV quan li: {2}", o1.MaPhieuTra, o1.NgayTra, o1.NhanVien.TenNhanVien);
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Son9()
        {

            Console.WriteLine("------------------------------------------------------------------------------");
            var a = from pm in PhieuTras
                    where pm.NgayTra < new DateTime(2015, 6, 12)
                    select pm;
            Console.WriteLine("Cau 19: Nhung phieu tra lap truoc ngay 12 thang 06 nam 2015");
            foreach (var p in a)
            {
                Console.WriteLine("-Ma Phieu Tra:{0}   Ngay Tra:{1}", p.MaPhieuTra, p.NgayTra.ToString("dd/MM/yyyy"));
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Son10()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 20: Chi tiet phieu phat cua cac doc gia bi phat");
            var DGGroups =
                from dg in PhieuPhats
                group dg by dg.PhieuMuon into g
                select new { Loai = g.Key, S = g };

            foreach (var ls in DGGroups)
            {
                Console.WriteLine("- Ma doc gia: {0} - Ten doc gia: {1}", ls.Loai.MaDocGia, ls.Loai.DocGia.TenDocGia);
                Console.WriteLine("| MPP |    Ly do phat    | Ngay lap bien ban | Nhan vien lap bien ban phat |");
                foreach (var s in ls.S)
                {
                    Console.WriteLine(" {0}\t{1}\t{2}\t{3}", s.MaPhieuPhat, s.LyDoPhat, s.NgayPhat.ToString("dd/MM/yyyy"), s.NhanVien.TenNhanVien);
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Son11()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            var a = from pp in PhieuPhats
                    where pp.NgayPhat < new DateTime(2015, 11, 12)
                    select pp;
            Console.WriteLine("Cau 31: Nhung phieu phat lap truoc ngay 12 thang 11 nam 2015");
            foreach (var p in a)
            {
                Console.WriteLine("Ma Phieu Phat:{0}\tNgay Phat:{1}", p.MaPhieuPhat, p.NgayPhat.ToString("dd/MM/yyyy"));
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine(); Console.WriteLine();
        }

        //Phieu muon thoi gian lau nhat
        public static void Thanh1()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.Write("Cau 21: Phieu muon thoi gian lau nhat : ");

            var thoigianMuon = from time in PhieuMuons
                               where time.ThoiGianMuon == PhieuMuons.Max(n => n.ThoiGianMuon)
                               select time;

            foreach (var nh in thoigianMuon)
            {
                Console.WriteLine("{0}", nh.ThoiGianMuon);
                Console.WriteLine("Ma DG |   Ten Doc Gia  | Ma NVQL  | Ma Phieu Muon | Ngay Muon | Thoi Gian Muon");
                Console.WriteLine("{0}\t{1}\t  {2}\t\t{3}\t  {4}\t{5}",nh.MaDocGia,nh.DocGia.TenDocGia,nh.MaNhanVien,nh.MaPhieuMuon,nh.NgayMuon.ToString("dd/MM/yyyy"),nh.ThoiGianMuon);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine(); Console.WriteLine();
        }
        //Danh sach Sach xep theo Alphabet
        public static void Thanh2()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            var tenSach = from ts in Sachs
                          orderby ts.TenSach
                          select ts;
            Console.WriteLine("Cau 22 : Danh sach Sach xep theo Alphabet (Theo ten sach) :");
            Console.WriteLine("Ten Sach              | Tac Gia       |   Nha XB   | So trang | Vi Tri");
            foreach (var ts in tenSach)
            {
                Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}", ts.TenSach, ts.TacGia.TenTacGia, ts.NhaXuatBan.TenNXB, ts.SoTrang, ts.ViTri.MaViTri);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        // Dem so sach co trong thu vien
        public static void Thanh3()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            var Count = (from ts in Sachs
                         select ts).Count();
            Console.WriteLine("Cau 23: So sach co trong thu vien : {0}", Count);
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        //Tong so tien phat thu tu phieu phat cua tung nhan vien lap phieu
        public static void Thanh4()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            var TongPhat = from pp in PhieuPhats
                           group pp by pp.MaNhanVien into g
                           select new
                           {
                               MaNVPhat = g.Key,
                               TongTien = g.Sum(pp => pp.SoTienPhat),
                               Sophieu = g.Count()
                           };
            Console.WriteLine("Cau 24: Tong so tien phat :");
            int a = 1;
            foreach (var pp in TongPhat)
            {
                Console.WriteLine("  {3}. Nhan Vien {0} : tong so tien thu duoc : {1} VND / {2} so phieu phat", pp.MaNVPhat, pp.TongTien, pp.Sophieu, a);
                a++;
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        //Ten doc gia : sach da muon
        public static void Thanh5()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            var gr = from pm in PhieuMuons
                     group pm by pm.DocGia into g
                     select new { Remainder = g.Key, Ds = g };
            Console.WriteLine("Cau 25: Liet ke doc gia muon sach");
            foreach(var p in gr)
            {
                Console.WriteLine("-{0}",p.Remainder.TenDocGia);
                var DSS =
                    from s in p.Ds
                    from s1 in s.ChiTietPhieuMuons
                    select s1.Sach;
                DSS = DSS.Distinct();
                foreach(var s in DSS)
                {
                    Console.WriteLine("   +Ma Sach: {0}    +Ten Sach: {1}", s.MaSach, s.TenSach);
                }
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        // Danh sach doc gia co ho Nguyen
        public static void Thanh6()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            var Ho = DocGias
                .Where(p => p.TenDocGia.StartsWith("Nguyen"));
            Console.WriteLine("Cau 26: Danh sach doc gia co ho Nguyen:");
            Console.WriteLine("Ma DG | Ten Doc Gia");
            foreach (var p in Ho)
            {
                Console.WriteLine("{0}\t{1}", p.MaDocGia,p.TenDocGia);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        //Nhung doc gia muon nhieu hon 2 sach
        public static void Thanh7()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            //Lien ket cac nhom.
            var GomNhom = from i in PhieuMuons
                          join j in DocGias on i.MaDocGia equals j.MaDocGia
                          join k in ChiTietPhieuMuons on i.MaPhieuMuon equals k.MaPhieuMuon into g
                          select new
                          {
                              TenDocGia = j.TenDocGia,
                              SoLuong = g.Count()
                          };

            var dg2 = from p in GomNhom
                      where p.SoLuong > 2
                      select new
                      {
                          p.TenDocGia,
                          p.SoLuong,
                      };
            int stt = 1;
            Console.WriteLine("Cau 27: Nhung doc gia muon nhieu hon 2 sach:");
            foreach (var p in dg2)
            {
                Console.WriteLine("{2}.{0} : {1} (quyen sach)", p.TenDocGia, p.SoLuong, stt);
                stt++;
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        //Danh sach doc gia o cung Quan
        public static void Thanh8()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            var a = from dg in DocGias
                    group dg by dg.DiaChi.Trim() into g
                    select new
                    {
                        Remainder = g.Key,
                        Ds = g
                    };

            Console.WriteLine("Cau 28: Nhung khach hang o cung Quan: ");
            foreach (var p in a)
            {
                Console.WriteLine("-{0} ", p.Remainder);
                foreach (var dg in p.Ds)
                {
                    Console.WriteLine("   +{0}  ", dg.TenDocGia);
                }
            }

            //C2
            //foreach (var p in a)
            //{
            //    Console.WriteLine("\n{0} ", p.Remainder);
            //    Console.WriteLine("--------------------- ");

            //    var quan = from dg in DocGias
            //               where dg.DiaChi == p.Remainder
            //               select dg.TenDocGia;
            //    foreach (var q in quan)
            //    {
            //        Console.WriteLine("\n {0}  ", q);
            //    }
            //    Console.WriteLine("--------------------- ");
            //}
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        // Sach co so trang nhieu nhat trong danh sach
        public static void Thanh9()
        {
            Console.WriteLine("------------------------------------------------------------------------------");

            var max = Sachs.OrderByDescending(t => t.SoTrang).First();

            Console.WriteLine("Cau 29: Sach co so trang nhieu nhat:....");
            Console.WriteLine("Ma Sach |   Ten Sach   | So Trang");
            Console.WriteLine("{0}      {1} {2}",max.MaSach, max.TenSach, max.SoTrang);

            Console.WriteLine("------------------------------------------------------------------------------");
        }
        //Chi tiet muon sach cua tung doc gia
        public static void Thanh10()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 30: Chi tiet muon sach cua tung doc gia");
            var ldg = ChiTietPhieuMuons.Join(PhieuMuons, cpm => cpm.MaPhieuMuon, pm => pm.MaPhieuMuon, (cpm, pm) => new
            {
                maDocGia = pm.MaDocGia,
                maSach = cpm.MaSach,
                maPMH = cpm.MaPhieuMuon,
                date = pm.NgayMuon,
            }).Join(DocGias, p => p.maDocGia, dg => dg.MaDocGia, (p, dg) => new { p, dg });

            var DGGroups = from dg in ldg
                           group dg by dg.dg.MaDocGia into g
                           select new { maKH = g.Key, KHs = g };
            foreach (var dg in DGGroups)
            {
                Console.WriteLine("\n*Ma DG: {0}       Chi tiet phieu muon.....", dg.maKH);
                Console.WriteLine("Ten Doc Gia             | Ma PM   |  Ma Sach   |  Ngay Muon ");
                foreach (var p in dg.KHs)
                {
                    Console.WriteLine("{0}           {1}         {2}        {3}", p.dg.TenDocGia, p.p.maPMH, p.p.maSach, p.p.date);

                }

            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        //Linq105 : Left Join
        public static void Thanh11()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau : Liet ke sach va the loai tuong ung, neu khong co the loai thi in ra khong thuoc the loai nao");
            var a = from p in Sachs
                    join c in TheLoais on p.MaTheLoai equals c.MaTheLoai into g
                    from gs in g.DefaultIfEmpty() //sẽ lấy giá trị mặc định nếu như dữ liệu là rỗng (mặc định là null)
                    select new
                    {
                        TheLoai = gs == null ? "Khong thuoc the loai nao" : gs.TenTheLoai,
                        TenSach = p.TenSach
                    };

            foreach (var p in a)
            {
                Console.WriteLine("\n {0} : {1} ", p.TenSach, p.TheLoai);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Thanh12()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Cau 32: Liet ke nhung cuon sach co so trang lon hon 100 va nho hon 200");
            var books = Sachs.OrderBy(book => book.SoTrang)
                                       .SkipWhile(book => book.SoTrang < 100)
                                       .TakeWhile(book => book.SoTrang < 200);

            Console.WriteLine("Ten Sach   |   Ma Sach | So Trang");
            foreach (var dg in books)
            {
                Console.WriteLine("{0}  {1}     {2}", dg.TenSach, dg.MaSach, dg.SoTrang);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        static void Main(string[] args)
        {
            TaoDataBase();

            //Nguu1();
            //Nguu2();
            //Nguu3();
            //Nguu4();
            //Nguu5();
            //Nguu6();
            //Nguu7();
            //Nguu8();
            //Nguu9();
            //Nguu10();

            //Son1();
            //Son2();
            //Son3();
            //Son4();
            //Son5();
            //Son6();
            //Son7();
            //Son8();
            //Son9();
            //Son10();
            //Son11();

            //Thanh1();
            //Thanh2();
            //Thanh3();
            //Thanh4();
            Thanh5();
            //Thanh6();
            //Thanh7();
            //Thanh8();
            //Thanh9();
            //Thanh10();
            //Thanh11();
            //Thanh12();

            //Console.WriteLine("Ma Sach |         Ten Sach          |   Ngon Ngu    | Vi Tri |  Ma TL | Ma NXB |Ma TG | So Trang");
            //foreach (var s in Sachs)
            //{
            //    Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", s.MaSach, s.TenSach, s.NgonNgu, s.MaViTri, s.MaTheLoai, s.MaNXB, s.MaTacGia, s.SoTrang);
            //}

            //Console.WriteLine("Ma DG |   Ten Doc Gia   |  SDT        |   So CMND      | Dia Chi     | Ma Loai DG");
            //foreach(var dg in DocGias)
            //{
            //    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",dg.MaDocGia,dg.TenDocGia,dg.SDT,dg.SoCMND,dg.DiaChi,dg.MaLoaiDocGia);
            //}
        }
    }
}
