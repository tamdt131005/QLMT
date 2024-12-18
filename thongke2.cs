using QLMT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThongKeMuonTra
{
    public partial class thongke2 : Form
    {
        public thongke2()
        {
            InitializeComponent();
        }


        private void thongke_Load(object sender, EventArgs e)
        {
           
        }
        private void setupdvSachMuon()
        {

            dgvtinhtrang.Columns.Clear();
            dgvtinhtrang.Columns.Add("SACH.MASACH", "Mã Sách");
            dgvtinhtrang.Columns.Add("SACH.MADAUSACH", "Mã Đầu Sách ");
            dgvtinhtrang.Columns.Add("SACH.TINHTRANG", "Tình Trạng");
            dgvtinhtrang.Columns.Add("SACH.VITRI", "Vị Trí");
            dgvtinhtrang.Columns.Add("DAUSACH.TENSACH", "Tên Sách");
            dgvtinhtrang.Columns.Add("DAUSACH.TENTACGIA", "Tác Giả");
            dgvtinhtrang.Columns.Add("DAUSACH.NAMXB", "Năm xuất bản");

        }

        void thongkedg()
        {
            string sql = string.Empty;

            if (radioTot.Checked == true)
            {
                // Query for "Good" condition books
                sql = @"SELECT SACH.MASACH, SACH.MADAUSACH, SACH.TINHTRANG, SACH.VITRI, 
                                DAUSACH.TENSACH, DAUSACH.TENTACGIA, DAUSACH.NAMXB  
                         FROM SACH 
                         JOIN DAUSACH ON SACH.MADAUSACH = DAUSACH.MADAUSACH 
                         WHERE SACH.TINHTRANG = N'Tot';";
            }
            else if (radioHuHong.Checked == true)
            {
                // Query for damaged books
                sql = @"SELECT SACH.MASACH, SACH.MADAUSACH, SACH.TINHTRANG, SACH.VITRI, 
                                DAUSACH.TENSACH, DAUSACH.TENTACGIA, DAUSACH.NAMXB  
                         FROM SACH 
                         JOIN DAUSACH ON SACH.MADAUSACH = DAUSACH.MADAUSACH 
                         WHERE SACH.TINHTRANG = N'Hu Hong';";
            }
            else if (radioMat.Checked == true)
            {
                // Query for lost books
                sql = @"SELECT SACH.MASACH, SACH.MADAUSACH, SACH.TINHTRANG, SACH.VITRI, 
                                DAUSACH.TENSACH, DAUSACH.TENTACGIA, DAUSACH.NAMXB  
                         FROM SACH 
                         JOIN DAUSACH ON SACH.MADAUSACH = DAUSACH.MADAUSACH 
                         WHERE SACH.TINHTRANG = N'Mat';";
            }
            else
            {
                MessageBox.Show("Không có dữ liệu phù hợp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {

              //  setupdvSachMuon();
                Public.GanNguonDataGridView(dgvtinhtrang, sql); // Giả sử Public.LayDuLieu thực hiện truy vấn SQL
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnTinhTrang_Click_1(object sender, EventArgs e)
        {

         
            thongkedg();

        }
    }
}
