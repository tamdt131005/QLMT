
using QLMT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLMT
{
    public partial class frmchitietphieumuon : Form
    {
        public frmchitietphieumuon()
        {
            InitializeComponent();
        }
        ListViewItem itemLV;
        string lenh;
        bool ktThem;
        public string mpm { get; set; }

        private void frmchitietphieumuon_Load(object sender, EventArgs e)
        {
              if (!string.IsNullOrEmpty(mpm))
            {
                laydatalv(mpm);
            }
            else
            {
                MessageBox.Show("Không có mã phiếu mượn để hiển thị chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
        void laydatalv(string mpm)
        {

            try
            {
                string sql = @"
                        SELECT PHIEUMUON.MAPM, PHIEUMUON.NGAYMUON, PHIEUMUON.NGAYDKTRA, 
                               DOCGIA.MADG, DOCGIA.TENDG, 
                               SACH.MASACH, 
                               DAUSACH.TENSACH, DAUSACH.TENTACGIA, DAUSACH.THELOAI, 
                               DAUSACH.NAMXB, DAUSACH.NXB, DAUSACH.SOLUONG
                        FROM PHIEUMUON
                        JOIN DOCGIA ON PHIEUMUON.MADG = DOCGIA.MADG
                        JOIN MUONTRA ON PHIEUMUON.MAPM = MUONTRA.MAPM
                        JOIN SACH ON MUONTRA.MASACH = SACH.MASACH
                        JOIN DAUSACH ON SACH.MADAUSACH = DAUSACH.MADAUSACH
                        WHERE PHIEUMUON.MAPM = '" + mpm + "';";

                DataTable lv = Public.LayDuLieu(sql);

                if (lv.Rows.Count > 0)
                {
                    DataRow row = lv.Rows[0];


                    tbxmaphieu.Text = row["MAPM"].ToString();
                    tbxngaymuon.Text = Convert.ToDateTime(row["NGAYMUON"]).ToString("dd/MM/yyyy");
                    tbxngaytra.Text = Convert.ToDateTime(row["NGAYDKTRA"]).ToString("dd/MM/yyyy");
                    tbxmadocgia.Text = row["MADG"].ToString();
                    tbxtendocgia.Text = row["TENDG"].ToString();


                    lvtchitiet.Items.Clear();

                    foreach (DataRow dr in lv.Rows)
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                            dr["MASACH"].ToString(),
                            dr["TENSACH"].ToString(),
                            dr["TENTACGIA"].ToString(),
                            dr["THELOAI"].ToString(),
                            dr["NAMXB"].ToString(),
                            dr["NXB"].ToString()
                        });

                        lvtchitiet.Items.Add(item);
                        lvtchitiet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        lvtchitiet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chi tiết phiếu mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết phiếu mượn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
           //  Public.XuatFileExcelLV(lvtchitiet, "D:/");
           // ExportFormToWord();
           //frmmuonv2 frmmuon = new frmmuonv2(); 
           // frmmuon.Show();
        }

        private void lvtchitiet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExportFormToWord()
        {
            try
            {
                var wordApp = new Microsoft.Office.Interop.Word.Application();
                var document = wordApp.Documents.Add();

                // Thêm tiêu đề
                var paragraph = document.Content.Paragraphs.Add();
                paragraph.Range.Text = "Chi Tiết Phiếu Mượn";
                paragraph.Range.Font.Bold = 1;
                paragraph.Range.Font.Size = 14;
                paragraph.Range.InsertParagraphAfter();

                // Thêm thông tin chung
                var details = $"Mã Phiếu Mượn: {tbxmaphieu.Text}\n" +
                              $"Ngày Mượn: {tbxngaymuon.Text}\n" +
                              $"Ngày Trả Dự Kiến: {tbxngaytra.Text}\n" +
                              $"Mã Độc Giả: {tbxmadocgia.Text}\n" +
                              $"Tên Độc Giả: {tbxtendocgia.Text}\n";
                paragraph.Range.Text = details;
                paragraph.Range.Font.Bold = 0;
                paragraph.Range.Font.Size = 12;
                paragraph.Range.InsertParagraphAfter();

                // Thêm bảng chi tiết sách
                var table = document.Tables.Add(paragraph.Range, lvtchitiet.Items.Count + 1, lvtchitiet.Columns.Count);
                table.Borders.Enable = 1;

                // Thêm tiêu đề cột
                for (int i = 0; i < lvtchitiet.Columns.Count; i++)
                {
                    table.Cell(1, i + 1).Range.Text = lvtchitiet.Columns[i].Text;
                }

                // Thêm dữ liệu chi tiết sách
                for (int i = 0; i < lvtchitiet.Items.Count; i++)
                {
                    for (int j = 0; j < lvtchitiet.Columns.Count; j++)
                    {
                        table.Cell(i + 2, j + 1).Range.Text = lvtchitiet.Items[i].SubItems[j].Text;
                    }
                }

                // Lưu và mở tài liệu Word
                string filePath = "D:\\ChiTietPhieuMuon.docx";
                document.SaveAs2(filePath);
                document.Close();
                wordApp.Quit();

                MessageBox.Show($"Xuất dữ liệu thành công! File lưu tại: {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
