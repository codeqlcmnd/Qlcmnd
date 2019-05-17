using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCMND
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public int idlogin = 0;

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void gheToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TaoCMND_Click(object sender, EventArgs e)
        {
            CMND frm = new CMND();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CMND CMND_OP = new CMND();
                CMND_OP.MdiParent = this;
                CMND_OP.Show();
            }
        }

        private void TaoTK_Click(object sender, EventArgs e)
        {
            ToKhai frm = new ToKhai();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ToKhai ToKhai_OP = new ToKhai();
                ToKhai_OP.MdiParent = this;
                ToKhai_OP.Show();
            }

        }

        private void TaoCB_Click(object sender, EventArgs e)
        {
            ChiBan frm = new ChiBan();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ChiBan ChiBan_OP = new ChiBan();
                ChiBan_OP.MdiParent = this;
                ChiBan_OP.Show();
            }

        }

        private void GhepNoi_Click(object sender, EventArgs e)
        {
            /*
            GhepNoi frm = new GhepNoi();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                GhepNoi Ghep_CB_OP = new GhepNoi();
                Ghep_CB_OP.MdiParent = this;
                Ghep_CB_OP.Show();
            }*/
        }

        private void ThemCMND_Click(object sender, EventArgs e)
        {
            CMND frm = new CMND();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CMND CMND_OP = new CMND();
                CMND_OP.MdiParent = this;
                CMND_OP.Show();
            }

        }

        private void ThemTK_Click(object sender, EventArgs e)
        {
            ToKhai frm = new ToKhai();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ToKhai ToKhai_OP = new ToKhai();
                ToKhai_OP.MdiParent = this;
                ToKhai_OP.Show();
            }
        }

        private void ThemCB_Click(object sender, EventArgs e)
        {
            ChiBan frm = new ChiBan();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ChiBan ChiBan_OP = new ChiBan();
                ChiBan_OP.MdiParent = this;
                ChiBan_OP.Show();
            }
        }

        private void ThemCanbo_Click(object sender, EventArgs e)
        {
            CanBo frm = new CanBo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CanBo CanBo_OP = new CanBo();
                CanBo_OP.MdiParent = this;
                CanBo_OP.Show();
            }
        }

        private void ThemTaiKhoan_Click(object sender, EventArgs e)
        {
            
            TaiKhoan frm = new TaiKhoan();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                TaiKhoan TaiKhoan_OP = new TaiKhoan();
                TaiKhoan_OP.MdiParent = this;
                TaiKhoan_OP.Show();
            }
        }

        private void Ketthuc_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                Close();
            }
        }
    }
}
