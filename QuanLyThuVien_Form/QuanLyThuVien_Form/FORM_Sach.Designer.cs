namespace QuanLyThuVien_Form
{
    partial class FORM_Sach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grb_TimKiem = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_Khoa = new System.Windows.Forms.TextBox();
            this.cmb_TieuChiTK = new System.Windows.Forms.ComboBox();
            this.lsvDanhSachSach = new System.Windows.Forms.ListView();
            this.grb_SapXep = new System.Windows.Forms.GroupBox();
            this.lblTieuChiSX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SapXep = new System.Windows.Forms.Button();
            this.cmb_TieuChiSX = new System.Windows.Forms.ComboBox();
            this.cmb_SXTheo = new System.Windows.Forms.ComboBox();
            this.btn_ThemSach = new System.Windows.Forms.Button();
            this.grb_TimKiem.SuspendLayout();
            this.grb_SapXep.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_TimKiem
            // 
            this.grb_TimKiem.Controls.Add(this.label2);
            this.grb_TimKiem.Controls.Add(this.label1);
            this.grb_TimKiem.Controls.Add(this.btn_Tim);
            this.grb_TimKiem.Controls.Add(this.txt_Khoa);
            this.grb_TimKiem.Controls.Add(this.cmb_TieuChiTK);
            this.grb_TimKiem.Location = new System.Drawing.Point(61, 12);
            this.grb_TimKiem.Name = "grb_TimKiem";
            this.grb_TimKiem.Size = new System.Drawing.Size(258, 109);
            this.grb_TimKiem.TabIndex = 9;
            this.grb_TimKiem.TabStop = false;
            this.grb_TimKiem.Text = "Tìm Kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tiêu chí";
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(87, 69);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 23);
            this.btn_Tim.TabIndex = 2;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_Khoa
            // 
            this.txt_Khoa.Location = new System.Drawing.Point(63, 43);
            this.txt_Khoa.Name = "txt_Khoa";
            this.txt_Khoa.Size = new System.Drawing.Size(174, 20);
            this.txt_Khoa.TabIndex = 1;
            // 
            // cmb_TieuChiTK
            // 
            this.cmb_TieuChiTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TieuChiTK.FormattingEnabled = true;
            this.cmb_TieuChiTK.Location = new System.Drawing.Point(63, 17);
            this.cmb_TieuChiTK.Name = "cmb_TieuChiTK";
            this.cmb_TieuChiTK.Size = new System.Drawing.Size(174, 21);
            this.cmb_TieuChiTK.TabIndex = 0;
            // 
            // lsvDanhSachSach
            // 
            this.lsvDanhSachSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvDanhSachSach.FullRowSelect = true;
            this.lsvDanhSachSach.GridLines = true;
            this.lsvDanhSachSach.Location = new System.Drawing.Point(0, 126);
            this.lsvDanhSachSach.Name = "lsvDanhSachSach";
            this.lsvDanhSachSach.Size = new System.Drawing.Size(836, 231);
            this.lsvDanhSachSach.TabIndex = 8;
            this.lsvDanhSachSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachSach.View = System.Windows.Forms.View.Details;
            // 
            // grb_SapXep
            // 
            this.grb_SapXep.Controls.Add(this.lblTieuChiSX);
            this.grb_SapXep.Controls.Add(this.label3);
            this.grb_SapXep.Controls.Add(this.btn_SapXep);
            this.grb_SapXep.Controls.Add(this.cmb_TieuChiSX);
            this.grb_SapXep.Controls.Add(this.cmb_SXTheo);
            this.grb_SapXep.Location = new System.Drawing.Point(517, 13);
            this.grb_SapXep.Name = "grb_SapXep";
            this.grb_SapXep.Size = new System.Drawing.Size(254, 108);
            this.grb_SapXep.TabIndex = 11;
            this.grb_SapXep.TabStop = false;
            this.grb_SapXep.Text = "Sắp Xếp";
            // 
            // lblTieuChiSX
            // 
            this.lblTieuChiSX.AutoSize = true;
            this.lblTieuChiSX.Location = new System.Drawing.Point(15, 45);
            this.lblTieuChiSX.Name = "lblTieuChiSX";
            this.lblTieuChiSX.Size = new System.Drawing.Size(47, 13);
            this.lblTieuChiSX.TabIndex = 4;
            this.lblTieuChiSX.Text = "Tiêu chí";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SX theo";
            // 
            // btn_SapXep
            // 
            this.btn_SapXep.Location = new System.Drawing.Point(95, 68);
            this.btn_SapXep.Name = "btn_SapXep";
            this.btn_SapXep.Size = new System.Drawing.Size(75, 23);
            this.btn_SapXep.TabIndex = 2;
            this.btn_SapXep.Text = "Sắp xếp";
            this.btn_SapXep.UseVisualStyleBackColor = true;
            this.btn_SapXep.Click += new System.EventHandler(this.btn_SapXep_Click);
            // 
            // cmb_TieuChiSX
            // 
            this.cmb_TieuChiSX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TieuChiSX.FormattingEnabled = true;
            this.cmb_TieuChiSX.Location = new System.Drawing.Point(66, 42);
            this.cmb_TieuChiSX.Name = "cmb_TieuChiSX";
            this.cmb_TieuChiSX.Size = new System.Drawing.Size(167, 21);
            this.cmb_TieuChiSX.TabIndex = 1;
            // 
            // cmb_SXTheo
            // 
            this.cmb_SXTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SXTheo.FormattingEnabled = true;
            this.cmb_SXTheo.Location = new System.Drawing.Point(66, 16);
            this.cmb_SXTheo.Name = "cmb_SXTheo";
            this.cmb_SXTheo.Size = new System.Drawing.Size(167, 21);
            this.cmb_SXTheo.TabIndex = 0;
            this.cmb_SXTheo.SelectedIndexChanged += new System.EventHandler(this.cmb_SXTheo_SelectedIndexChanged);
            // 
            // btn_ThemSach
            // 
            this.btn_ThemSach.Location = new System.Drawing.Point(373, 98);
            this.btn_ThemSach.Name = "btn_ThemSach";
            this.btn_ThemSach.Size = new System.Drawing.Size(93, 23);
            this.btn_ThemSach.TabIndex = 10;
            this.btn_ThemSach.Text = "Thêm sách";
            this.btn_ThemSach.UseVisualStyleBackColor = true;
            this.btn_ThemSach.Click += new System.EventHandler(this.btn_ThemSach_Click);
            // 
            // FORM_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 357);
            this.Controls.Add(this.grb_TimKiem);
            this.Controls.Add(this.lsvDanhSachSach);
            this.Controls.Add(this.grb_SapXep);
            this.Controls.Add(this.btn_ThemSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FORM_Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sách";
            this.Load += new System.EventHandler(this.FORM_Sach_Load);
            this.grb_TimKiem.ResumeLayout(false);
            this.grb_TimKiem.PerformLayout();
            this.grb_SapXep.ResumeLayout(false);
            this.grb_SapXep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_Khoa;
        private System.Windows.Forms.ComboBox cmb_TieuChiTK;
        private System.Windows.Forms.ListView lsvDanhSachSach;
        private System.Windows.Forms.GroupBox grb_SapXep;
        private System.Windows.Forms.Label lblTieuChiSX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SapXep;
        private System.Windows.Forms.ComboBox cmb_TieuChiSX;
        private System.Windows.Forms.ComboBox cmb_SXTheo;
        private System.Windows.Forms.Button btn_ThemSach;
    }
}