using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace QLCMND
{
    public partial class CanBo : Form
    {
        FingerprintData Bll = new FingerprintData();
        public CanBo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String MaCB = txtmacanbo.Text.ToString().Trim();
            String HoTen = txthovaten.Text.ToString().Trim();
            String NgaySinh = dateTimengaysinh.Text.ToString();
            String Capbac = txtcapbac.Text.ToString().Trim();
            String Chucvu = txtchucvu.Text.ToString().Trim();
            String Gioitinh = comboBox1.Text.ToString().Trim();
            if(MaCB.Equals("") || HoTen.Equals("") || NgaySinh.Equals("") || Capbac.Equals("") || Chucvu.Equals(""))
            {
                if(DialogResult.OK == MessageBox.Show("Ban chưa điền đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error))
                {
                    if (MaCB.Equals(""))
                        txtmacanbo.Focus();
                    else if(HoTen.Equals(""))
                        txthovaten.Focus();
                    else if (NgaySinh.Equals(""))
                        dateTimengaysinh.Focus();
                    else if (Capbac.Equals(""))
                        txtcapbac.Focus();
                    else if (Chucvu.Equals(""))
                        txtchucvu.Focus();
                }
                else
                {
                    MaCB = "";
                    HoTen = "";
                    NgaySinh = "";
                    Capbac = "";
                    Chucvu = "";

                }
            }
            else
            {
                Bll.Them_Canbo(MaCB, HoTen, NgaySinh, Gioitinh, Capbac, Chucvu);
                CanBo_Load(sender, e);
                MessageBox.Show("Đã thêm thành công cán bộ " + HoTen, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kết thúc", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            return;
        }

        private void CanBo_Load(object sender, EventArgs e)
        {

        }
    }
}
