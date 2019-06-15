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
    public partial class Form_ThemDocGia : Form
    {
        public Form_ThemDocGia()
        {
            InitializeComponent();
        }

        private void Form_ThemDocGia_Load(object sender, EventArgs e)
        {
            int count = FORM_MAIN.LoaiDocGias.Count;
            for(int i = 0; i < count; i++)
            {
                cmb_LoaiDG.Items.Add(FORM_MAIN.LoaiDocGias[i].TenLoaiDocGia);
            }
            cmb_LoaiDG.SelectedIndex = 0;
            txt_MaDG.Focus();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(FORM_MAIN.ChuanHoaMa(txt_MaDG.Text) == "")
            {
                MessageBox.Show("Vui lòng nhập mã độc giả có ít nhất 1 ký tự khác khoảng trắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaDG.Clear();
                txt_MaDG.Focus();
            }
            else if(FORM_MAIN.ChuanHoaTen(txt_TenDG.Text) == "")
            {
                MessageBox.Show("Vui lòng nhập tên độc giả có ít nhất 1 ký tự khác khoảng trắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenDG.Clear();
                txt_TenDG.Focus();
            }
            else if (FORM_MAIN.ChuanHoaMa(txt_CMND.Text) == "")
            {
                MessageBox.Show("Vui lòng nhập số CMND có ít nhất 9 ký tự số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_CMND.Clear();
                txt_CMND.Focus();
            }
            else if (FORM_MAIN.ChuanHoaMa(txt_SDT.Text) == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SDT.Clear();
                txt_SDT.Focus();
            }
            else if (FORM_MAIN.ChuanHoaTen(txt_DiaChi.Text) == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ có ít nhất 1 ký tự khác khoảng trắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_DiaChi.Clear();
                txt_DiaChi.Focus();
            }
            else
            {
                if(TrungMaDG(txt_MaDG.Text))
                {
                    MessageBox.Show("Mã độc giả \"" + FORM_MAIN.ChuanHoaMa(txt_MaDG.Text) + "\" đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_MaDG.Clear();
                    txt_MaDG.Focus();
                    return;
                }
                if (TrungSoCMND(txt_CMND.Text))
                {
                    MessageBox.Show("Số CMND \"" + FORM_MAIN.ChuanHoaMa(txt_CMND.Text) + "\" đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_CMND.Clear();
                    txt_CMND.Focus();
                    return;
                }
                ThemDocGia();
                this.Close();
            }
        }

        public void ThemDocGia()
        {
            DocGia dg = new DocGia();
            dg.MaDocGia = FORM_MAIN.ChuanHoaMa(txt_MaDG.Text);
            for(int i = 0; i < FORM_MAIN.LoaiDocGias.Count; i++)
            {
                if(FORM_MAIN.LoaiDocGias[i].TenLoaiDocGia == cmb_LoaiDG.Text)
                {
                    dg.LoaiDocGia = FORM_MAIN.LoaiDocGias[i];
                    dg.MaLoaiDocGia = dg.LoaiDocGia.MaLoaiDocGia;
                    break;
                }
            }
            dg.TenDocGia = FORM_MAIN.ChuanHoaTen(txt_TenDG.Text);
            dg.SoCMND = FORM_MAIN.ChuanHoaMa(txt_CMND.Text);
            dg.SDT = FORM_MAIN.ChuanHoaMa(txt_SDT.Text);
            dg.DiaChi = FORM_MAIN.ChuanHoaTen(txt_DiaChi.Text);
            dg.PhieuMuons = new List<PhieuMuon>();
            FORM_MAIN.DocGias.Add(dg);
        }
        public bool TrungMaDG(string MaDG)
        {
            int count = FORM_MAIN.DocGias.Count;
            for(int i = 0; i < count; i++)
            {
                if(FORM_MAIN.DocGias[i].MaDocGia == FORM_MAIN.ChuanHoaMa(MaDG))
                {
                    return true;
                }
            }
            return false;
        }
        public bool TrungSoCMND(string CMND)
        {
            int count = FORM_MAIN.DocGias.Count;
            for (int i = 0; i < count; i++)
            {
                if (FORM_MAIN.DocGias[i].SoCMND == FORM_MAIN.ChuanHoaMa(CMND))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
