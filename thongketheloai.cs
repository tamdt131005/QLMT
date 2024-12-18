using QLMT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThongKeMuonTra
{
    public partial class thongketheloai : Form
    {
        string sql;
       // string macu = "";
        public thongketheloai()
        {
            InitializeComponent();
        }
        //void LayNguonCBO()
        //{
        //    //Public.GanNguonComboBox(cboTheLoai, "MADAUSACH", "TENSACH", "TENTACGIA", "THELOAI", "NAMXB", "NXB", "NGONNGU", "SOLUONG");
        //    Public.GanNguonComboBox(cboTheLoai, "THELOAI", "TENTHELOAI", "MATHELOAI");

        //}
        //void LayNguon(string sql)
        //{
        //    if (InvokeRequired)
        //    {
        //        Invoke(new Action<string>(LayNguon), sql);
        //        return;
        //    }
        //    Public.GanNguonDataGridView(dgTheLoai, sql);
        //    lbTong.Text = $"Danh sách có {dgTheLoai.RowCount} dòng";
        //}
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thongketheloai_Load(object sender, EventArgs e)
        {
            //LayNguonCBO();
            //sql = "Select MADAUSACH TENSACH TENTACGIA THELOAI NAMXB NXB NGONNGU SOLUONG From DAUSACH";
            //LayNguon(sql);
        }

        private void dgTheLoai_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //try
            //{
            //    if (dgTheLoai.RowCount <= 0) return;
            //    if (e == null) return;
            //    if (e.RowIndex >= 0)
            //    {
            //        DataGridViewRow row = dgTheLoai.Rows[e.RowIndex];
            //        cboTheLoai.SelectedValue = row.Cells["THELOAI"].Value.ToString(); // Đảm bảo chọn đúng cột THELOAI
            //    }
            //}
            //catch (Exception ex) {
            //MessageBox.Show("Lỗi phát sinh: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void cboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboTheLoai.SelectedValue == null) return;

            //string selectedValue = cboTheLoai.SelectedValue.ToString();
            //sql = $"Select MADAUSACH, TENSACH, TENTACGIA, THELOAI, NAMXB, NXB, NGONNGU, SOLUONG From DAUSACH WHERE THELOAI = '{selectedValue}'";
            //LayNguon(sql);
        }
    }
}
