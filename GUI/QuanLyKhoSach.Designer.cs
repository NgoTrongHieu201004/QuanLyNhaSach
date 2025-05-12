namespace GUI
{
    partial class QuanLyKhoSach
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
            this.txtSoLuongTrongKho = new System.Windows.Forms.TextBox();
            this.txtMaKhoSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvkhoSach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhoSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(597, 196);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 27);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(597, 153);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(76, 27);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(597, 113);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 27);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(597, 74);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 27);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLuongTrongKho
            // 
            this.txtSoLuongTrongKho.Location = new System.Drawing.Point(249, 132);
            this.txtSoLuongTrongKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongTrongKho.Name = "txtSoLuongTrongKho";
            this.txtSoLuongTrongKho.Size = new System.Drawing.Size(223, 22);
            this.txtSoLuongTrongKho.TabIndex = 29;
            // 
            // txtMaKhoSach
            // 
            this.txtMaKhoSach.Location = new System.Drawing.Point(249, 82);
            this.txtMaKhoSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhoSach.Name = "txtMaKhoSach";
            this.txtMaKhoSach.Size = new System.Drawing.Size(223, 22);
            this.txtMaKhoSach.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên Kho:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã Kho Sách:";
            // 
            // dgvkhoSach
            // 
            this.dgvkhoSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvkhoSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhoSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvkhoSach.Location = new System.Drawing.Point(0, 373);
            this.dgvkhoSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvkhoSach.Name = "dgvkhoSach";
            this.dgvkhoSach.RowHeadersWidth = 62;
            this.dgvkhoSach.RowTemplate.Height = 28;
            this.dgvkhoSach.Size = new System.Drawing.Size(832, 164);
            this.dgvkhoSach.TabIndex = 24;
            this.dgvkhoSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhoSach_CellClick);
            // 
            // QuanLyKhoSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 537);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoLuongTrongKho);
            this.Controls.Add(this.txtMaKhoSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvkhoSach);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyKhoSach";
            this.Text = "QuanLyKhoSach";
            this.Load += new System.EventHandler(this.QuanLyKhoSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhoSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoLuongTrongKho;
        private System.Windows.Forms.TextBox txtMaKhoSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvkhoSach;
    }
}