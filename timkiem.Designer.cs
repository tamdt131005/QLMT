namespace ThongKeMuonTra
{
    partial class timkiem
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewUsers;

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
            this.TimKiemThongTin = new System.Windows.Forms.Label();
            this.listViewTK = new System.Windows.Forms.ListView();
            this.radioSach = new System.Windows.Forms.RadioButton();
            this.radioDG = new System.Windows.Forms.RadioButton();
            this.groupLuaChon = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnThoatTK = new System.Windows.Forms.Button();
            this.groupLuaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimKiemThongTin
            // 
            this.TimKiemThongTin.AutoSize = true;
            this.TimKiemThongTin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TimKiemThongTin.Location = new System.Drawing.Point(315, 9);
            this.TimKiemThongTin.Name = "TimKiemThongTin";
            this.TimKiemThongTin.Size = new System.Drawing.Size(321, 35);
            this.TimKiemThongTin.TabIndex = 0;
            this.TimKiemThongTin.Text = "TÌM KIẾM THÔNG TIN";
            this.TimKiemThongTin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listViewTK
            // 
            this.listViewTK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTK.HideSelection = false;
            this.listViewTK.Location = new System.Drawing.Point(15, 191);
            this.listViewTK.Name = "listViewTK";
            this.listViewTK.Size = new System.Drawing.Size(925, 301);
            this.listViewTK.TabIndex = 4;
            this.listViewTK.UseCompatibleStateImageBehavior = false;
            this.listViewTK.View = System.Windows.Forms.View.Details;
            this.listViewTK.SelectedIndexChanged += new System.EventHandler(this.listViewTK_SelectedIndexChanged);
            // 
            // radioSach
            // 
            this.radioSach.AutoSize = true;
            this.radioSach.Location = new System.Drawing.Point(41, 26);
            this.radioSach.Name = "radioSach";
            this.radioSach.Size = new System.Drawing.Size(69, 23);
            this.radioSach.TabIndex = 9;
            this.radioSach.TabStop = true;
            this.radioSach.Text = "Sách";
            this.radioSach.UseVisualStyleBackColor = true;
            this.radioSach.CheckedChanged += new System.EventHandler(this.radioSach_CheckedChanged);
            // 
            // radioDG
            // 
            this.radioDG.AutoSize = true;
            this.radioDG.Location = new System.Drawing.Point(259, 26);
            this.radioDG.Name = "radioDG";
            this.radioDG.Size = new System.Drawing.Size(92, 23);
            this.radioDG.TabIndex = 10;
            this.radioDG.TabStop = true;
            this.radioDG.Text = "Độc Giả";
            this.radioDG.UseVisualStyleBackColor = true;
            this.radioDG.CheckedChanged += new System.EventHandler(this.radioDG_CheckedChanged);
            // 
            // groupLuaChon
            // 
            this.groupLuaChon.Controls.Add(this.radioDG);
            this.groupLuaChon.Controls.Add(this.radioSach);
            this.groupLuaChon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupLuaChon.Location = new System.Drawing.Point(271, 68);
            this.groupLuaChon.Name = "groupLuaChon";
            this.groupLuaChon.Size = new System.Drawing.Size(389, 60);
            this.groupLuaChon.TabIndex = 11;
            this.groupLuaChon.TabStop = false;
            this.groupLuaChon.Text = "Lựa chọn tìm kiếm:";
            this.groupLuaChon.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(666, 147);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(79, 34);
            this.btnTim.TabIndex = 12;
            this.btnTim.Text = "&Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(205, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "&Tìm kiếm:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSearch.Location = new System.Drawing.Point(312, 150);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(341, 25);
            this.tbSearch.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 0);
            this.panel1.TabIndex = 15;
            // 
            // btnXuat
            // 
            this.btnXuat.AutoSize = true;
            this.btnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuat.Location = new System.Drawing.Point(761, 146);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(95, 34);
            this.btnXuat.TabIndex = 16;
            this.btnXuat.Text = "Xuất Excel";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnThoatTK
            // 
            this.btnThoatTK.Location = new System.Drawing.Point(865, 155);
            this.btnThoatTK.Name = "btnThoatTK";
            this.btnThoatTK.Size = new System.Drawing.Size(75, 23);
            this.btnThoatTK.TabIndex = 17;
            this.btnThoatTK.Text = "Thoát";
            this.btnThoatTK.UseVisualStyleBackColor = true;
            this.btnThoatTK.Click += new System.EventHandler(this.button1_Click);
            // 
            // timkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 504);
            this.Controls.Add(this.btnThoatTK);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.TimKiemThongTin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupLuaChon);
            this.Controls.Add(this.listViewTK);
            this.Name = "timkiem";
            this.Text = "Form1";
            this.groupLuaChon.ResumeLayout(false);
            this.groupLuaChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimKiemThongTin;
        private System.Windows.Forms.ListView listViewTK;
        private System.Windows.Forms.RadioButton radioSach;
        private System.Windows.Forms.RadioButton radioDG;
        private System.Windows.Forms.GroupBox groupLuaChon;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnThoatTK;
    }
}

