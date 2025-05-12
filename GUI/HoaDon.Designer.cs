namespace GUI
{
    partial class HoaDon
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
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.btnLuu2 = new System.Windows.Forms.Button();
            this.btnLuu1 = new System.Windows.Forms.Button();
            this.lblMaQH = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSach = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.npdSoLuong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(649, 277);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 83;
            this.label2.Text = "Tổng Tiền:";
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhachHang.Enabled = false;
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(174, 226);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(243, 24);
            this.cmbKhachHang.TabIndex = 82;
            // 
            // btnLuu2
            // 
            this.btnLuu2.AutoSize = true;
            this.btnLuu2.Location = new System.Drawing.Point(695, 383);
            this.btnLuu2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu2.Name = "btnLuu2";
            this.btnLuu2.Size = new System.Drawing.Size(119, 34);
            this.btnLuu2.TabIndex = 81;
            this.btnLuu2.Text = "Lưu";
            this.btnLuu2.UseVisualStyleBackColor = true;
            this.btnLuu2.Visible = false;
            this.btnLuu2.Click += new System.EventHandler(this.btnLuu2_Click);
            // 
            // btnLuu1
            // 
            this.btnLuu1.AutoSize = true;
            this.btnLuu1.Location = new System.Drawing.Point(526, 383);
            this.btnLuu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu1.Name = "btnLuu1";
            this.btnLuu1.Size = new System.Drawing.Size(119, 34);
            this.btnLuu1.TabIndex = 80;
            this.btnLuu1.Text = "Lưu";
            this.btnLuu1.UseVisualStyleBackColor = true;
            this.btnLuu1.Visible = false;
            this.btnLuu1.Click += new System.EventHandler(this.btnLuu1_Click);
            // 
            // lblMaQH
            // 
            this.lblMaQH.AutoSize = true;
            this.lblMaQH.Location = new System.Drawing.Point(553, 277);
            this.lblMaQH.Name = "lblMaQH";
            this.lblMaQH.Size = new System.Drawing.Size(65, 16);
            this.lblMaQH.TabIndex = 79;
            this.lblMaQH.Text = "Ngày tạo:";
            // 
            // txtTong
            // 
            this.txtTong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTong.Enabled = false;
            this.txtTong.Location = new System.Drawing.Point(649, 206);
            this.txtTong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(243, 22);
            this.txtTong.TabIndex = 77;
            this.txtTong.TextChanged += new System.EventHandler(this.txtTong_TextChanged);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(695, 383);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 34);
            this.btnSua.TabIndex = 75;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.BackColor = System.Drawing.Color.Blue;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(864, 383);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 34);
            this.btnXoa.TabIndex = 74;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.Blue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(526, 383);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 34);
            this.btnThem.TabIndex = 73;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(856, 455);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(127, 28);
            this.btnHuy.TabIndex = 72;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(51, 322);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(67, 16);
            this.lblSDT.TabIndex = 71;
            this.lblSDT.Text = "Số Lượng:";
            this.lblSDT.Click += new System.EventHandler(this.lblSDT_Click);
            // 
            // txtMa
            // 
            this.txtMa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(174, 183);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(243, 22);
            this.txtMa.TabIndex = 68;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.BackColor = System.Drawing.Color.Blue;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(470, 121);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(119, 34);
            this.btnTimKiem.TabIndex = 66;
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
            this.label3.Size = new System.Drawing.Size(1029, 87);
            this.label3.TabIndex = 65;
            this.label3.Text = "Danh Sách Hóa Đơn";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanVien.Enabled = false;
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(580, 455);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(207, 24);
            this.cmbNhanVien.TabIndex = 98;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 507);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersWidth = 62;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(1029, 232);
            this.dgvHoaDon.TabIndex = 99;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(51, 229);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(110, 16);
            this.lblTenNV.TabIndex = 100;
            this.lblTenNV.Text = "Tên Khách Hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 101;
            this.label1.Text = "Mã:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 103;
            this.label4.Text = "Sách:";
            // 
            // cmbSach
            // 
            this.cmbSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSach.Enabled = false;
            this.cmbSach.FormattingEnabled = true;
            this.cmbSach.Location = new System.Drawing.Point(174, 274);
            this.cmbSach.Name = "cmbSach";
            this.cmbSach.Size = new System.Drawing.Size(243, 24);
            this.cmbSach.TabIndex = 102;
            this.cmbSach.SelectedIndexChanged += new System.EventHandler(this.cmbSach_SelectedIndexChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(109, 127);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(123, 22);
            this.dtpStart.TabIndex = 104;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(316, 127);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(123, 22);
            this.dtpEnd.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 106;
            this.label5.Text = "Từ ngày:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 107;
            this.label6.Text = "tới:";
            // 
            // npdSoLuong
            // 
            this.npdSoLuong.Enabled = false;
            this.npdSoLuong.Location = new System.Drawing.Point(174, 320);
            this.npdSoLuong.Name = "npdSoLuong";
            this.npdSoLuong.Size = new System.Drawing.Size(243, 22);
            this.npdSoLuong.TabIndex = 108;
            this.npdSoLuong.ValueChanged += new System.EventHandler(this.npdSoLuong_ValueChanged);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 739);
            this.Controls.Add(this.npdSoLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.cmbNhanVien);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKhachHang);
            this.Controls.Add(this.btnLuu2);
            this.Controls.Add(this.btnLuu1);
            this.Controls.Add(this.lblMaQH);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label3);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.Button btnLuu2;
        private System.Windows.Forms.Button btnLuu1;
        private System.Windows.Forms.Label lblMaQH;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSach;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown npdSoLuong;
    }
}