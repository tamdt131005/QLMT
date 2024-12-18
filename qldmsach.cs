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

namespace baitaplon
{
    public partial class qldmsach : Form
    {
        public qldmsach()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            laydata();
        }
        void laydata()
        {
            string sql = $@"SELECT SACH.MASACH,DAUSACH.TENSACH,DAUSACH.NAMXB,DAUSACH.NXB,DAUSACH.NGONNGU,DAUSACH.SOLUONG
                            FROM SACH 
                            JOIN DAUSACH ON SACH.MADAUSACH =DAUSACH.MADAUSACH;";
            Public.GanNguonDataGridView(dgvSach, sql);

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
