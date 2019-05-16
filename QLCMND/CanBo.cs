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
            if (MaCB.Equals("") || HoTen.Equals("") || NgaySinh.Equals("") || Capbac.Equals("") || Chucvu.Equals(""))
            {
                if (DialogResult.OK == MessageBox.Show("Ban chưa điền đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error))
                {
                    if (MaCB.Equals(""))
                        txtmacanbo.Focus();
                    else if (HoTen.Equals(""))
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
            else if (Bll.Dem_Canbo(String.Format("sohieu = '{0}'", MaCB)) > 0)
            {
                MessageBox.Show("Số hiệu trùng", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
            String MaCB = txtmacanbo.Text.ToString().Trim();
            String HoTen = txthovaten.Text.ToString().Trim();
            String NgaySinh = dateTimengaysinh.Text.ToString();
            String Capbac = txtcapbac.Text.ToString().Trim();
            String Chucvu = txtchucvu.Text.ToString().Trim();
            String Gioitinh = comboBox1.Text.ToString().Trim();
            if (MaCB.Equals("") || HoTen.Equals("") || NgaySinh.Equals("") || Capbac.Equals("") || Chucvu.Equals(""))
            {
                if (DialogResult.OK == MessageBox.Show("Ban chưa điền đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error))
                {
                    if (MaCB.Equals(""))
                        txtmacanbo.Focus();
                    else if (HoTen.Equals(""))
                        txthovaten.Focus();
                    else if (NgaySinh.Equals(""))
                        dateTimengaysinh.Focus();
                    else if (Capbac.Equals(""))
                        txtcapbac.Focus();
                    else if (Chucvu.Equals(""))
                        txtchucvu.Focus();
                }
                
            }
            else if(Bll.Dem_Canbo(String.Format("sohieu = '{0}'", MaCB))>0 && !MaCB.Equals(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString()))
            {
                MessageBox.Show("Số hiệu trùng", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                Bll.Sua_Canbo(MaCB, HoTen, NgaySinh, Gioitinh, Capbac, Chucvu, dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                CanBo_Load(sender, e);
                MessageBox.Show("Đã sửa thành công cán bộ " + HoTen, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text.ToString().Trim() == null)
                MessageBox.Show("Bạn phải chọn cán bộ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (DialogResult.OK == MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
            {
                Bll.xoa("CanBo", "SoHieu", txtmacanbo.Text.ToString().Trim());
                MessageBox.Show("Đã xóa thành công cán bộ " + txthovaten.Text.ToString().Trim(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                CanBo_Load(sender, e);
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

        private void CanBo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bll.dataset().Tables[0];
            comboBox1.Text = "Nam";
            

        }

        private void dataGridView1_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int dong = 0;
            try
            {
                dong = dataGridView1.CurrentRow.Index;
            }
            catch
            {

            }
            txthovaten.Text = (string)dataGridView1.Rows[dong].Cells[2].Value.ToString();
            txtmacanbo.Text = (string)dataGridView1.Rows[dong].Cells[1].Value.ToString();
            dateTimengaysinh.Text = (string)dataGridView1.Rows[dong].Cells[3].Value.ToString();
            txtcapbac.Text = (string)dataGridView1.Rows[dong].Cells[5].Value.ToString();
            txtchucvu.Text = (string)dataGridView1.Rows[dong].Cells[6].Value.ToString();
            comboBox1.Text = (string)dataGridView1.Rows[dong].Cells[4].Value.ToString();



        }
    }
}
