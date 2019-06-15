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
    public partial class FORM_NhanVien : Form
    {
        public FORM_NhanVien()
        {
            InitializeComponent();
        }

        private void FORM_NhanVien_Load(object sender, EventArgs e)
        {
            //FORM_MAIN.TaoDataBase();

            cmb_TieuChiTK.Items.Add("Mã nhân viên");
            cmb_TieuChiTK.Items.Add("Tên nhân viên");
            cmb_TieuChiTK.Items.Add("Số điện thoại");
            cmb_TieuChiTK.SelectedIndex = 0;

            cmb_SXTheo.Items.Add("Mã nhân viên");
            cmb_SXTheo.Items.Add("Tên nhân viên");
            cmb_SXTheo.Items.Add("Hệ số lương");
            cmb_SXTheo.SelectedIndex = 0;

            cmb_TieuChiSX.Items.Add("Tăng dần");
            cmb_TieuChiSX.Items.Add("Giảm dần");
            cmb_TieuChiSX.SelectedIndex = 0;

            lsvDanhSachNhanVien.Columns.Add("STT",40);
            lsvDanhSachNhanVien.Columns.Add("Mã Nhân Viên", 80);
            lsvDanhSachNhanVien.Columns.Add("Tên Nhân Viên", 200);
            lsvDanhSachNhanVien.Columns.Add("SĐT", 120);
            lsvDanhSachNhanVien.Columns.Add("Hệ Số Lương", 90);
            lsvDanhSachNhanVien.Columns.Add("SL Phiếu Mượn", 100);
            lsvDanhSachNhanVien.Columns.Add("SL Phiếu Trả", 100);
            lsvDanhSachNhanVien.Columns.Add("SL Phiếu Phạt", 100);

            CapNhatListView();
        }

        private void btn_ThemNhanVien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chỉ có tài khoản của phòng nhân sự mới có tính năng thêm (xóa, sửa) nhân viên!   (Chưa làm)");
        }
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            int count = lsvDanhSachNhanVien.Items.Count;
            bool TimThay = false;
            for(int i = 0; i < count; i++)
            {
                lsvDanhSachNhanVien.Items[i].BackColor = Color.White;
            }

            if (txt_Khoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập khóa cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Khoa.Focus();
                return;
            }

            if(cmb_TieuChiTK.SelectedIndex == 0) // Tìm theo mã
            {
                for(int i = 0; i < count; i++)
                {
                    if(lsvDanhSachNhanVien.Items[i].SubItems[1].Text.ToString().ToUpper() == FORM_MAIN.ChuanHoaMa(txt_Khoa.Text).ToUpper())
                    {
                        lsvDanhSachNhanVien.Items[i].BackColor = Color.SkyBlue;
                        TimThay = true;
                        break;
                    }
                }
            }
            else if(cmb_TieuChiTK.SelectedIndex == 1) //Tìm theo tên
            {
                for (int i = 0; i < count; i++)
                {
                    if (lsvDanhSachNhanVien.Items[i].SubItems[2].Text.ToString().ToUpper() == FORM_MAIN.ChuanHoaTen(txt_Khoa.Text).ToUpper())
                    {
                        lsvDanhSachNhanVien.Items[i].BackColor = Color.SkyBlue;
                        TimThay = true;
                    }
                }
            }
            else // Tìm theo SĐT
            {
                for (int i = 0; i < count; i++)
                {
                    if (lsvDanhSachNhanVien.Items[i].SubItems[3].Text.ToString().ToUpper() == FORM_MAIN.ChuanHoaMa(txt_Khoa.Text).ToUpper())
                    {
                        lsvDanhSachNhanVien.Items[i].BackColor = Color.SkyBlue;
                        TimThay = true;
                        break;
                    }
                }
            }

            if(!TimThay)
            {
                MessageBox.Show("Không tìm thấy \"" + txt_Khoa.Text + "\"!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Khoa.Clear();
                txt_Khoa.Focus();
            }
        }
        private void btn_SapXep_Click(object sender, EventArgs e)
        {
            if(cmb_SXTheo.SelectedIndex == 0) //Sắp xếp theo mã
            {
                if(cmb_TieuChiSX.SelectedIndex == 0) //Tăng dần
                {
                    SapXepTheoMaNV(0);
                }
                else //Giảm dần
                {
                    SapXepTheoMaNV(1);
                }
            }
            else if(cmb_SXTheo.SelectedIndex == 1) //Sắp xếp theo tên nhân viên
            {
                if(cmb_TieuChiSX.SelectedIndex == 0)
                {
                    SapXepTheoTenNV(0);
                }
                else
                {
                    SapXepTheoTenNV(1);
                }
            }
            else //Sắp xếp theo hệ số lương
            {
                if (cmb_TieuChiSX.SelectedIndex == 0)
                {
                    SapXepTheoHSL(0);
                }
                else
                {
                    SapXepTheoHSL(1);
                }
            }
            CapNhatListView();
        }

        public void SapXepTheoMaNV(int TieuChi)
        {
            if(TieuChi == 0) //Tăng dần
            {
                var DSNhanVien =
                    from w in FORM_MAIN.NhanViens
                    orderby w.MaNhanVien
                    select w;
                FORM_MAIN.NhanViens = DSNhanVien.ToList();
            }
            else
            {
                var DSNhanVien =
                    from w in FORM_MAIN.NhanViens
                    orderby w.MaNhanVien descending
                    select w;
                FORM_MAIN.NhanViens = DSNhanVien.ToList();
            }
        }
        public void SapXepTheoTenNV(int TieuChi)
        {
            if (TieuChi == 0) //Tăng dần
            {
                var DSNhanVien =
                    from w in FORM_MAIN.NhanViens
                    orderby w.TenNhanVien
                    select w;
                FORM_MAIN.NhanViens = DSNhanVien.ToList();
            }
            else
            {
                var DSNhanVien =
                    from w in FORM_MAIN.NhanViens
                    orderby w.TenNhanVien descending
                    select w;
                FORM_MAIN.NhanViens = DSNhanVien.ToList();
            }
        }
        public void SapXepTheoHSL(int TieuChi)
        {
            if (TieuChi == 0) //Tăng dần
            {
                var DSNhanVien =
                    from w in FORM_MAIN.NhanViens
                    orderby w.HeSoLuong
                    select w;
                FORM_MAIN.NhanViens = DSNhanVien.ToList();
            }
            else
            {
                var DSNhanVien =
                    from w in FORM_MAIN.NhanViens
                    orderby w.HeSoLuong descending
                    select w;
                FORM_MAIN.NhanViens = DSNhanVien.ToList();
            }
        }
        private void CapNhatListView()
        {
            lsvDanhSachNhanVien.Items.Clear();

            int count = FORM_MAIN.NhanViens.Count;
            for (int i = 0; i < count; i++)
            {
                NhanVien nv = FORM_MAIN.NhanViens[i];
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(nv.MaNhanVien);
                item.SubItems.Add(nv.TenNhanVien);
                item.SubItems.Add(nv.SDT);
                item.SubItems.Add(nv.HeSoLuong.ToString());
                item.SubItems.Add(nv.PhieuMuons.Count.ToString());
                item.SubItems.Add(nv.PhieuTras.Count.ToString());
                item.SubItems.Add(nv.PhieuPhats.Count.ToString());
                lsvDanhSachNhanVien.Items.Add(item);
            }
        }
    }
}
