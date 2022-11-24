namespace DuAn1_Winform
{
    partial class QL_NhanVien
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
            this.dtg_shownhanvien = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.rd_0 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBB_ANh = new System.Windows.Forms.ComboBox();
            this.PTB_Anh = new System.Windows.Forms.PictureBox();
            this.CB_TT0 = new System.Windows.Forms.CheckBox();
            this.CB_TT1 = new System.Windows.Forms.CheckBox();
            this.CB_GT0 = new System.Windows.Forms.CheckBox();
            this.CB_GT1 = new System.Windows.Forms.CheckBox();
            this.Tb_DiaChi = new System.Windows.Forms.TextBox();
            this.Tb_sdt = new System.Windows.Forms.TextBox();
            this.TB_MatKhau = new System.Windows.Forms.TextBox();
            this.tb_HovaTen = new System.Windows.Forms.TextBox();
            this.DTP_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_mA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Them = new FontAwesome.Sharp.IconButton();
            this.BTN_Sua = new FontAwesome.Sharp.IconButton();
            this.BTN_Xoa = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_shownhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTB_Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_shownhanvien
            // 
            this.dtg_shownhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_shownhanvien.Location = new System.Drawing.Point(15, 216);
            this.dtg_shownhanvien.Margin = new System.Windows.Forms.Padding(5);
            this.dtg_shownhanvien.Name = "dtg_shownhanvien";
            this.dtg_shownhanvien.RowHeadersWidth = 51;
            this.dtg_shownhanvien.RowTemplate.Height = 29;
            this.dtg_shownhanvien.Size = new System.Drawing.Size(1782, 1125);
            this.dtg_shownhanvien.TabIndex = 0;
            this.dtg_shownhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_shownhanvien_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 688);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 32);
            this.label10.TabIndex = 13;
            this.label10.Text = "Trạng Thái:";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(159, 163);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.PlaceholderText = "Nhập tên Nhân Viên cần tìm kiếm ...";
            this.tb_Search.Size = new System.Drawing.Size(646, 39);
            this.tb_Search.TabIndex = 14;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 168);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 32);
            this.label11.TabIndex = 15;
            this.label11.Text = "Tìm kiếm:";
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Location = new System.Drawing.Point(159, 78);
            this.rd_1.Margin = new System.Windows.Forms.Padding(5);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(234, 36);
            this.rd_1.TabIndex = 16;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "NV đang làm việc";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_0
            // 
            this.rd_0.AutoSize = true;
            this.rd_0.Location = new System.Drawing.Point(448, 78);
            this.rd_0.Margin = new System.Windows.Forms.Padding(5);
            this.rd_0.Name = "rd_0";
            this.rd_0.Size = new System.Drawing.Size(196, 36);
            this.rd_0.TabIndex = 17;
            this.rd_0.Text = "NV đã nghỉ vc";
            this.rd_0.UseVisualStyleBackColor = true;
            this.rd_0.CheckedChanged += new System.EventHandler(this.rd_0_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_0);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rd_1);
            this.groupBox1.Controls.Add(this.tb_Search);
            this.groupBox1.Controls.Add(this.dtg_shownhanvien);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1825, 1365);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBB_ANh);
            this.groupBox2.Controls.Add(this.PTB_Anh);
            this.groupBox2.Controls.Add(this.CB_TT0);
            this.groupBox2.Controls.Add(this.CB_TT1);
            this.groupBox2.Controls.Add(this.CB_GT0);
            this.groupBox2.Controls.Add(this.CB_GT1);
            this.groupBox2.Controls.Add(this.Tb_DiaChi);
            this.groupBox2.Controls.Add(this.Tb_sdt);
            this.groupBox2.Controls.Add(this.TB_MatKhau);
            this.groupBox2.Controls.Add(this.tb_HovaTen);
            this.groupBox2.Controls.Add(this.DTP_NgaySinh);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_mA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(1858, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(915, 872);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // CBB_ANh
            // 
            this.CBB_ANh.FormattingEnabled = true;
            this.CBB_ANh.Location = new System.Drawing.Point(53, 433);
            this.CBB_ANh.Name = "CBB_ANh";
            this.CBB_ANh.Size = new System.Drawing.Size(242, 40);
            this.CBB_ANh.TabIndex = 33;
            // 
            // PTB_Anh
            // 
            this.PTB_Anh.Location = new System.Drawing.Point(29, 56);
            this.PTB_Anh.Name = "PTB_Anh";
            this.PTB_Anh.Size = new System.Drawing.Size(306, 343);
            this.PTB_Anh.TabIndex = 32;
            this.PTB_Anh.TabStop = false;
            // 
            // CB_TT0
            // 
            this.CB_TT0.AutoSize = true;
            this.CB_TT0.Location = new System.Drawing.Point(53, 811);
            this.CB_TT0.Margin = new System.Windows.Forms.Padding(5);
            this.CB_TT0.Name = "CB_TT0";
            this.CB_TT0.Size = new System.Drawing.Size(147, 36);
            this.CB_TT0.TabIndex = 31;
            this.CB_TT0.Text = "Nghỉ việc";
            this.CB_TT0.UseVisualStyleBackColor = true;
            // 
            // CB_TT1
            // 
            this.CB_TT1.AutoSize = true;
            this.CB_TT1.Location = new System.Drawing.Point(53, 747);
            this.CB_TT1.Margin = new System.Windows.Forms.Padding(5);
            this.CB_TT1.Name = "CB_TT1";
            this.CB_TT1.Size = new System.Drawing.Size(198, 36);
            this.CB_TT1.TabIndex = 30;
            this.CB_TT1.Text = "Đang làm việc";
            this.CB_TT1.UseVisualStyleBackColor = true;
            // 
            // CB_GT0
            // 
            this.CB_GT0.AutoSize = true;
            this.CB_GT0.Location = new System.Drawing.Point(53, 620);
            this.CB_GT0.Margin = new System.Windows.Forms.Padding(5);
            this.CB_GT0.Name = "CB_GT0";
            this.CB_GT0.Size = new System.Drawing.Size(78, 36);
            this.CB_GT0.TabIndex = 29;
            this.CB_GT0.Text = "Nữ";
            this.CB_GT0.UseVisualStyleBackColor = true;
            // 
            // CB_GT1
            // 
            this.CB_GT1.AutoSize = true;
            this.CB_GT1.Location = new System.Drawing.Point(53, 571);
            this.CB_GT1.Margin = new System.Windows.Forms.Padding(5);
            this.CB_GT1.Name = "CB_GT1";
            this.CB_GT1.Size = new System.Drawing.Size(97, 36);
            this.CB_GT1.TabIndex = 28;
            this.CB_GT1.Text = "Nam";
            this.CB_GT1.UseVisualStyleBackColor = true;
            // 
            // Tb_DiaChi
            // 
            this.Tb_DiaChi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tb_DiaChi.Location = new System.Drawing.Point(421, 531);
            this.Tb_DiaChi.Margin = new System.Windows.Forms.Padding(5);
            this.Tb_DiaChi.Name = "Tb_DiaChi";
            this.Tb_DiaChi.Size = new System.Drawing.Size(467, 39);
            this.Tb_DiaChi.TabIndex = 27;
            // 
            // Tb_sdt
            // 
            this.Tb_sdt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tb_sdt.Location = new System.Drawing.Point(421, 677);
            this.Tb_sdt.Margin = new System.Windows.Forms.Padding(5);
            this.Tb_sdt.Name = "Tb_sdt";
            this.Tb_sdt.Size = new System.Drawing.Size(467, 39);
            this.Tb_sdt.TabIndex = 26;
            // 
            // TB_MatKhau
            // 
            this.TB_MatKhau.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TB_MatKhau.Location = new System.Drawing.Point(421, 800);
            this.TB_MatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.TB_MatKhau.Name = "TB_MatKhau";
            this.TB_MatKhau.Size = new System.Drawing.Size(467, 39);
            this.TB_MatKhau.TabIndex = 25;
            // 
            // tb_HovaTen
            // 
            this.tb_HovaTen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_HovaTen.Location = new System.Drawing.Point(421, 267);
            this.tb_HovaTen.Margin = new System.Windows.Forms.Padding(5);
            this.tb_HovaTen.Name = "tb_HovaTen";
            this.tb_HovaTen.Size = new System.Drawing.Size(467, 39);
            this.tb_HovaTen.TabIndex = 24;
            // 
            // DTP_NgaySinh
            // 
            this.DTP_NgaySinh.Location = new System.Drawing.Point(421, 401);
            this.DTP_NgaySinh.Margin = new System.Windows.Forms.Padding(5);
            this.DTP_NgaySinh.Name = "DTP_NgaySinh";
            this.DTP_NgaySinh.Size = new System.Drawing.Size(467, 39);
            this.DTP_NgaySinh.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 747);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 32);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 507);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Giới Tính";
            // 
            // tb_mA
            // 
            this.tb_mA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_mA.Location = new System.Drawing.Point(421, 147);
            this.tb_mA.Margin = new System.Windows.Forms.Padding(5);
            this.tb_mA.Name = "tb_mA";
            this.tb_mA.Size = new System.Drawing.Size(467, 39);
            this.tb_mA.TabIndex = 18;
            this.tb_mA.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 474);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 614);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Họ và Tên";
            // 
            // BTN_Them
            // 
            this.BTN_Them.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Them.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.BTN_Them.IconColor = System.Drawing.Color.Black;
            this.BTN_Them.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BTN_Them.IconSize = 70;
            this.BTN_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Them.Location = new System.Drawing.Point(1853, 938);
            this.BTN_Them.Name = "BTN_Them";
            this.BTN_Them.Size = new System.Drawing.Size(256, 96);
            this.BTN_Them.TabIndex = 20;
            this.BTN_Them.Text = "THÊM";
            this.BTN_Them.UseVisualStyleBackColor = true;
            this.BTN_Them.Click += new System.EventHandler(this.BTN_Them_Click);
            // 
            // BTN_Sua
            // 
            this.BTN_Sua.Font = new System.Drawing.Font("Showcard Gothic", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Sua.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.BTN_Sua.IconColor = System.Drawing.Color.Black;
            this.BTN_Sua.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BTN_Sua.IconSize = 70;
            this.BTN_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Sua.Location = new System.Drawing.Point(2187, 938);
            this.BTN_Sua.Name = "BTN_Sua";
            this.BTN_Sua.Size = new System.Drawing.Size(256, 96);
            this.BTN_Sua.TabIndex = 21;
            this.BTN_Sua.Text = "Sửa";
            this.BTN_Sua.UseVisualStyleBackColor = true;
            // 
            // BTN_Xoa
            // 
            this.BTN_Xoa.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Xoa.IconChar = FontAwesome.Sharp.IconChar.PersonCircleXmark;
            this.BTN_Xoa.IconColor = System.Drawing.Color.Black;
            this.BTN_Xoa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BTN_Xoa.IconSize = 70;
            this.BTN_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Xoa.Location = new System.Drawing.Point(2517, 938);
            this.BTN_Xoa.Name = "BTN_Xoa";
            this.BTN_Xoa.Size = new System.Drawing.Size(256, 96);
            this.BTN_Xoa.TabIndex = 22;
            this.BTN_Xoa.Text = "Xóa";
            this.BTN_Xoa.UseVisualStyleBackColor = true;
            this.BTN_Xoa.Click += new System.EventHandler(this.BTN_Xoa_Click);
            // 
            // QL_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2814, 1398);
            this.Controls.Add(this.BTN_Xoa);
            this.Controls.Add(this.BTN_Sua);
            this.Controls.Add(this.BTN_Them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "QL_NhanVien";
            this.Text = "QL_NhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_shownhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTB_Anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_shownhanvien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rd_1;
        private System.Windows.Forms.RadioButton rd_0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.TextBox tb_mA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CB_TT0;
        private System.Windows.Forms.CheckBox CB_TT1;
        private System.Windows.Forms.CheckBox CB_GT0;
        private System.Windows.Forms.CheckBox CB_GT1;
        private System.Windows.Forms.TextBox Tb_DiaChi;
        private System.Windows.Forms.TextBox Tb_sdt;
        private System.Windows.Forms.TextBox TB_MatKhau;
        private System.Windows.Forms.TextBox tb_HovaTen;
        private System.Windows.Forms.DateTimePicker DTP_NgaySinh;
        private System.Windows.Forms.PictureBox PTB_Anh;
        private FontAwesome.Sharp.IconButton BTN_Them;
        private FontAwesome.Sharp.IconButton BTN_Sua;
        private FontAwesome.Sharp.IconButton BTN_Xoa;
        private System.Windows.Forms.ComboBox CBB_ANh;
    }
}