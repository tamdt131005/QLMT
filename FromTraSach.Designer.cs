namespace QLMT
{
    partial class FrmTraSach
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvDanhSachSach;
        private System.Windows.Forms.TextBox txtMaPhieuMuon;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Button btnTraSach;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvDanhSachSach = new System.Windows.Forms.DataGridView();
            this.txtMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.btnTraSach = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachSach
            // 
            this.dgvDanhSachSach.AllowUserToAddRows = false;
            this.dgvDanhSachSach.AllowUserToDeleteRows = false;
            this.dgvDanhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSach.Location = new System.Drawing.Point(14, 13);
            this.dgvDanhSachSach.Name = "dgvDanhSachSach";
            this.dgvDanhSachSach.ReadOnly = true;
            this.dgvDanhSachSach.RowHeadersWidth = 51;
            this.dgvDanhSachSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachSach.Size = new System.Drawing.Size(869, 267);
            this.dgvDanhSachSach.TabIndex = 0;
            this.dgvDanhSachSach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhSachSach_CellMouseClick);
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.ForeColor = System.Drawing.Color.Gray;
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(14, 299);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(228, 22);
            this.txtMaPhieuMuon.TabIndex = 1;
            this.txtMaPhieuMuon.Text = "Nhập mã phiếu mượn";
            this.txtMaPhieuMuon.Enter += new System.EventHandler(this.txt_Enter);
            this.txtMaPhieuMuon.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtMaSach
            // 
            this.txtMaSach.ForeColor = System.Drawing.Color.Gray;
            this.txtMaSach.Location = new System.Drawing.Point(263, 299);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(228, 22);
            this.txtMaSach.TabIndex = 2;
            this.txtMaSach.Text = "Nhập mã sách";
            this.txtMaSach.Enter += new System.EventHandler(this.txt_Enter);
            this.txtMaSach.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(526, 299);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(114, 25);
            this.btnTraSach.TabIndex = 3;
            this.btnTraSach.Text = "Trả sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // FrmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 373);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.txtMaPhieuMuon);
            this.Controls.Add(this.dgvDanhSachSach);
            this.Name = "FrmTraSach";
            this.Text = "Trả sách";
            this.Load += new System.EventHandler(this.FrmTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
