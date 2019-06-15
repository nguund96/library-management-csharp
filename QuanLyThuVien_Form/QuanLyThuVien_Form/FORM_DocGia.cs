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
    public partial class FORM_DocGia : Form
    {
        public FORM_DocGia()
        {
            InitializeComponent();
        }

        private void FORM_DocGia_Load(object sender, EventArgs e)
        {
            //FORM_MAIN.TaoDataBase();
            
            cmb_TieuChiTK.Items.Add("Mã độc giả");
            cmb_TieuChiTK.Items.Add("Tên độc giả");
            cmb_TieuChiTK.Items.Add("Số CMND");
            cmb_TieuChiTK.SelectedIndex = 0;

            cmb_SXTheo.Items.Add("Mã độc giả");
            cmb_SXTheo.Items.Add("Tên độc giả");
            cmb_SXTheo.Items.Add("Loại độc giả");
            cmb_SXTheo.SelectedIndex = 0;

            cmb_TieuChiSX.Items.Add("Tăng dần");
            cmb_TieuChiSX.Items.Add("Giảm dần");
            cmb_TieuChiSX.SelectedIndex = 0;

            lsvDanhSachDocGia.Columns.Add("STT", 40);
            lsvDanhSachDocGia.Columns.Add("Mã Độc Giả", 80);
            lsvDanhSachDocGia.Columns.Add("Loại ĐG", 150);
            lsvDanhSachDocGia.Columns.Add("Tên Độc Giả", 150);
            lsvDanhSachDocGia.Columns.Add("Số CMND", 125);
            lsvDanhSachDocGia.Columns.Add("Số ĐT", 125);
            lsvDanhSachDocGia.Columns.Add("Địa Chỉ", 230);

            CapNhatListView();
        }

        private void cmb_SXTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_SXTheo.SelectedIndex == 2)
            {
                lblTieuChiSX.Visible = false;
                cmb_TieuChiSX.Visible = false;
            }
            else
            {
                lblTieuChiSX.Visible = true;
                cmb_TieuChiSX.Visible = true;
            }
        }
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            int count = FORM_MAIN.DocGias.Count;
            bool TimThay = false;
            for(int i = 0; i < count; i++)
            {
                lsvDanhSachDocGia.Items[i].BackColor = Color.White;
            }

            if(txt_Khoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập khóa cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Khoa.Focus();
                return;
            }

            if(cmb_TieuChiTK.SelectedIndex == 0) //Tìm theo mã ĐG
            {
                for(int i = 0; i < count; i++)
                {
                    if(lsvDanhSachDocGia.Items[i].SubItems[1].Text == FORM_MAIN.ChuanHoaMa(txt_Khoa.Text))
                    {
                        lsvDanhSachDocGia.Items[i].BackColor = Color.SkyBlue;
                        TimThay = true;
                        break;
                    }
                }
            }
            else if(cmb_TieuChiTK.SelectedIndex == 1) //Tìm theo tên ĐG
            {
                for (int i = 0; i < count; i++)
                {
                    if (lsvDanhSachDocGia.Items[i].SubItems[3].Text == FORM_MAIN.ChuanHoaTen(txt_Khoa.Text))
                    {
                        lsvDanhSachDocGia.Items[i].BackColor = Color.SkyBlue;
                        TimThay = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (lsvDanhSachDocGia.Items[i].SubItems[4].Text == FORM_MAIN.ChuanHoaMa(txt_Khoa.Text))
                    {
                        lsvDanhSachDocGia.Items[i].BackColor = Color.SkyBlue;
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
            if(cmb_SXTheo.SelectedIndex == 0)//SX theo mã ĐG
            {
                if (cmb_TieuChiSX.SelectedIndex == 0)//Tăng dần
                {
                    SapXepMaDG(0);
                }
                else
                {
                    SapXepMaDG(1);
                }
            }
            else if(cmb_SXTheo.SelectedIndex == 1)//SX theo tên ĐG
            {
                if(cmb_TieuChiSX.SelectedIndex == 0)//Tăng dần
                {
                    SapXepTenDG(0);
                }
                else
                {
                    SapXepTenDG(1);
                }
            }
            else //Sắp xếp theo từng loại độc giả
            {
                var DSDocGias =
                    from w in FORM_MAIN.DocGias
                    orderby w.MaLoaiDocGia
                    select w;
                FORM_MAIN.DocGias = DSDocGias.ToList();
            }
            CapNhatListView();
        }


        public void CapNhatListView()
        {
            lsvDanhSachDocGia.Items.Clear();

            int count = FORM_MAIN.DocGias.Count;
            for (int i = 0; i < count; i++)
            {
                DocGia dg = FORM_MAIN.DocGias[i];
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(dg.MaDocGia);
                item.SubItems.Add(dg.LoaiDocGia.TenLoaiDocGia);
                item.SubItems.Add(dg.TenDocGia);
                item.SubItems.Add(dg.SoCMND);
                item.SubItems.Add(dg.SDT);
                item.SubItems.Add(dg.DiaChi);
                lsvDanhSachDocGia.Items.Add(item);
            }
        }
        public void SapXepMaDG(int TieuChi)
        {
            if (TieuChi == 0) //Tăng dần
            {
                var DSTenDocGia =
                    from w in FORM_MAIN.DocGias
                    orderby w.MaDocGia
                    select w;
                FORM_MAIN.DocGias = DSTenDocGia.ToList();
            }
            else
            {
                var DSTenDocGia =
                    from w in FORM_MAIN.DocGias
                    orderby w.MaDocGia descending
                    select w;
                FORM_MAIN.DocGias = DSTenDocGia.ToList();
            }
        }
        public void SapXepTenDG(int TieuChi)
        {
            if (TieuChi == 0) //Tăng dần
            {
                var DSTenDocGia =
                    from w in FORM_MAIN.DocGias
                    orderby w.TenDocGia
                    select w;
                FORM_MAIN.DocGias = DSTenDocGia.ToList();
            }
            else
            {
                var DSTenDocGia =
                    from w in FORM_MAIN.DocGias
                    orderby w.TenDocGia descending
                    select w;
                FORM_MAIN.DocGias = DSTenDocGia.ToList();
            }
        }

        private void btn_ThemDocGia_Click(object sender, EventArgs e)
        {
            Form_ThemDocGia tdg = new Form_ThemDocGia();
            tdg.ShowDialog();
            CapNhatListView();
        }

        private void lsvDanhSachDocGia_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lsvDanhSachDocGia.SelectedItems.Count == 1)
            {
                ListViewItem item = lsvDanhSachDocGia.SelectedItems[0];
                DocGia dg_DangChon = new DocGia();
                int count = FORM_MAIN.DocGias.Count;
                for(int i = 0; i < count ; i++)
                {
                    if(FORM_MAIN.DocGias[i].MaDocGia == item.SubItems[1].Text)
                    {
                        dg_DangChon = FORM_MAIN.DocGias[i];
                        break;
                    }
                }

                Form_ThongTinDocGia info = new Form_ThongTinDocGia();
                info.dg = dg_DangChon;
                info.ShowDialog();
                CapNhatListView();
            }
        }
    }
}
