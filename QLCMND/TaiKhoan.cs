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
    public partial class TaiKhoan : Form
    {
        Business Bll = new Business();
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHovaten.Text.Equals("") || txtmatkhau.Text.Equals("") || comboBox2.Text.Equals("") || txttaikhoan.Text.Equals("")||comboBox1.Text.Equals(""))
            {
                if (DialogResult.OK == MessageBox.Show("Ban chưa điền đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error))
                {
                    if (txtHovaten.Text.Equals(""))
                        txtHovaten.Focus();
                    else if (txtmatkhau.Text.Equals(""))
                        txtmatkhau.Focus();
                    else if (comboBox2.Text.Equals(""))
                        comboBox2.Focus();
                    else if (txttaikhoan.Text.Equals(""))
                        txttaikhoan.Focus();
                    else if (comboBox1.Text.Equals(""))
                        comboBox1.Focus();
                }
                else
                {
                    txtHovaten.Text = "";
                    txtmatkhau.Text = "";
                    comboBox2.Text = "";
                    txttaikhoan.Text = "";
                    

                }
            }
            else if (Bll.Dem_Taikhoan(String.Format("taikhoan = '{0}'", txttaikhoan.Text)) > 0)
            {
                MessageBox.Show("Tài khoản trùng", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (Bll.Dem_Taikhoan(String.Format("macanbo = '{0}'", comboBox1.SelectedValue)) > 0)
            {
                MessageBox.Show("Mã cán bộ trùng", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                Bll.Them_Taikhoan(Int32.Parse(comboBox1.SelectedValue.ToString()), txttaikhoan.Text.ToString().Trim(), txtmatkhau.Text.ToString().Trim(), comboBox2.Text.ToString().Trim());
                TaiKhoan_Load(sender, e);
                MessageBox.Show("Đã thêm thành công tài khoản " + txtHovaten.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Bll.dataset().Tables[0];
            comboBox1.DisplayMember = "HoTen";
            comboBox1.ValueMember = "ID";
           
            DataTable dt = Bll.get_Table(String.Format("select t.id,c.hoten,c.ngaysinh,c.capbac,c.chucvu,t.taikhoan,t.matkhau from taikhoan t JOIN canbo c on t.macanbo = c.id"));
            dataGridView1.DataSource = dt;
            DataTable dt2 = Bll.get_Table(String.Format("Select * from canbo where id = {0}", comboBox1.SelectedValue));
            txtHovaten.Text = dt2.Rows[0][2].ToString();
            dateTimePicker1.Text = dt2.Rows[0][3].ToString();
            txtcapbac.Text = dt2.Rows[0][5].ToString();
            txtchucvu.Text = dt2.Rows[0][6].ToString();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = Bll.get_Table(String.Format("Select * from canbo where id = {0}", comboBox1.SelectedValue));
            txtHovaten.Text = dt.Rows[0][2].ToString();
            dateTimePicker1.Text = dt.Rows[0][3].ToString();
            txtcapbac.Text = dt.Rows[0][5].ToString();
            txtchucvu.Text = dt.Rows[0][6].ToString();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString().Trim() == null)
                MessageBox.Show("Bạn phải chọn tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (DialogResult.OK == MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
            {
                Bll.xoa("Taikhoan", "macanbo", comboBox1.SelectedValue.ToString());
                MessageBox.Show("Đã xóa thành công tài khoản " + txtHovaten.Text.ToString().Trim(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TaiKhoan_Load(sender, e);
            }
            else if (DialogResult.Cancel == MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kết thúc", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            return;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int dong = 0;
            DataTable dt = null;
            DataTable dt2 = null;
            try
            {
                dong = dataGridView1.CurrentRow.Index;
                dt2 = Bll.get_Table(String.Format("Select * from taikhoan where id = {0}", dataGridView1.Rows[dong].Cells[0].Value.ToString()));
                if (dt2.Rows.Count > 0)
                {
                    dt = Bll.get_Table(String.Format("Select * from canbo where id = {0}", dt2.Rows[0]["MaCanBo"].ToString()));
                }
                
            }
            catch
            {
               
            }
            try
            {
                if (dt.Rows.Count > 0)
                {

                    txtHovaten.Text = dt.Rows[0]["HoTen"].ToString();
                    dateTimePicker1.Text = dt.Rows[0]["NgaySinh"].ToString();
                    txtcapbac.Text = dt.Rows[0]["CapBac"].ToString();
                    txtchucvu.Text = dt.Rows[0]["ChucVu"].ToString();
                    comboBox1.SelectedValue = dt.Rows[0]["ID"].ToString();
                    comboBox1.Text = dt.Rows[0]["HoTen"].ToString();
                    txttaikhoan.Text = dt2.Rows[0]["TaiKhoan"].ToString();
                    txtmatkhau.Text = dt2.Rows[0]["MatKhau"].ToString();

                }
            }
            catch { }
            
        }
    }
}
