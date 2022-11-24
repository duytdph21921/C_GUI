namespace C_GUI.View
{
    partial class QLChuvu
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
            this.BTN_Sua = new FontAwesome.Sharp.IconButton();
            this.BTN_Xoa = new FontAwesome.Sharp.IconButton();
            this.DTG_SHOW = new System.Windows.Forms.DataGridView();
            this.BTN_them = new FontAwesome.Sharp.IconButton();
            this.TTB_Ma = new System.Windows.Forms.TextBox();
            this.TB_Ten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_SHOW)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Sua
            // 
            this.BTN_Sua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BTN_Sua.IconColor = System.Drawing.Color.Black;
            this.BTN_Sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Sua.Location = new System.Drawing.Point(581, 569);
            this.BTN_Sua.Name = "BTN_Sua";
            this.BTN_Sua.Size = new System.Drawing.Size(150, 46);
            this.BTN_Sua.TabIndex = 1;
            this.BTN_Sua.Text = "Sửa";
            this.BTN_Sua.UseVisualStyleBackColor = true;
            this.BTN_Sua.Click += new System.EventHandler(this.BTN_Sua_Click);
            // 
            // BTN_Xoa
            // 
            this.BTN_Xoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BTN_Xoa.IconColor = System.Drawing.Color.Black;
            this.BTN_Xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Xoa.Location = new System.Drawing.Point(581, 651);
            this.BTN_Xoa.Name = "BTN_Xoa";
            this.BTN_Xoa.Size = new System.Drawing.Size(150, 46);
            this.BTN_Xoa.TabIndex = 2;
            this.BTN_Xoa.Text = "Xóa";
            this.BTN_Xoa.UseVisualStyleBackColor = true;
            this.BTN_Xoa.Click += new System.EventHandler(this.BTN_Xoa_Click);
            // 
            // DTG_SHOW
            // 
            this.DTG_SHOW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_SHOW.Location = new System.Drawing.Point(12, 442);
            this.DTG_SHOW.Name = "DTG_SHOW";
            this.DTG_SHOW.RowHeadersWidth = 82;
            this.DTG_SHOW.RowTemplate.Height = 41;
            this.DTG_SHOW.Size = new System.Drawing.Size(482, 300);
            this.DTG_SHOW.TabIndex = 3;
            this.DTG_SHOW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_SHOW_CellClick);
            // 
            // BTN_them
            // 
            this.BTN_them.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BTN_them.IconColor = System.Drawing.Color.Black;
            this.BTN_them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_them.Location = new System.Drawing.Point(581, 482);
            this.BTN_them.Name = "BTN_them";
            this.BTN_them.Size = new System.Drawing.Size(150, 46);
            this.BTN_them.TabIndex = 4;
            this.BTN_them.Text = "Thêm";
            this.BTN_them.UseVisualStyleBackColor = true;
            this.BTN_them.Click += new System.EventHandler(this.BTN_them_Click);
            // 
            // TTB_Ma
            // 
            this.TTB_Ma.Location = new System.Drawing.Point(168, 122);
            this.TTB_Ma.Name = "TTB_Ma";
            this.TTB_Ma.Size = new System.Drawing.Size(326, 39);
            this.TTB_Ma.TabIndex = 5;
            // 
            // TB_Ten
            // 
            this.TB_Ten.Location = new System.Drawing.Point(168, 233);
            this.TB_Ten.Name = "TB_Ten";
            this.TB_Ten.Size = new System.Drawing.Size(326, 39);
            this.TB_Ten.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên";
            // 
            // TB_Search
            // 
            this.TB_Search.Location = new System.Drawing.Point(148, 381);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(346, 39);
            this.TB_Search.TabIndex = 9;
            this.TB_Search.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "search";
            // 
            // QLChuvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 754);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Ten);
            this.Controls.Add(this.TTB_Ma);
            this.Controls.Add(this.BTN_them);
            this.Controls.Add(this.DTG_SHOW);
            this.Controls.Add(this.BTN_Xoa);
            this.Controls.Add(this.BTN_Sua);
            this.Name = "QLChuvu";
            this.Text = "QLChuvu";
            this.Load += new System.EventHandler(this.QLChuvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_SHOW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BTN_Sua;
        private FontAwesome.Sharp.IconButton BTN_Xoa;
        private System.Windows.Forms.DataGridView DTG_SHOW;
        private FontAwesome.Sharp.IconButton BTN_them;
        private System.Windows.Forms.TextBox TTB_Ma;
        private System.Windows.Forms.TextBox TB_Ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.Label label3;
    }
}