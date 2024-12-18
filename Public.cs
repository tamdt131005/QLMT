using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMT
{
    internal class Public
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        static string sql;


        public static SqlConnection KetNoi()
        {
            string strConn = @"Data Source=.;Initial Catalog=QLTV74;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(strConn);
            return conn;
        }

        public static DataTable LayDuLieu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, KetNoi());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void GannguonListview(ListView test,string sql)
        {

        }
        public static void GanNguonDataGridView(DataGridView dgDanhSach, string sql)
        {
            dgDanhSach.DataSource = LayDuLieu(sql);
        }
        public static void GanNguonComboBox(ComboBox cboName, string TableName, string DisplayField, string KeyField)
        {
            sql = $"Select {KeyField},{DisplayField} From {TableName}";
            cboName.DataSource = LayDuLieu(sql);
            cboName.DisplayMember = DisplayField;
            cboName.ValueMember = KeyField;
        }
        public static bool XoaHang(DataGridView dtdanhsach, string bang, string cot, string dieukien)
        {
            string lenhxoa = "DELETE FROM " + bang + " WHERE " + cot + " = '" + dieukien + "'";
            try
            {
                cmd = new SqlCommand(lenhxoa, KetNoi());
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public static bool lenhthuchien(string lenhthuchien)
        {

            try
            {
                cmd = new SqlCommand(lenhthuchien, KetNoi());
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { return false;}

        }
        public static bool ThucHienSQL(string sql)
        {
            try
            {
                cmd = new SqlCommand(sql, KetNoi());
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực hiện truy vấn:" + ex.Message.ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }
        public static bool ktTrungMa(string FieldName, string Table, bool ktThem,string ValueNew, string ValueOld)
        {
            if (ktThem == true)
                sql = "Select " + FieldName + " From " + Table + " Where " +FieldName + " = '" + ValueNew + "'";
            else
                sql = "Select " + FieldName + " From " + Table + " Where " +FieldName + " = '" + ValueNew + "' and " + FieldName + " <> '" + ValueOld + "'";
            DataTable dt = LayDuLieu(sql);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static void XuatFileExcel(DataGridView dataGridView1, string fileName)
        {
           
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);//tạo mới một Workbooks bằng phương thức add()
                worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                //xuất danh sách tiêu đề cột
                for (int i = 0; i < dataGridView1.ColumnCount; i++)//tạo dòng tiêu đề từ cột trong DataGridView
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                //xuất danh sách nội dung dòng
                for (int i = 0; i < dataGridView1.RowCount; i++)//xuất nội dung các dòng tiếp theo
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = "'" + dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                workbook.SaveAs(fileName);//lưu tập tin                
                //workbook.Close();//đóng tập tin
                //excel.Quit();//thoát khỏi excel
                //Process.Start("Explorer.exe", fileName);//mở tập tin trên máy qua đường dẫn
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                worksheet = null;
                workbook = null;
            }
        }
        public static void XuatFileExcelLV(ListView listView1, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                //xuất danh sách tiêu đề cột
                for (int i = 0; i < listView1.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = listView1.Columns[i].Text;
                }
                //xuất danh sách nội dung dòng
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    int j = 0;
                    worksheet.Cells[i + 2, j + 1] = "'" + listView1.Items[i].Text;
                    for (j = 1; j < listView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = "'" + listView1.Items[i].SubItems[j].Text;
                    }
                }

                workbook.SaveAs(fileName);//lưu tập tin                
                //workbook.Close();//đóng tập tin
                //excel.Quit();//thoát khỏi excel
                //Process.Start("Explorer.exe", fileName);//mở tập tin trên máy qua đường dẫn
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                worksheet = null;
                workbook = null;
            }
        }
    }
}

    

