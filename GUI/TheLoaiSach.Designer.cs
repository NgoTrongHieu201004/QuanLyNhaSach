namespace GUI
{
    partial class TheLoaiSach
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
            this.txtMaTheLoai = new System.Windows.Forms.TextBox();
            this.lblMaTL = new System.Windows.Forms.Label();
            this.btnSuaTheLoai = new System.Windows.Forms.Button();
            this.btnXoaTheLoai = new System.Windows.Forms.Button();
            this.btnThemTheLoai = new System.Windows.Forms.Button();
            this.txtTenTheLoai = new System.Windows.Forms.TextBox();
            this.lblTenTL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(75, 226);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 37);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtMaTheLoai
            // 
            this.txtMaTheLoai.Location = new System.Drawing.Point(204, 126);
            this.txtMaTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaTheLoai.Name = "txtMaTheLoai";
            this.txtMaTheLoai.Size = new System.Drawing.Size(183, 22);
            this.txtMaTheLoai.TabIndex = 27;
            // 
            // lblMaTL
            // 
            this.lblMaTL.AutoSize = true;
            this.lblMaTL.Location = new System.Drawing.Point(97, 126);
            this.lblMaTL.Name = "lblMaTL";
            this.lblMaTL.Size = new System.Drawing.Size(85, 16);
            this.lblMaTL.TabIndex = 26;
            this.lblMaTL.Text = "Mã Thể Loại:";
            // 
            // btnSuaTheLoai
            // 
            this.btnSuaTheLoai.Location = new System.Drawing.Point(465, 214);
            this.btnSuaTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaTheLoai.Name = "btnSuaTheLoai";
            this.btnSuaTheLoai.Size = new System.Drawing.Size(161, 31);
            this.btnSuaTheLoai.TabIndex = 25;
            this.btnSuaTheLoai.Text = "Sửa Thể Loại";
            this.btnSuaTheLoai.UseVisualStyleBackColor = true;
            this.btnSuaTheLoai.Click += new System.EventHandler(this.btnSuaTheLoai_Click);
            // 
            // btnXoaTheLoai
            // 
            this.btnXoaTheLoai.Location = new System.Drawing.Point(465, 166);
            this.btnXoaTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaTheLoai.Name = "btnXoaTheLoai";
            this.btnXoaTheLoai.Size = new System.Drawing.Size(161, 33);
            this.btnXoaTheLoai.TabIndex = 24;
            this.btnXoaTheLoai.Text = "Xóa Thể Loại";
            this.btnXoaTheLoai.UseVisualStyleBackColor = true;
            this.btnXoaTheLoai.Click += new System.EventHandler(this.btnXoaTheLoai_Click);
            // 
            // btnThemTheLoai
            // 
            this.btnThemTheLoai.Location = new System.Drawing.Point(465, 114);
            this.btnThemTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemTheLoai.Name = "btnThemTheLoai";
            this.btnThemTheLoai.Size = new System.Drawing.Size(161, 37);
            this.btnThemTheLoai.TabIndex = 23;
            this.btnThemTheLoai.Text = "Thêm Loại Sách";
            this.btnThemTheLoai.UseVisualStyleBackColor = true;
            this.btnThemTheLoai.Click += new System.EventHandler(this.btnThemTheLoai_Click);
            // 
            // txtTenTheLoai
            // 
            this.txtTenTheLoai.Location = new System.Drawing.Point(204, 180);
            this.txtTenTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.Size = new System.Drawing.Size(183, 22);
            this.txtTenTheLoai.TabIndex = 22;
            // 
            // lblTenTL
            // 
            this.lblTenTL.AutoSize = true;
            this.lblTenTL.Location = new System.Drawing.Point(97, 185);
            this.lblTenTL.Name = "lblTenTL";
            this.lblTenTL.Size = new System.Drawing.Size(90, 16);
            this.lblTenTL.TabIndex = 21;
            this.lblTenTL.Text = "Tên Thể Loại:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(753, 75);
            this.label3.TabIndex = 29;
            this.label3.Text = "Danh Sách Thể Loại Sách";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheLoai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTheLoai.Location = new System.Drawing.Point(0, 384);
            this.dgvTheLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTheLoai.MultiSelect = false;
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.ReadOnly = true;
            this.dgvTheLoai.RowHeadersWidth = 51;
            this.dgvTheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheLoai.Size = new System.Drawing.Size(753, 137);
            this.dgvTheLoai.TabIndex = 30;
            this.dgvTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheLoai_CellClick);
            // 
            // TheLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 521);
            this.Controls.Add(this.dgvTheLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtMaTheLoai);
            this.Controls.Add(this.lblMaTL);
            this.Controls.Add(this.btnSuaTheLoai);
            this.Controls.Add(this.btnXoaTheLoai);
            this.Controls.Add(this.btnThemTheLoai);
            this.Controls.Add(this.txtTenTheLoai);
            this.Controls.Add(this.lblTenTL);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TheLoaiSach";
            this.Text = "TheLoaiSach";
            this.Load += new System.EventHandler(this.TheLoaiSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtMaTheLoai;
        private System.Windows.Forms.Label lblMaTL;
        private System.Windows.Forms.Button btnSuaTheLoai;
        private System.Windows.Forms.Button btnXoaTheLoai;
        private System.Windows.Forms.Button btnThemTheLoai;
        private System.Windows.Forms.TextBox txtTenTheLoai;
        private System.Windows.Forms.Label lblTenTL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTheLoai;
    }
}