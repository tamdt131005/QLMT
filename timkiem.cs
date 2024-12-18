using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLMT;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace ThongKeMuonTra
{

    public partial class timkiem : Form

    {
        public timkiem()
        {
            InitializeComponent();

        }
        ListViewItem itemLV;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioSach_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioDG_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            string keyword = tbSearch.Text;
            laydatalv(keyword);
        }
        //    if (!string.IsNullOrEmpty(keyword))
        //    {
        //        try
        //        {
        //            DataTable result = Public.timkiemDocGia(keyword);

        //            if (result.Rows.Count > 0)
        //            {
        //                listViewUsers.Items.Clear();

        //                foreach (DataRow row in result.Rows)
        //                {
        //                    ListViewItem item = new ListViewItem(row["MaDG"].ToString());
        //                    item.SubItems.Add(row["TenDG"].ToString());
        //                    listViewUsers.Items.Add(item);
        //                }

        //                MessageBox.Show($"Tìm thấy {result.Rows.Count} kết quả.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Không tìm thấy kết quả nào.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Lỗi: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }


        void laydatalv(string mpm)
        {
            string sql;

            if(radioSach.Checked==true)
            {
                sql = $@"
                SELECT DAUSACH.MADAUSACH,  DAUSACH.TENSACH,  DAUSACH.TENTACGIA,  DAUSACH.THELOAI,DAUSACH.NAMXB,  DAUSACH.NXB,  DAUSACH.SOLUONG, SACH.MASACH,  SACH.TINHTRANG, SACH.VITRI
                FROM 
                    DAUSACH
                LEFT JOIN 
                    SACH ON DAUSACH.MADAUSACH = SACH.MADAUSACH
                WHERE 
                    LOWER(CONCAT(DAUSACH.MADAUSACH, DAUSACH.TENSACH,  DAUSACH.TENTACGIA, DAUSACH.THELOAI,  DAUSACH.NXB,   SACH.MASACH,   SACH.TINHTRANG, SACH.VITRI )) LIKE '%' + LOWER('{mpm}') + '%'
                ORDER BY 
                    DAUSACH.TENSACH;
                ";
            }else if (radioDG.Checked==true)
            {
                sql = $@"
                SELECT 
                    MADG, TENDG,NGAYSINH,GT,DIACHI,EMAIL
  
                FROM 
                    DOCGIA
                WHERE 
                    LOWER(CONCAT(MADG,TENDG,GT,DIACHI,EMAIL)) LIKE '%' + LOWER('{mpm}') + '%'
                ORDER BY 
                    TENDG;
            ";
            }
            else {
                MessageBox.Show("Không có dữ liệu phù hợp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //DataTable lv = Public.LayDuLieu(sql);
            //listViewTK.Items.Clear();
            //listViewTK.View = View.Details;

            //// Thêm cột vào ListView
            //listViewTK.Columns.Add("Mã DS", 100);
            //listViewTK.Columns.Add("Tên Sách", 150);
            //listViewTK.Columns.Add("Tên Tác Giá", 200);

            //// Điều chỉnh tự động kích thước cột (nếu cần)
            //listViewTK.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //foreach (DataRow dr in lv.Rows)
            //{
            //    itemLV = new ListViewItem(new string[] { dr["MADAUSACH"].ToString(), dr["TENSACH"].ToString(), dr["TENTACGIA"].ToString(), dr["THELOAI"].ToString(), dr["SOLUONG"].ToString(), dr["NXB"].ToString() });
            //    listViewTK.Items.Add(itemLV);
            //}
            // Lấy dữ liệu từ database
            DataTable dt = Public.LayDuLieu(sql);

            // Xóa các mục và cột trong ListView trước khi hiển thị
            listViewTK.Items.Clear();
            listViewTK.Columns.Clear();

            if (dt.Rows.Count > 0)
            {
                // Tạo cột động dựa trên DataTable
                foreach (DataColumn column in dt.Columns)
                {
                    listViewTK.Columns.Add(column.ColumnName, 150);
                }

                // Thêm dữ liệu vào ListView
                foreach (DataRow dr in dt.Rows)
                {
                    var row = new List<string>();
                    foreach (DataColumn column in dt.Columns)
                    {
                        row.Add(dr[column.ColumnName]?.ToString() ?? string.Empty);
                    }

                    ListViewItem item = new ListViewItem(row.ToArray());
                    listViewTK.Items.Add(item);
                }

                // Tự động điều chỉnh kích thước cột
                // Điều chỉnh chiều rộng cột dựa trên nội dung
                foreach (ColumnHeader column in listViewTK.Columns)
                {
                    column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

                    // Đảm bảo chiều rộng tối thiểu
                    if (column.Width < 100)
                    {
                        column.Width = 100;
                    }

                    // Giới hạn chiều rộng tối đa
                    if (column.Width > 400)
                    {
                        column.Width = 400;
                    }
                }
            }
                    else
                    {
                      MessageBox.Show("Không có dữ liệu phù hợp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
        
            
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xuất danh sách tra cứu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            saveFileDialog.Title = "Chọn nơi lưu file Excel";
            saveFileDialog.FileName = "DanhSachTraCuu";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                Public.XuatFileExcelLV(listViewTK, filePath);
            }

            try
            {
                MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void listViewTK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}







