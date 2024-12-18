namespace QLMT
{
    partial class frmchitietphieumuon
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxmadocgia = new System.Windows.Forms.TextBox();
            this.tbxtendocgia = new System.Windows.Forms.TextBox();
            this.tbxmaphieu = new System.Windows.Forms.TextBox();
            this.tbxngaymuon = new System.Windows.Forms.TextBox();
            this.tbxngaytra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lvtchitiet = new System.Windows.Forms.ListView();
            this.ltvmasach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ltvtensach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ltvtentacgia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvttheloai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ltvnamxb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ltvnxb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Độc Giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Độc Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Phiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Trả";
            // 
            // tbxmadocgia
            // 
            this.tbxmadocgia.Location = new System.Drawing.Point(134, 97);
            this.tbxmadocgia.Name = "tbxmadocgia";
            this.tbxmadocgia.ReadOnly = true;
            this.tbxmadocgia.Size = new System.Drawing.Size(130, 22);
            this.tbxmadocgia.TabIndex = 5;
            // 
            // tbxtendocgia
            // 
            this.tbxtendocgia.Location = new System.Drawing.Point(139, 157);
            this.tbxtendocgia.Name = "tbxtendocgia";
            this.tbxtendocgia.ReadOnly = true;
            this.tbxtendocgia.Size = new System.Drawing.Size(130, 22);
            this.tbxtendocgia.TabIndex = 6;
            // 
            // tbxmaphieu
            // 
            this.tbxmaphieu.Location = new System.Drawing.Point(459, 79);
            this.tbxmaphieu.Name = "tbxmaphieu";
            this.tbxmaphieu.ReadOnly = true;
            this.tbxmaphieu.Size = new System.Drawing.Size(142, 22);
            this.tbxmaphieu.TabIndex = 7;
            // 
            // tbxngaymuon
            // 
            this.tbxngaymuon.Location = new System.Drawing.Point(459, 132);
            this.tbxngaymuon.Name = "tbxngaymuon";
            this.tbxngaymuon.ReadOnly = true;
            this.tbxngaymuon.Size = new System.Drawing.Size(142, 22);
            this.tbxngaymuon.TabIndex = 8;
            // 
            // tbxngaytra
            // 
            this.tbxngaytra.Location = new System.Drawing.Point(459, 193);
            this.tbxngaytra.Name = "tbxngaytra";
            this.tbxngaytra.ReadOnly = true;
            this.tbxngaytra.Size = new System.Drawing.Size(142, 22);
            this.tbxngaytra.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(178, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(343, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chi Tiết Phiếu Mượn Trả";
            // 
            // lvtchitiet
            // 
            this.lvtchitiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ltvmasach,
            this.ltvtensach,
            this.ltvtentacgia,
            this.lvttheloai,
            this.ltvnamxb,
            this.ltvnxb});
            this.lvtchitiet.HideSelection = false;
            this.lvtchitiet.Location = new System.Drawing.Point(37, 253);
            this.lvtchitiet.Name = "lvtchitiet";
            this.lvtchitiet.Size = new System.Drawing.Size(592, 81);
            this.lvtchitiet.TabIndex = 11;
            this.lvtchitiet.UseCompatibleStateImageBehavior = false;
            this.lvtchitiet.View = System.Windows.Forms.View.Details;
            this.lvtchitiet.SelectedIndexChanged += new System.EventHandler(this.lvtchitiet_SelectedIndexChanged);
            // 
            // ltvmasach
            // 
            this.ltvmasach.Text = "Mã Sách";
            // 
            // ltvtensach
            // 
            this.ltvtensach.Text = "Tên Sách";
            // 
            // ltvtentacgia
            // 
            this.ltvtentacgia.Text = "Tên Tác Giả";
            // 
            // lvttheloai
            // 
            this.lvttheloai.Text = "Thể Loại";
            // 
            // ltvnamxb
            // 
            this.ltvnamxb.Text = "Năm Xuất Bản";
            // 
            // ltvnxb
            // 
            this.ltvnxb.Text = "Nhà Xuất Bản";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Xuất word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmchitietphieumuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvtchitiet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxngaytra);
            this.Controls.Add(this.tbxngaymuon);
            this.Controls.Add(this.tbxmaphieu);
            this.Controls.Add(this.tbxtendocgia);
            this.Controls.Add(this.tbxmadocgia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmchitietphieumuon";
            this.Text = "Chi Tiết Phiếu Mượn";
            this.Load += new System.EventHandler(this.frmchitietphieumuon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxmadocgia;
        private System.Windows.Forms.TextBox tbxtendocgia;
        private System.Windows.Forms.TextBox tbxmaphieu;
        private System.Windows.Forms.TextBox tbxngaymuon;
        private System.Windows.Forms.TextBox tbxngaytra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvtchitiet;
        private System.Windows.Forms.ColumnHeader ltvmasach;
        private System.Windows.Forms.ColumnHeader ltvtensach;
        private System.Windows.Forms.ColumnHeader ltvtentacgia;
        private System.Windows.Forms.ColumnHeader lvttheloai;
        private System.Windows.Forms.ColumnHeader ltvnamxb;
        private System.Windows.Forms.ColumnHeader ltvnxb;
        private System.Windows.Forms.Button button1;
    }
}