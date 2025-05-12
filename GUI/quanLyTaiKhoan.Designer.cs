namespace GUI
{
    partial class quanLyTaiKhoan
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
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbQuyenHan = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuuthem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuuSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTaiKhoan.GridColor = System.Drawing.SystemColors.Control;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(0, 275);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 62;
            this.dgvTaiKhoan.RowTemplate.Height = 28;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(893, 219);
            this.dgvTaiKhoan.TabIndex = 17;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            this.dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quyền hạn:";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(185, 76);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(276, 30);
            this.txtUsername.TabIndex = 22;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(185, 145);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(276, 30);
            this.txtPassword.TabIndex = 23;
            // 
            // cmbQuyenHan
            // 
            this.cmbQuyenHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuyenHan.Enabled = false;
            this.cmbQuyenHan.FormattingEnabled = true;
            this.cmbQuyenHan.Location = new System.Drawing.Point(617, 73);
            this.cmbQuyenHan.Name = "cmbQuyenHan";
            this.cmbQuyenHan.Size = new System.Drawing.Size(227, 33);
            this.cmbQuyenHan.TabIndex = 24;
            this.cmbQuyenHan.SelectedIndexChanged += new System.EventHandler(this.cmbQuyenHan_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(185, 209);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 48);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuuthem
            // 
            this.btnLuuthem.Location = new System.Drawing.Point(185, 209);
            this.btnLuuthem.Name = "btnLuuthem";
            this.btnLuuthem.Size = new System.Drawing.Size(113, 48);
            this.btnLuuthem.TabIndex = 26;
            this.btnLuuthem.Text = "Lưu";
            this.btnLuuthem.UseVisualStyleBackColor = true;
            this.btnLuuthem.Visible = false;
            this.btnLuuthem.Click += new System.EventHandler(this.btnLuuthem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(373, 209);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 48);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuuSua
            // 
            this.btnLuuSua.Location = new System.Drawing.Point(373, 209);
            this.btnLuuSua.Name = "btnLuuSua";
            this.btnLuuSua.Size = new System.Drawing.Size(113, 48);
            this.btnLuuSua.TabIndex = 28;
            this.btnLuuSua.Text = "Lưu";
            this.btnLuuSua.UseVisualStyleBackColor = true;
            this.btnLuuSua.Visible = false;
            this.btnLuuSua.Click += new System.EventHandler(this.btnLuuSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(534, 209);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 48);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserId.Enabled = false;
            this.txtUserId.Location = new System.Drawing.Point(185, 40);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(276, 30);
            this.txtUserId.TabIndex = 30;
            this.txtUserId.Visible = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(704, 209);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 48);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // quanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 494);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuuSua);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuuthem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbQuyenHan);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "quanLyTaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.quanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbQuyenHan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuuthem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuuSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnThoat;
    }
}