using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMT
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }
        private void setupdvSachMuon()
        {
            dgvtest.Columns.Clear();
            dgvtest.Columns.Add("MASACH", "Mã Sách");
            dgvtest.Columns.Add("MADAUSACH", "Mã Đầu Sách ");
            dgvtest.Columns.Add("TINHTRANG", "Tình Trạng");
            dgvtest.Columns.Add("TENSACH", "Tên Sách");
            dgvtest.Columns.Add("TENTACGIA", "Tác Giả");
            dgvtest.Columns.Add("NAMXB", "Năm xuất bản");

        }
        private void test_Load(object sender, EventArgs e)
        {

        }
    }
}
