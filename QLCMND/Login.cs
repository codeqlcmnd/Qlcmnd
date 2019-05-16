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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        FingerprintData BLL = new FingerprintData();
        private void btnOk_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text.ToString();
            String password = txtPassword.Text.ToString();
            String sql = "Select * from Taikhoan where Taikhoan = '" + username.Trim() + "' and Matkhau = '" + password.Trim() + "' and Xoa =0";
            DataTable dt = new DataTable();
            dt = BLL.get_Table(sql);
            if (Int32.Parse(dt.Rows.Count.ToString()) > 0)
            {
                Flash Flash = new Flash();
                Flash.ShowDialog();
                this.Hide();
                Main Main = new Main();
                Main.Show();
                
            }
            else
            {
                MessageBox.Show("Lỗi đăng nhập", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.ResetText();
            txtPassword.ResetText();
        }

        private void btnOk_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
