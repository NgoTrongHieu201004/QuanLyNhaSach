namespace GUI
{
    partial class QuanLyNhanVien
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
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grv = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblMaQH = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnLuu1 = new System.Windows.Forms.Button();
            this.btnLuu2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(600, 233);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(38, 16);
            this.lblSDT.TabIndex = 37;
            this.lblSDT.Text = "SDT:";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(600, 321);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(47, 16);
            this.lblLuong.TabIndex = 36;
            this.lblLuong.Text = "Lương:";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(68, 246);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(34, 16);
            this.lblTenNV.TabIndex = 34;
            this.lblTenNV.Text = "Tên:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(64, 198);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(0, 16);
            this.lblMaNV.TabIndex = 33;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(696, 231);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(243, 22);
            this.txtSDT.TabIndex = 32;
            // 
            // txtTen
            // 
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(169, 238);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(243, 22);
            this.txtTen.TabIndex = 31;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(169, 126);
            this.txtKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(243, 22);
            this.txtKey.TabIndex = 29;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.BackColor = System.Drawing.Color.Blue;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(435, 118);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(119, 34);
            this.btnTimKiem.TabIndex = 28;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1047, 87);
            this.label3.TabIndex = 27;
            this.label3.Text = "Danh Sách Nhân Viên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, -34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 26;
            // 
            // grv
            // 
            this.grv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grv.Location = new System.Drawing.Point(0, 540);
            this.grv.Margin = new System.Windows.Forms.Padding(4);
            this.grv.MultiSelect = false;
            this.grv.Name = "grv";
            this.grv.ReadOnly = true;
            this.grv.RowHeadersWidth = 51;
            this.grv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv.Size = new System.Drawing.Size(1047, 267);
            this.grv.TabIndex = 25;
            this.grv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_CellClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(896, 494);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(127, 28);
            this.btnHuy.TabIndex = 46;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.Blue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(575, 391);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 34);
            this.btnThem.TabIndex = 47;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.BackColor = System.Drawing.Color.Blue;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(913, 391);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 34);
            this.btnXoa.TabIndex = 48;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(744, 391);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 34);
            this.btnSua.TabIndex = 49;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblMaQH
            // 
            this.lblMaQH.AutoSize = true;
            this.lblMaQH.Location = new System.Drawing.Point(600, 192);
            this.lblMaQH.Name = "lblMaQH";
            this.lblMaQH.Size = new System.Drawing.Size(70, 16);
            this.lblMaQH.TabIndex = 56;
            this.lblMaQH.Text = "Ngày sinh:";
            // 
            // txtLuong
            // 
            this.txtLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLuong.Enabled = false;
            this.txtLuong.Location = new System.Drawing.Point(696, 319);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(243, 22);
            this.txtLuong.TabIndex = 54;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(696, 277);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(243, 22);
            this.txtDiaChi.TabIndex = 53;
            // 
            // btnLuu1
            // 
            this.btnLuu1.AutoSize = true;
            this.btnLuu1.Location = new System.Drawing.Point(575, 393);
            this.btnLuu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu1.Name = "btnLuu1";
            this.btnLuu1.Size = new System.Drawing.Size(119, 34);
            this.btnLuu1.TabIndex = 59;
            this.btnLuu1.Text = "Lưu";
            this.btnLuu1.UseVisualStyleBackColor = true;
            this.btnLuu1.Visible = false;
            this.btnLuu1.Click += new System.EventHandler(this.btnLuu1_Click);
            // 
            // btnLuu2
            // 
            this.btnLuu2.AutoSize = true;
            this.btnLuu2.Location = new System.Drawing.Point(744, 393);
            this.btnLuu2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu2.Name = "btnLuu2";
            this.btnLuu2.Size = new System.Drawing.Size(119, 34);
            this.btnLuu2.TabIndex = 60;
            this.btnLuu2.Text = "Lưu";
            this.btnLuu2.UseVisualStyleBackColor = true;
            this.btnLuu2.Visible = false;
            this.btnLuu2.Click += new System.EventHandler(this.btnLuu2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_user_50;
            this.pictureBox1.Location = new System.Drawing.Point(68, 107);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // cmbUser
            // 
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.Enabled = false;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(169, 198);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(243, 24);
            this.cmbUser.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Địa chỉ:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Location = new System.Drawing.Point(696, 192);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 63;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Location = new System.Drawing.Point(56, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 72);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính:";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Enabled = false;
            this.rdbNu.Location = new System.Drawing.Point(247, 31);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(45, 20);
            this.rdbNu.TabIndex = 1;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Enabled = false;
            this.rdbNam.Location = new System.Drawing.Point(71, 29);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(57, 20);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 807);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.btnLuu2);
            this.Controls.Add(this.btnLuu1);
            this.Controls.Add(this.lblMaQH);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grv;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMaQH;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnLuu1;
        private System.Windows.Forms.Button btnLuu2;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
    }
}