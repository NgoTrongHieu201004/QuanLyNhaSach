namespace GUI
{
    partial class QuanLyNXB
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
            this.bntReSet = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChiNXB = new System.Windows.Forms.TextBox();
            this.txtTenNhaXuatBan = new System.Windows.Forms.TextBox();
            this.txtMaNhaXuatBan = new System.Windows.Forms.TextBox();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // bntReSet
            // 
            this.bntReSet.Location = new System.Drawing.Point(744, 164);
            this.bntReSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntReSet.Name = "bntReSet";
            this.bntReSet.Size = new System.Drawing.Size(67, 37);
            this.bntReSet.TabIndex = 25;
            this.bntReSet.Text = "Reset";
            this.bntReSet.UseVisualStyleBackColor = true;
            this.bntReSet.Click += new System.EventHandler(this.bntReSet_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(453, 164);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 37);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(307, 164);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(67, 37);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(153, 164);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 37);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(572, 116);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(153, 22);
            this.txtSDT.TabIndex = 21;
            // 
            // txtDiaChiNXB
            // 
            this.txtDiaChiNXB.Location = new System.Drawing.Point(572, 74);
            this.txtDiaChiNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChiNXB.Name = "txtDiaChiNXB";
            this.txtDiaChiNXB.Size = new System.Drawing.Size(153, 22);
            this.txtDiaChiNXB.TabIndex = 20;
            // 
            // txtTenNhaXuatBan
            // 
            this.txtTenNhaXuatBan.Location = new System.Drawing.Point(219, 116);
            this.txtTenNhaXuatBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNhaXuatBan.Name = "txtTenNhaXuatBan";
            this.txtTenNhaXuatBan.Size = new System.Drawing.Size(176, 22);
            this.txtTenNhaXuatBan.TabIndex = 19;
            // 
            // txtMaNhaXuatBan
            // 
            this.txtMaNhaXuatBan.Location = new System.Drawing.Point(219, 73);
            this.txtMaNhaXuatBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhaXuatBan.Name = "txtMaNhaXuatBan";
            this.txtMaNhaXuatBan.Size = new System.Drawing.Size(176, 22);
            this.txtMaNhaXuatBan.TabIndex = 18;
            // 
            // dgvNXB
            // 
            this.dgvNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNXB.Location = new System.Drawing.Point(0, 305);
            this.dgvNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.RowHeadersWidth = 62;
            this.dgvNXB.RowTemplate.Height = 28;
            this.dgvNXB.Size = new System.Drawing.Size(935, 186);
            this.dgvNXB.TabIndex = 17;
            this.dgvNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNXB_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sdt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Địa Chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên NXB:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã NXB:";
            // 
            // QuanLyNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 491);
            this.Controls.Add(this.bntReSet);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChiNXB);
            this.Controls.Add(this.txtTenNhaXuatBan);
            this.Controls.Add(this.txtMaNhaXuatBan);
            this.Controls.Add(this.dgvNXB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuanLyNXB";
            this.Text = "QuanLyNXB";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntReSet;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChiNXB;
        private System.Windows.Forms.TextBox txtTenNhaXuatBan;
        private System.Windows.Forms.TextBox txtMaNhaXuatBan;
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}