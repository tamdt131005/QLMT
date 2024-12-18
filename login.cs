using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLMT
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void lblMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLTV74;Integrated Security=True;Encrypt=False"); 
            try
            {
                conn.Open(); 
                string TenDangNhap = txtTenDangNhap.Text;
                string MatKhau = txtMatKhau.Text;
                string sql = "select*from NguoiDung where TENDANGNHAP='" + TenDangNhap + "' and MATKHAU = '" + MatKhau + "' ;"; 
                SqlCommand cmd = new SqlCommand(sql, conn); 
                SqlDataReader dta = cmd.ExecuteReader(); 
                if (dta.Read() == true) 
                {
                    MDIfr frm = new MDIfr();
                    frm.Show();
                    this.Hide();
                } 
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối"); 
            }
        }
        
        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
          
        }
    }
}
