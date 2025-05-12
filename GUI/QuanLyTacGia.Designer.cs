namespace GUI
{
    partial class QuanLyTacGia
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTieuSu = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.txtMaTacGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.pkTuoi = new System.Windows.Forms.DateTimePicker();
            this.lblTuoi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(817, 224);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 34);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(817, 181);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 34);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(817, 134);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 34);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(817, 94);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 34);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTieuSu
            // 
            this.txtTieuSu.Location = new System.Drawing.Point(607, 169);
            this.txtTieuSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTieuSu.Name = "txtTieuSu";
            this.txtTieuSu.Size = new System.Drawing.Size(145, 22);
            this.txtTieuSu.TabIndex = 25;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(285, 218);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(148, 22);
            this.txtGioiTinh.TabIndex = 24;
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.Location = new System.Drawing.Point(285, 169);
            this.txtTenTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(148, 22);
            this.txtTenTacGia.TabIndex = 23;
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.Location = new System.Drawing.Point(285, 116);
            this.txtMaTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Size = new System.Drawing.Size(148, 22);
            this.txtMaTacGia.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tiểu sử:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Giới Tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên Tác Giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Tác Giả:";
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTacGia.GridColor = System.Drawing.SystemColors.Control;
            this.dgvTacGia.Location = new System.Drawing.Point(0, 335);
            this.dgvTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.RowHeadersWidth = 62;
            this.dgvTacGia.RowTemplate.Height = 28;
            this.dgvTacGia.Size = new System.Drawing.Size(1067, 219);
            this.dgvTacGia.TabIndex = 16;
            this.dgvTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTacGia_CellClick);
            this.dgvTacGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTacGia_CellContentClick);
            // 
            // pkTuoi
            // 
            this.pkTuoi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pkTuoi.Location = new System.Drawing.Point(605, 111);
            this.pkTuoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pkTuoi.Name = "pkTuoi";
            this.pkTuoi.Size = new System.Drawing.Size(147, 22);
            this.pkTuoi.TabIndex = 40;
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuoi.Location = new System.Drawing.Point(513, 111);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(72, 16);
            this.lblTuoi.TabIndex = 39;
            this.lblTuoi.Text = "Ngày Sinh:";
            // 
            // QuanLyTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pkTuoi);
            this.Controls.Add(this.lblTuoi);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTieuSu);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtTenTacGia);
            this.Controls.Add(this.txtMaTacGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTacGia);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyTacGia";
            this.Text = "QuanLyTacGia";
            this.Load += new System.EventHandler(this.QuanLyTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTieuSu;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.TextBox txtMaTacGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTacGia;
        private System.Windows.Forms.DateTimePicker pkTuoi;
        private System.Windows.Forms.Label lblTuoi;
    }
}