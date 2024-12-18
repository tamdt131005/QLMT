using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace QLMT
{
    public partial class frmmuonv2 : Form
    {
        public frmmuonv2()
        {
            InitializeComponent();
            randomphieumuon();
        }
        string MaMT;
        string maDauSach;
        string timdg;
      
        private void frmmuon_Load(object sender, EventArgs e)
            
        {
            
            setupdvSachMuon();
            datasach();
            datadocgia("select MADG,TENDG,EMAIL from DOCGIA;");
            txtMaDocGia.Focus();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            timdg = txtMaDocGia.Text;
            string lenh = $@"select MADG,TENDG,EMAIL from DOCGIA
                             where concat(MADG,TENDG,EMAIL) LIKE '%' + LOWER('{timdg}') + '%';";
            datadocgia(lenh);
            
        }

        private void dgvDocGia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn chọn độc giả này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (dgvDocGia.RowCount <= 0) return;
                    if (e == null) return;
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = dgvDocGia.Rows[e.RowIndex];
                        txtMaDocGia.Text = row.Cells[0].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi phát sinh:" + ex.Message, "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else return;
        }
        // Cấu hình cột cho DataGridView dgvSachMuon
        private void setupdvSachMuon()
        {
            dgvSachMuon.Columns.Clear();
            dgvSachMuon.Columns.Add("MASACH", "Mã Sách");
            dgvSachMuon.Columns.Add("TENSACH", "Tên Sách");
            dgvSachMuon.Columns.Add("TENTACGIA", "Tác Giả");
            dgvSachMuon.Columns.Add("MADAUSACH", "Mã Đầu Sách ");
      
        }

        // Tải dữ liệu sách có trạng thái "Available" vào DataGridView
        private void datasach()
        {
            try
            {
                string query = "SELECT SACH.MASACH, DAUSACH.TENSACH, DAUSACH.TENTACGIA, SACH.TINHTRANG,DAUSACH.MADAUSACH, COALESCE(DAUSACH.SOLUONG, 0) AS SOLUONG FROM SACH JOIN DAUSACH ON SACH.MADAUSACH = DAUSACH.MADAUSACH WHERE SACH.TINHTRANG = N'Tot' AND COALESCE(DAUSACH.SOLUONG, 0) > 0;";
                Public.GanNguonDataGridView(dgvSach, query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void datadocgia(string lenh)
        {
            try
            {
                
                Public.GanNguonDataGridView(dgvDocGia, lenh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Kiểm tra xem sách đã tồn tại trong danh sách mượn hay chưa
        private bool KiemTraSachDaTonTai(string maSach)
        {
            foreach (DataGridViewRow row in dgvSachMuon.Rows)
            {
                if (row.Cells["MASACH"].Value?.ToString() == maSach)
                {
                    return true;
                }
            }
            return false;
        }

        // Thêm sách vào danh sách mượn
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSach?.SelectedRows?.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvSach.SelectedRows)
                    {
                        if (row.Cells["MASACH"] != null && row.Cells["TENSACH"] != null && row.Cells["TENTACGIA"] != null && row.Cells["SOLUONG"] != null&& row.Cells["MADAUSACH"] != null)
                        {
                            string maSach = row.Cells["MASACH"].Value?.ToString();
                            string tenSach = row.Cells["TENSACH"].Value?.ToString();
                            string tacGia = row.Cells["TENTACGIA"].Value?.ToString();
                            string maDauSach= row.Cells["MADAUSACH"].Value?.ToString(); 
                           
                            if (int.TryParse(row.Cells["SOLUONG"]?.Value?.ToString(), out int soLuong))
                            {
                                if (soLuong <= 0)
                                {
                                    MessageBox.Show($"Sách '{tenSach}' không còn đủ số lượng để mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    continue;
                                }

                                if (!KiemTraSachDaTonTai(maSach))
                                {
                                    dgvSachMuon.Rows.Add(maSach, tenSach, tacGia,maDauSach);
                                }
                                else
                                {
                                    MessageBox.Show($"Sách '{tenSach}' đã có trong danh sách mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Dữ liệu số lượng cho sách '{tenSach}' không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu không đầy đủ, vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một sách để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hủy chọn sách khỏi danh sách mượn
        private void btnHuyChonSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sách khỏi danh sách mượn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvSachMuon.SelectedRows)
                    {
                        dgvSachMuon.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hủy chọn sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lưu phiếu mượn và cập nhật trạng thái sách trong cơ sở dữ liệu
        private void btnLuuPhieuMuon_Click(object sender, EventArgs e)
        {
            randommamuontra();
            try
            {
                string maPM = txtMaPhieuMuon.Text;
                
                string ngayMuon = dtpNgayMuon.Value.ToString("yyyy-MM-dd");
                string ngayDKTra = dtpNgayTra.Value.ToString("yyyy-MM-dd");
                string maDG = txtMaDocGia.Text;


                if (string.IsNullOrEmpty(maPM) || string.IsNullOrEmpty(maDG) || dgvSachMuon.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu mượn và chọn ít nhất một sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (DataGridViewRow row in dgvSachMuon.Rows)
                {
                    string maDauSach = row.Cells["MADAUSACH"].Value.ToString();
                    string maSach = row.Cells["MASACH"].Value.ToString();
                    string queryPhieuMuon = $@"BEGIN TRANSACTION;
                                               INSERT INTO PHIEUMUON (MAPM, NGAYMUON, NGAYDKTRA, MADG,MANV) VALUES ('{maPM}', '{ngayMuon}','{ngayDKTra}', '{maDG}',Null);
                                               INSERT INTO MUONTRA (MAMT,MAPM, MASACH,NGAYTRA) VALUES ('{MaMT}','{maPM}','{maSach.Replace(" ", "")}','{ngayDKTra}');
                                               COMMIT;";
                    
                    if (Public.lenhthuchien(queryPhieuMuon)== true)
                    {
                       
                        string queryCapNhatTinhTrang = $@"BEGIN TRANSACTION;                                                               
                                                                UPDATE DAUSACH
                                                                SET SOLUONG = CASE WHEN SOLUONG > 0 THEN SOLUONG - 1 ELSE 0 END
                                                                WHERE MADAUSACH = '{maDauSach}';
                                                                COMMIT;";
                        if (Public.lenhthuchien(queryCapNhatTinhTrang) == true)
                        {
                            MessageBox.Show($"Thành công cập nhật trạng thái sách mã '{maDauSach}'.", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show("Lưu phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvSachMuon.Rows.Clear();
                            datasach();
                            return;
                        }
                        else MessageBox.Show($"Lỗi khi cập nhật trạng thái sách mã '{maDauSach}'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu phiếu mượn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thoát khỏi form mượn sách
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void randomphieumuon()
        {
            try
            {
                string query = "SELECT TOP 1 MAPM FROM PHIEUMUON ORDER BY MAPM DESC;";
                DataTable dt = Public.LayDuLieu(query);

                if (dt.Rows.Count > 0)
                {
                    string lastMaPM = dt.Rows[0]["MAPM"].ToString();
                    int nextNumber = int.Parse(lastMaPM.Substring(2)) + 1;
                    txtMaPhieuMuon.Text = "PM" + nextNumber.ToString("D3");
                }
                else
                {
                    txtMaPhieuMuon.Text = "PM001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã phiếu mượn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void randommamuontra()
        {
            try
            {
                string lenh = "SELECT TOP 1 MAMT FROM MUONTRA ORDER BY MAMT DESC;";
                DataTable dt = Public.LayDuLieu(lenh);
                
                if (dt.Rows.Count > 0)
                {
                    MaMT = dt.Rows[0]["MAMT"].ToString();
                    int nextNumber = int.Parse(MaMT.Substring(2)) + 1;
                    MaMT = "MT" + nextNumber.ToString("D3");
                }
                else
                {
                    MaMT = "MT001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã phiếu mượn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtMaPhieuMuon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaDocGia_TextChanged(object sender, EventArgs e)
        {
            txtMaDocGia.Focus();
        }

        private void btchitiet_Click(object sender, EventArgs e)
        {
            frmchitietphieumuon chiTietForm = new frmchitietphieumuon();
            chiTietForm.mpm = txtMaPhieuMuon.Text;
            chiTietForm.ShowDialog();
        }
    }
}
