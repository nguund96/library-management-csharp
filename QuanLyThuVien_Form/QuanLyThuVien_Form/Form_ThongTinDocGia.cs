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
    public partial class Form_ThongTinDocGia : Form
    {
        public Form_ThongTinDocGia()
        {
            InitializeComponent();
        }

        public DocGia dg = new DocGia();

        private void Form_ThongTinDocGia_Load(object sender, EventArgs e)
        {
            txt_MaDocGia.Text = dg.MaDocGia;
            txt_TenDocGia.Text = dg.TenDocGia;
            for (int i = 0; i < FORM_MAIN.LoaiDocGias.Count; i++)
            {
                cmb_LoaiDocGia.Items.Add(FORM_MAIN.LoaiDocGias[i].TenLoaiDocGia);
                if(FORM_MAIN.LoaiDocGias[i].MaLoaiDocGia == dg.MaLoaiDocGia)
                {
                    cmb_LoaiDocGia.SelectedIndex = i;
                }
            }
            txt_CMND.Text = dg.SoCMND;
            txt_SDT.Text = dg.SDT;
            txt_DiaChi.Text = dg.DiaChi;
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            foreach(DocGia _dg in FORM_MAIN.DocGias)
            {
                if(_dg.MaDocGia == dg.MaDocGia)
                {
                    FORM_MAIN.DocGias.Remove(_dg);
                    break;
                }
            }
            this.Close();
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(TrungMaDocGia())
            {
                MessageBox.Show("Mã độc giả \"" + FORM_MAIN.ChuanHoaMa(txt_MaDocGia.Text) + "\" đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaDocGia.Text = dg.MaDocGia;
                txt_MaDocGia.Focus();
            }
            else if(TrungSoCMND())
            {
                MessageBox.Show("Số CMND \"" + FORM_MAIN.ChuanHoaMa(txt_CMND.Text) + "\" đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_CMND.Text = dg.SoCMND;
                txt_CMND.Focus();
            }
            else
            {
                DocGia dg_DaSua = new DocGia();
                dg_DaSua.MaDocGia = FORM_MAIN.ChuanHoaMa(txt_MaDocGia.Text);
                dg_DaSua.TenDocGia = FORM_MAIN.ChuanHoaTen(txt_TenDocGia.Text);
                int count = FORM_MAIN.LoaiDocGias.Count;
                for (int i = 0; i < count; i++)
                {
                    if (FORM_MAIN.LoaiDocGias[i].TenLoaiDocGia == cmb_LoaiDocGia.Text)
                    {
                        dg_DaSua.LoaiDocGia = FORM_MAIN.LoaiDocGias[i];
                        dg_DaSua.MaLoaiDocGia = dg_DaSua.LoaiDocGia.MaLoaiDocGia;
                    }
                }
                dg_DaSua.SoCMND = FORM_MAIN.ChuanHoaMa(txt_CMND.Text);
                dg_DaSua.SDT = FORM_MAIN.ChuanHoaMa(txt_SDT.Text);
                dg_DaSua.DiaChi = FORM_MAIN.ChuanHoaTen(txt_DiaChi.Text);
                dg_DaSua.PhieuMuons = dg.PhieuMuons;

                int count1 = FORM_MAIN.DocGias.Count;
                for(int i = 0; i < count1; i++)
                {
                    if(FORM_MAIN.DocGias[i].MaDocGia == dg.MaDocGia)
                    {
                        FORM_MAIN.DocGias[i] = dg_DaSua;
                        break;
                    }
                }
                this.Close();
            }
        }
        public bool TrungMaDocGia()
        {
            int count = FORM_MAIN.DocGias.Count;
            for(int i = 0; i < count; i++)
            {
                if(FORM_MAIN.DocGias[i].MaDocGia != dg.MaDocGia && FORM_MAIN.DocGias[i].MaDocGia == FORM_MAIN.ChuanHoaMa(txt_MaDocGia.Text))
                {
                    return true;
                }
            }
            return false;
        }
        public bool TrungSoCMND()
        {
            int count = FORM_MAIN.DocGias.Count;
            for (int i = 0; i < count; i++)
            {
                if (FORM_MAIN.DocGias[i].SoCMND != dg.SoCMND && FORM_MAIN.DocGias[i].SoCMND == FORM_MAIN.ChuanHoaMa(txt_CMND.Text))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
