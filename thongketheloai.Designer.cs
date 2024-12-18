namespace ThongKeMuonTra
{
    partial class thongketheloai
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
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.laTheloai = new System.Windows.Forms.Label();
            this.dgTheLoai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbTong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(147, 79);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(515, 24);
            this.cboTheLoai.TabIndex = 1;
            this.cboTheLoai.SelectedIndexChanged += new System.EventHandler(this.cboTheLoai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(195, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "THỐNG KÊ THỂ LOẠI SÁCH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // laTheloai
            // 
            this.laTheloai.AutoSize = true;
            this.laTheloai.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.laTheloai.Location = new System.Drawing.Point(65, 84);
            this.laTheloai.Name = "laTheloai";
            this.laTheloai.Size = new System.Drawing.Size(76, 19);
            this.laTheloai.TabIndex = 14;
            this.laTheloai.Text = "&Thể loại:";
            // 
            // dgTheLoai
            // 
            this.dgTheLoai.AllowUserToAddRows = false;
            this.dgTheLoai.AllowUserToDeleteRows = false;
            this.dgTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgTheLoai.Location = new System.Drawing.Point(25, 123);
            this.dgTheLoai.Name = "dgTheLoai";
            this.dgTheLoai.ReadOnly = true;
            this.dgTheLoai.RowHeadersWidth = 51;
            this.dgTheLoai.RowTemplate.Height = 24;
            this.dgTheLoai.Size = new System.Drawing.Size(747, 304);
            this.dgTheLoai.TabIndex = 15;
            this.dgTheLoai.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgTheLoai_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 109.2277F;
            this.Column1.HeaderText = "Mã Đầu Sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 87;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 103.8415F;
            this.Column2.HeaderText = "Tên Sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 87;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 98.7919F;
            this.Column3.HeaderText = "Tác Giả";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 86;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 97.63105F;
            this.Column4.HeaderText = "Thể Loại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 87;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 96.61851F;
            this.Column5.HeaderText = "Năm Xuất Bản";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 87;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 96.79563F;
            this.Column6.HeaderText = "Nhà Xuất Bản";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 87;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 96.80558F;
            this.Column7.HeaderText = "Ngôn Ngữ";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 86;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 100.2882F;
            this.Column8.HeaderText = "Số Lượng";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 87;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(697, 77);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 33);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbTong
            // 
            this.lbTong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbTong.Location = new System.Drawing.Point(0, 434);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(800, 16);
            this.lbTong.TabIndex = 17;
            // 
            // thongketheloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgTheLoai);
            this.Controls.Add(this.laTheloai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTheLoai);
            this.Name = "thongketheloai";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.thongketheloai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laTheloai;
        private System.Windows.Forms.DataGridView dgTheLoai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label lbTong;
    }
}