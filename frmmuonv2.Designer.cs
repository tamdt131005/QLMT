namespace QLMT
{
    partial class frmmuonv2
    {
        private System.ComponentModel.IContainer components = null;

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
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.dgvSachMuon = new System.Windows.Forms.DataGridView();
            this.txtMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnHuyChonSach = new System.Windows.Forms.Button();
            this.btnLuuPhieuMuon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblMaPhieuMuon = new System.Windows.Forms.Label();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btchitiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(26, 293);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(534, 246);
            this.dgvSach.TabIndex = 0;
            // 
            // dgvSachMuon
            // 
            this.dgvSachMuon.AllowUserToAddRows = false;
            this.dgvSachMuon.AllowUserToDeleteRows = false;
            this.dgvSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachMuon.Location = new System.Drawing.Point(629, 293);
            this.dgvSachMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSachMuon.Name = "dgvSachMuon";
            this.dgvSachMuon.ReadOnly = true;
            this.dgvSachMuon.RowHeadersWidth = 51;
            this.dgvSachMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachMuon.Size = new System.Drawing.Size(515, 246);
            this.dgvSachMuon.TabIndex = 1;
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(665, 59);
            this.txtMaPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(166, 22);
            this.txtMaPhieuMuon.TabIndex = 2;
            this.txtMaPhieuMuon.TextChanged += new System.EventHandler(this.txtMaPhieuMuon_TextChanged);
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Location = new System.Drawing.Point(665, 109);
            this.dtpNgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(265, 22);
            this.dtpNgayMuon.TabIndex = 3;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Location = new System.Drawing.Point(665, 175);
            this.dtpNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(265, 22);
            this.dtpNgayTra.TabIndex = 4;
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Location = new System.Drawing.Point(120, 46);
            this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(128, 22);
            this.txtMaDocGia.TabIndex = 5;
            this.txtMaDocGia.TextChanged += new System.EventHandler(this.txtMaDocGia_TextChanged);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(435, 225);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(125, 37);
            this.btnThemSach.TabIndex = 6;
            this.btnThemSach.Text = "Thêm Sách";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnHuyChonSach
            // 
            this.btnHuyChonSach.Location = new System.Drawing.Point(586, 225);
            this.btnHuyChonSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyChonSach.Name = "btnHuyChonSach";
            this.btnHuyChonSach.Size = new System.Drawing.Size(124, 37);
            this.btnHuyChonSach.TabIndex = 7;
            this.btnHuyChonSach.Text = "Hủy Chọn Sách";
            this.btnHuyChonSach.UseVisualStyleBackColor = true;
            this.btnHuyChonSach.Click += new System.EventHandler(this.btnHuyChonSach_Click);
            // 
            // btnLuuPhieuMuon
            // 
            this.btnLuuPhieuMuon.Location = new System.Drawing.Point(745, 225);
            this.btnLuuPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuPhieuMuon.Name = "btnLuuPhieuMuon";
            this.btnLuuPhieuMuon.Size = new System.Drawing.Size(123, 37);
            this.btnLuuPhieuMuon.TabIndex = 8;
            this.btnLuuPhieuMuon.Text = "Lưu Phiếu Mượn";
            this.btnLuuPhieuMuon.UseVisualStyleBackColor = true;
            this.btnLuuPhieuMuon.Click += new System.EventHandler(this.btnLuuPhieuMuon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1038, 225);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 37);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblMaPhieuMuon
            // 
            this.lblMaPhieuMuon.AutoSize = true;
            this.lblMaPhieuMuon.Location = new System.Drawing.Point(662, 29);
            this.lblMaPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPhieuMuon.Name = "lblMaPhieuMuon";
            this.lblMaPhieuMuon.Size = new System.Drawing.Size(99, 16);
            this.lblMaPhieuMuon.TabIndex = 10;
            this.lblMaPhieuMuon.Text = "Mã Phiếu Mượn";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Location = new System.Drawing.Point(662, 89);
            this.lblNgayMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(76, 16);
            this.lblNgayMuon.TabIndex = 11;
            this.lblNgayMuon.Text = "Ngày Mượn";
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(662, 155);
            this.lblNgayTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(64, 16);
            this.lblNgayTra.TabIndex = 12;
            this.lblNgayTra.Text = "Ngày Trả";
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.AutoSize = true;
            this.lblMaDocGia.Location = new System.Drawing.Point(35, 49);
            this.lblMaDocGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(77, 16);
            this.lblMaDocGia.TabIndex = 13;
            this.lblMaDocGia.Text = "Mã Độc Giả";
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Location = new System.Drawing.Point(38, 89);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.RowHeadersWidth = 51;
            this.dgvDocGia.RowTemplate.Height = 24;
            this.dgvDocGia.Size = new System.Drawing.Size(366, 150);
            this.dgvDocGia.TabIndex = 15;
            this.dgvDocGia.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDocGia_CellMouseClick);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(270, 46);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(91, 23);
            this.btTimKiem.TabIndex = 16;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btchitiet
            // 
            this.btchitiet.Location = new System.Drawing.Point(887, 225);
            this.btchitiet.Name = "btchitiet";
            this.btchitiet.Size = new System.Drawing.Size(144, 37);
            this.btchitiet.TabIndex = 17;
            this.btchitiet.Text = "Chi Tiết Phiếu Mượn";
            this.btchitiet.UseVisualStyleBackColor = true;
            this.btchitiet.Click += new System.EventHandler(this.btchitiet_Click);
            // 
            // frmmuonv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 586);
            this.Controls.Add(this.btchitiet);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.lblMaDocGia);
            this.Controls.Add(this.lblNgayTra);
            this.Controls.Add(this.lblNgayMuon);
            this.Controls.Add(this.lblMaPhieuMuon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuuPhieuMuon);
            this.Controls.Add(this.btnHuyChonSach);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.txtMaDocGia);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.dtpNgayMuon);
            this.Controls.Add(this.txtMaPhieuMuon);
            this.Controls.Add(this.dgvSachMuon);
            this.Controls.Add(this.dgvSach);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmmuonv2";
            this.Text = "Quản Lý Mượn Sách";
            this.Load += new System.EventHandler(this.frmmuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridView dgvSachMuon;
        private System.Windows.Forms.TextBox txtMaPhieuMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnHuyChonSach;
        private System.Windows.Forms.Button btnLuuPhieuMuon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblMaPhieuMuon;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btchitiet;
    }
}
