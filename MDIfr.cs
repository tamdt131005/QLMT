using baitaplon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThongKeMuonTra;

namespace QLMT
{
    public partial class MDIfr : Form
    {
        public MDIfr()
        {
            InitializeComponent();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmuonv2 chiTietForm = new frmmuonv2();
            chiTietForm.ShowDialog();
        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmphieumuon chiTietForm = new frmphieumuon();
            chiTietForm.ShowDialog();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timkiem chiTietForm = new timkiem();
            chiTietForm.ShowDialog();
        }

        private void thốngKêTheoTìnhTrạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongke2 frm= new thongke2();
            frm.ShowDialog();
        }

        private void thốngKêTheoThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           thongketheloai frm= new thongketheloai();
            frm.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frm= new frmDangNhap();
            frm.ShowDialog();
            this.Close();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qldmsach frm= new qldmsach();
            frm.ShowDialog();
        }
    }
}
