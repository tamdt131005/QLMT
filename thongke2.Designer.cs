namespace ThongKeMuonTra
{
    partial class thongke2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioMat = new System.Windows.Forms.RadioButton();
            this.radioHuHong = new System.Windows.Forms.RadioButton();
            this.radioTot = new System.Windows.Forms.RadioButton();
            this.btnTinhTrang = new System.Windows.Forms.Button();
            this.dgvtinhtrang = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtinhtrang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ TÌNH TRẠNG SÁCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMat);
            this.groupBox1.Controls.Add(this.radioHuHong);
            this.groupBox1.Controls.Add(this.radioTot);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(131, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn:";
            // 
            // radioMat
            // 
            this.radioMat.AutoSize = true;
            this.radioMat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioMat.ForeColor = System.Drawing.Color.Firebrick;
            this.radioMat.Location = new System.Drawing.Point(388, 25);
            this.radioMat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioMat.Name = "radioMat";
            this.radioMat.Size = new System.Drawing.Size(58, 23);
            this.radioMat.TabIndex = 5;
            this.radioMat.TabStop = true;
            this.radioMat.Text = "Mất";
            this.radioMat.UseVisualStyleBackColor = true;
            // 
            // radioHuHong
            // 
            this.radioHuHong.AutoSize = true;
            this.radioHuHong.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioHuHong.ForeColor = System.Drawing.Color.Firebrick;
            this.radioHuHong.Location = new System.Drawing.Point(197, 25);
            this.radioHuHong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioHuHong.Name = "radioHuHong";
            this.radioHuHong.Size = new System.Drawing.Size(99, 23);
            this.radioHuHong.TabIndex = 4;
            this.radioHuHong.TabStop = true;
            this.radioHuHong.Text = "Hư hỏng";
            this.radioHuHong.UseVisualStyleBackColor = true;
            // 
            // radioTot
            // 
            this.radioTot.AutoSize = true;
            this.radioTot.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioTot.ForeColor = System.Drawing.Color.Firebrick;
            this.radioTot.Location = new System.Drawing.Point(22, 25);
            this.radioTot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioTot.Name = "radioTot";
            this.radioTot.Size = new System.Drawing.Size(56, 23);
            this.radioTot.TabIndex = 3;
            this.radioTot.TabStop = true;
            this.radioTot.Text = "Tốt";
            // 
            // btnTinhTrang
            // 
            this.btnTinhTrang.AutoSize = true;
            this.btnTinhTrang.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTinhTrang.Location = new System.Drawing.Point(632, 108);
            this.btnTinhTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTinhTrang.Name = "btnTinhTrang";
            this.btnTinhTrang.Size = new System.Drawing.Size(95, 31);
            this.btnTinhTrang.TabIndex = 4;
            this.btnTinhTrang.Text = "Thống Kê";
            this.btnTinhTrang.UseVisualStyleBackColor = true;
            this.btnTinhTrang.Click += new System.EventHandler(this.btnTinhTrang_Click_1);
            // 
            // dgvtinhtrang
            // 
            this.dgvtinhtrang.AllowUserToAddRows = false;
            this.dgvtinhtrang.AllowUserToDeleteRows = false;
            this.dgvtinhtrang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtinhtrang.Location = new System.Drawing.Point(13, 173);
            this.dgvtinhtrang.Name = "dgvtinhtrang";
            this.dgvtinhtrang.ReadOnly = true;
            this.dgvtinhtrang.RowHeadersWidth = 51;
            this.dgvtinhtrang.RowTemplate.Height = 24;
            this.dgvtinhtrang.Size = new System.Drawing.Size(775, 265);
            this.dgvtinhtrang.TabIndex = 5;
            // 
            // thongke2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvtinhtrang);
            this.Controls.Add(this.btnTinhTrang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "thongke2";
            this.Text = "thongke2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtinhtrang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioMat;
        private System.Windows.Forms.RadioButton radioHuHong;
        private System.Windows.Forms.RadioButton radioTot;
        private System.Windows.Forms.Button btnTinhTrang;
        private System.Windows.Forms.DataGridView dgvtinhtrang;
    }
}