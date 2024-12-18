
using QLMT;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLMT
{
    public partial class frmphieumuon : Form
    {
        SqlConnection conn;

        public frmphieumuon()
        {
            InitializeComponent();
        }

   
    
        private void frmphieumuon_Load(object sender, EventArgs e)
        {
            gandata();
        }

        private void gandata()
        {
            try
            {
                string sql = "SELECT * FROM PhieuMuon";
                Public.GanNguonDataGridView(dgvPhieuMuon,sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void xoadata()
        {
            try
            {
                dgvPhieuMuon.DataSource = null;
                dgvPhieuMuon.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimKiem.Text;
                string query = $"SELECT * FROM PhieuMuon WHERE MADG LIKE '%{keyword}%';";
                dgvPhieuMuon.DataSource = Public.LayDuLieu(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.SelectedRows.Count > 0)
            {

                string MaPM = dgvPhieuMuon.SelectedRows[0].Cells["MaPM"].Value.ToString();
                string lenh = $"DELETE FROM PHIEUMUON WHERE MaPM = '{MaPM}';";
                if (Public.lenhthuchien(lenh) == true)
                {
                    xoadata();
                    gandata();
                    MessageBox.Show("Xóa phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Lỗi khi xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
          // Public.XuatFileExcel(dgvPhieuMuon, "D:/test");
        }

        private void btchitietphieumuon_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.SelectedRows.Count > 0)
            {
                try
                {
                    string MaPM = dgvPhieuMuon.SelectedRows[0].Cells["MaPM"].Value.ToString();

                    frmchitietphieumuon chiTietForm = new frmchitietphieumuon();
                    chiTietForm.mpm = MaPM;
                    chiTietForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xem chi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
