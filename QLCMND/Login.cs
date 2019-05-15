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
            String sql = "Select * from Taikhoan where Taikhoan = '" + username + "' and Matkhau = '" + password + "' and Xoa =0";
            DataGridView datag = new DataGridView();
            DataTable dt = new DataTable();
            dt = BLL.Datatable_SQL(sql);
            datag.DataSource = dt;
            if (Int32.Parse(datag.RowCount.ToString()) > 0)
            {
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
    }
}
