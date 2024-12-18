using System;
using System.Data;
using System.Windows.Forms;

namespace QLMT
{
    public partial class FrmTraSach : Form
    {
        public FrmTraSach()
        {
            InitializeComponent();
        }
        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null && txt.ForeColor == System.Drawing.Color.Gray)
            {
                txt.Text = "";
                txt.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null && string.IsNullOrWhiteSpace(txt.Text))
            {
                if (txt == txtMaPhieuMuon)
                {
                    txt.Text = "Nhập mã phiếu mượn";
                }
                else if (txt == txtMaSach)
                {
                    txt.Text = "Nhập mã sách";
                }
                txt.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void FrmTraSach_Load(object sender, EventArgs e)
        {
            // Hiển thị danh sách sách mượn
            string sql = @"SELECT MT.MAMT, PM.MAPM, DG.TENDG, DS.TENSACH, S.MASACH, MT.NGAYTRA 
                          FROM MUONTRA MT
                          JOIN PHIEUMUON PM ON MT.MAPM = PM.MAPM
                          JOIN DOCGIA DG ON PM.MADG = DG.MADG
                          JOIN SACH S ON MT.MASACH = S.MASACH
                          JOIN DAUSACH DS ON S.MADAUSACH = DS.MADAUSACH
                          WHERE MT.NGAYTRA IS NULL";
            Public.GanNguonDataGridView(dgvDanhSachSach, sql);
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieuMuon.Text) || string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã phiếu mượn và mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhieuMuon = txtMaPhieuMuon.Text;
            string maSach = txtMaSach.Text;
            string ngayTra = DateTime.Now.ToString("yyyy-MM-dd");

            // Cập nhật thông tin trả sách trong bảng MUONTRA
            string sqlUpdateMuonTra = $"UPDATE MUONTRA SET NGAYTRA = '{ngayTra}' WHERE MAPM = '{maPhieuMuon}' AND MASACH = '{maSach}';";

            // Cập nhật trạng thái sách trong bảng SACH
            string sqlUpdateSach = $"UPDATE SACH SET TINHTRANG = N'Tot' WHERE MASACH = '{maSach}';";

            // Thực hiện các lệnh SQL
            if (Public.ThucHienSQL(sqlUpdateMuonTra) && Public.ThucHienSQL(sqlUpdateSach))
            {
                MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Refresh danh sách
                FrmTraSach_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không thể trả sách, vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
            private void dgvDanhSachSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
            try
            {
                if (dgvDanhSachSach.RowCount <= 0) return;
                if (e == null) return;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvDanhSachSach.Rows[e.RowIndex];

                    // Gán giá trị từ DataGridView vào TextBox
                    txtMaPhieuMuon.Text = row.Cells["MAPM"].Value?.ToString();
                    txtMaSach.Text = row.Cells["MASACH"].Value?.ToString();

                    // Đặt lại màu và kiểu chữ (không còn là placeholder)
                    txtMaPhieuMuon.ForeColor = System.Drawing.Color.Black;
                    txtMaSach.ForeColor = System.Drawing.Color.Black;
                    txtMaPhieuMuon.Font = new System.Drawing.Font(txtMaPhieuMuon.Font, System.Drawing.FontStyle.Bold);
                    txtMaSach.Font = new System.Drawing.Font(txtMaSach.Font, System.Drawing.FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi phát sinh: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

