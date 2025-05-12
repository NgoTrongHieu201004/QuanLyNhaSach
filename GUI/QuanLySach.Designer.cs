namespace GUI
{
    partial class QuanLySach
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
            this.btnLuu2 = new System.Windows.Forms.Button();
            this.btnLuu1 = new System.Windows.Forms.Button();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grvSach = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTacGia = new System.Windows.Forms.ComboBox();
            this.cmbTheLoai = new System.Windows.Forms.ComboBox();
            this.cmbNXB = new System.Windows.Forms.ComboBox();
            this.cmbKho = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNhanVien = new System.Windows.Forms.Label();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu2
            // 
            this.btnLuu2.AutoSize = true;
            this.btnLuu2.Location = new System.Drawing.Point(737, 372);
            this.btnLuu2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu2.Name = "btnLuu2";
            this.btnLuu2.Size = new System.Drawing.Size(119, 34);
            this.btnLuu2.TabIndex = 86;
            this.btnLuu2.Text = "Lưu";
            this.btnLuu2.UseVisualStyleBackColor = true;
            this.btnLuu2.Visible = false;
            this.btnLuu2.Click += new System.EventHandler(this.btnLuu2_Click);
            // 
            // btnLuu1
            // 
            this.btnLuu1.AutoSize = true;
            this.btnLuu1.Location = new System.Drawing.Point(568, 376);
            this.btnLuu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu1.Name = "btnLuu1";
            this.btnLuu1.Size = new System.Drawing.Size(119, 34);
            this.btnLuu1.TabIndex = 85;
            this.btnLuu1.Text = "Lưu";
            this.btnLuu1.UseVisualStyleBackColor = true;
            this.btnLuu1.Visible = false;
            this.btnLuu1.Click += new System.EventHandler(this.btnLuu1_Click);
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(587, 294);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(31, 16);
            this.lblGia.TabIndex = 84;
            this.lblGia.Text = "Giá:";
            // 
            // txtGia
            // 
            this.txtGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGia.Enabled = false;
            this.txtGia.Location = new System.Drawing.Point(685, 291);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(243, 22);
            this.txtGia.TabIndex = 83;
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(737, 372);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 34);
            this.btnSua.TabIndex = 76;
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
            this.btnXoa.Location = new System.Drawing.Point(907, 374);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 34);
            this.btnXoa.TabIndex = 75;
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
            this.btnThem.Location = new System.Drawing.Point(568, 372);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 34);
            this.btnThem.TabIndex = 74;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(907, 431);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(127, 28);
            this.btnHuy.TabIndex = 73;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(53, 297);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(58, 16);
            this.lblTacGia.TabIndex = 72;
            this.lblTacGia.Text = "Tác Giả:";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(53, 242);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(68, 16);
            this.lblTenSach.TabIndex = 70;
            this.lblTenSach.Text = "Tên Sách:";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(53, 194);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(60, 16);
            this.lblMaSach.TabIndex = 69;
            this.lblMaSach.Text = "Mã Sách";
            // 
            // txtTenSach
            // 
            this.txtTenSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSach.Enabled = false;
            this.txtTenSach.Location = new System.Drawing.Point(159, 239);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(243, 22);
            this.txtTenSach.TabIndex = 67;
            // 
            // txtMaSach
            // 
            this.txtMaSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Location = new System.Drawing.Point(159, 192);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(243, 22);
            this.txtMaSach.TabIndex = 66;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(159, 122);
            this.txtKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(243, 22);
            this.txtKey.TabIndex = 65;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.BackColor = System.Drawing.Color.Blue;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(424, 114);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(119, 34);
            this.btnTimKiem.TabIndex = 64;
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
            this.label3.Size = new System.Drawing.Size(1056, 87);
            this.label3.TabIndex = 63;
            this.label3.Text = "Danh Sách Sách\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, -17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 62;
            // 
            // grvSach
            // 
            this.grvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grvSach.Location = new System.Drawing.Point(0, 467);
            this.grvSach.Margin = new System.Windows.Forms.Padding(4);
            this.grvSach.MultiSelect = false;
            this.grvSach.Name = "grvSach";
            this.grvSach.ReadOnly = true;
            this.grvSach.RowHeadersWidth = 51;
            this.grvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvSach.Size = new System.Drawing.Size(1056, 267);
            this.grvSach.TabIndex = 61;
            this.grvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvSach_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 87;
            this.label2.Text = "Thể Loại:";
            // 
            // cmbTacGia
            // 
            this.cmbTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTacGia.Enabled = false;
            this.cmbTacGia.FormattingEnabled = true;
            this.cmbTacGia.Location = new System.Drawing.Point(159, 291);
            this.cmbTacGia.Name = "cmbTacGia";
            this.cmbTacGia.Size = new System.Drawing.Size(243, 24);
            this.cmbTacGia.TabIndex = 88;
            // 
            // cmbTheLoai
            // 
            this.cmbTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTheLoai.Enabled = false;
            this.cmbTheLoai.FormattingEnabled = true;
            this.cmbTheLoai.Location = new System.Drawing.Point(159, 348);
            this.cmbTheLoai.Name = "cmbTheLoai";
            this.cmbTheLoai.Size = new System.Drawing.Size(243, 24);
            this.cmbTheLoai.TabIndex = 89;
            // 
            // cmbNXB
            // 
            this.cmbNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNXB.Enabled = false;
            this.cmbNXB.FormattingEnabled = true;
            this.cmbNXB.Location = new System.Drawing.Point(685, 192);
            this.cmbNXB.Name = "cmbNXB";
            this.cmbNXB.Size = new System.Drawing.Size(243, 24);
            this.cmbNXB.TabIndex = 90;
            // 
            // cmbKho
            // 
            this.cmbKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKho.Enabled = false;
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.Location = new System.Drawing.Point(685, 239);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(243, 24);
            this.cmbKho.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 93;
            this.label4.Text = "NXB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 94;
            this.label5.Text = "Kho:";
            // 
            // lbNhanVien
            // 
            this.lbNhanVien.AutoSize = true;
            this.lbNhanVien.Location = new System.Drawing.Point(682, 431);
            this.lbNhanVien.Name = "lbNhanVien";
            this.lbNhanVien.Size = new System.Drawing.Size(0, 16);
            this.lbNhanVien.TabIndex = 95;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanVien.Enabled = false;
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(685, 435);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(207, 24);
            this.cmbNhanVien.TabIndex = 96;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_user_50;
            this.pictureBox1.Location = new System.Drawing.Point(57, 103);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 734);
            this.Controls.Add(this.cmbNhanVien);
            this.Controls.Add(this.lbNhanVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbKho);
            this.Controls.Add(this.cmbNXB);
            this.Controls.Add(this.cmbTheLoai);
            this.Controls.Add(this.cmbTacGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLuu2);
            this.Controls.Add(this.btnLuu1);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.lblTenSach);
            this.Controls.Add(this.lblMaSach);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvSach);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLySach";
            this.Text = "QuanLySach";
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu2;
        private System.Windows.Forms.Button btnLuu1;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grvSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTacGia;
        private System.Windows.Forms.ComboBox cmbTheLoai;
        private System.Windows.Forms.ComboBox cmbNXB;
        private System.Windows.Forms.ComboBox cmbKho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNhanVien;
        private System.Windows.Forms.ComboBox cmbNhanVien;
    }
}