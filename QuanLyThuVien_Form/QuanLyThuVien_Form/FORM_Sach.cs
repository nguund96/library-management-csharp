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
    public partial class FORM_Sach : Form
    {
        public FORM_Sach()
        {
            InitializeComponent();
        }

        private void FORM_Sach_Load(object sender, EventArgs e)
        {
            FORM_MAIN.TaoDataBase();


            cmb_TieuChiTK.Items.Add("Mã Sách");
            cmb_TieuChiTK.Items.Add("Tên Sách");
            cmb_TieuChiTK.Items.Add("Tên Tác Giả");
            cmb_TieuChiTK.SelectedIndex = 0;

            cmb_SXTheo.Items.Add("Mã Sách");
            cmb_SXTheo.Items.Add("Tên Sách");
            cmb_SXTheo.Items.Add("Tên Tác Giả");
            cmb_SXTheo.Items.Add("Thể Loại");
            cmb_SXTheo.Items.Add("Vị Trí");
            cmb_SXTheo.Items.Add("Ngôn Ngữ");
            cmb_SXTheo.SelectedIndex = 0;

            cmb_TieuChiSX.Items.Add("Tăng Dần");
            cmb_TieuChiSX.Items.Add("Giảm Dần");
            cmb_TieuChiSX.SelectedIndex = 0;

            lsvDanhSachSach.Columns.Add("STT", 35);
            lsvDanhSachSach.Columns.Add("Mã Sách", 70);
            lsvDanhSachSach.Columns.Add("Tên Sách", 150);
            lsvDanhSachSach.Columns.Add("Tác Giả", 150);
            lsvDanhSachSach.Columns.Add("Thể Loại", 150);
            lsvDanhSachSach.Columns.Add("Nhà Xuất Bản", 150);
            lsvDanhSachSach.Columns.Add("Ngôn Ngữ", 80);
            lsvDanhSachSach.Columns.Add("Vị Trí", 50);
            lsvDanhSachSach.Columns.Add("Số Trang", 60);

            CapNhatListView();
        }
        private void cmb_SXTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_SXTheo.SelectedIndex >= 2)
            {
                cmb_TieuChiSX.Visible = false;
                lblTieuChiSX.Visible = false;
            }
            else
            {
                cmb_TieuChiSX.Visible = true;
                lblTieuChiSX.Visible = true;
            }
        }
        public void CapNhatListView()
        {
            lsvDanhSachSach.Items.Clear();
            int count = FORM_MAIN.Sachs.Count;
            for (int i = 0; i < count; i++)
            {
                Sach s = FORM_MAIN.Sachs[i];
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(s.MaSach);
                item.SubItems.Add(s.TenSach);
                item.SubItems.Add(s.TacGia.TenTacGia);
                item.SubItems.Add(s.TheLoai.TenTheLoai);
                item.SubItems.Add(s.NhaXuatBan.TenNXB);
                item.SubItems.Add(s.NgonNgu);
                item.SubItems.Add(s.MaViTri);
                item.SubItems.Add(s.SoTrang.ToString());
                lsvDanhSachSach.Items.Add(item);
            }
        }
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            int count = lsvDanhSachSach.Items.Count;
            bool TimThay = false;
            for (int i = 0; i < count; i++)
            {
                lsvDanhSachSach.Items[i].BackColor = Color.White;
            }
            if (txt_Khoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập khóa cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            for (int i = 0; i < count; i++)
            {
                if (cmb_TieuChiTK.SelectedIndex == 0 && lsvDanhSachSach.Items[i].SubItems[1].Text == FORM_MAIN.ChuanHoaMa(txt_Khoa.Text)) //Tìm theo mã sách
                {
                    lsvDanhSachSach.Items[i].BackColor = Color.SkyBlue;
                    TimThay = true;
                    break;
                }
                else if (cmb_TieuChiTK.SelectedIndex == 1 && lsvDanhSachSach.Items[i].SubItems[2].Text == FORM_MAIN.ChuanHoaTen(txt_Khoa.Text)) //Tìm theo tên sách
                {
                    lsvDanhSachSach.Items[i].BackColor = Color.SkyBlue;
                    TimThay = true;
                }
                else if (lsvDanhSachSach.Items[i].SubItems[3].Text == FORM_MAIN.ChuanHoaTen(txt_Khoa.Text)) //Tìm theo tên tác giả
                {
                    lsvDanhSachSach.Items[i].BackColor = Color.SkyBlue;
                    TimThay = true;
                }
            }
            if(!TimThay)
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_SapXep_Click(object sender, EventArgs e)
        {
            if(cmb_SXTheo.SelectedIndex == 0)//SX theo mã sách
            {
                if(cmb_TieuChiSX.SelectedIndex == 0)//SX tăng dần
                {
                    FORM_MAIN.Sachs.OrderBy(s => s.MaSach);
                }
                else//SX giảm dần
                {
                    FORM_MAIN.Sachs.OrderByDescending(s => s.MaSach);
                }
            }
            else if (cmb_SXTheo.SelectedIndex == 1)//SX theo tên sách
            {
                if (cmb_TieuChiSX.SelectedIndex == 0)//SX tăng dần
                {
                    FORM_MAIN.Sachs.OrderBy(s => s.TenSach);
                }
                else//SX giảm dần
                {
                    FORM_MAIN.Sachs.OrderByDescending(s => s.TenSach);
                }
            }
            else if (cmb_SXTheo.SelectedIndex == 2)//SX theo tên tác giả
            {
                FORM_MAIN.Sachs.OrderBy(s => s.TacGia.TenTacGia);
            }
            else if (cmb_SXTheo.SelectedIndex == 3)//SX theo thể loại
            {
                FORM_MAIN.Sachs.OrderBy(s => s.TheLoai.TenTheLoai);
            }
            else if (cmb_SXTheo.SelectedIndex == 4)//SX theo vị trí
            {
                FORM_MAIN.Sachs.OrderBy(s => s.MaViTri);
            }
            else if (cmb_SXTheo.SelectedIndex == 5)//SX theo ngôn ngữ
            {
                FORM_MAIN.Sachs.OrderBy(s => s.NgonNgu);
            }
            CapNhatListView();
        }
        private void btn_ThemSach_Click(object sender, EventArgs e)
        {

        }
    }
}
