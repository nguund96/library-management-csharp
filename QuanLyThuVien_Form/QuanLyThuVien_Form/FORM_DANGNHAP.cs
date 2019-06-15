using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien_Form
{
    public partial class FORM_DANGNHAP : Form
    {
        public FORM_DANGNHAP()
        {
            InitializeComponent();
        }
        private string TenDangNhap = "nguyenducnguu";
        private string MatKhau = "15121996";
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDanhNhap_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Chưa nhập tên đăng nhập!", "Thông báo");
                txtTenDangNhap.Focus();
            }
            else if(txtMatKhau.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu!", "Thông báo");
                txtMatKhau.Focus();
            }
            else
            {
                if(txtTenDangNhap.Text == TenDangNhap && txtMatKhau.Text == MatKhau)
                {
                    FORM_MAIN fr = new FORM_MAIN();
                    this.Visible = false;
                    fr.ShowDialog();
                    this.Visible = true;
                    if(chbNhoTaiKhoan.Checked == false)
                    {
                        txtTenDangNhap.Clear();
                        txtMatKhau.Clear();
                        txtTenDangNhap.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo");
                }
            }
        }

        private void FORM_DANGNHAP_Load(object sender, EventArgs e)
        {
                        
        }
    }
}
