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
    public partial class Flash : Form
    {
        public Flash()
        {
            InitializeComponent();
        }

        private void Splash_timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 2;

            if (progressBar1.Value <= 30)
                lbSplash.Text = "Khởi tạo ứng dụng .....";
            else
                if (progressBar1.Value <= 50)
                lbSplash.Text = "Nạp dữ liệu .....";
            else
                    if (progressBar1.Value <= 70)
                lbSplash.Text = "Tích hợp dữ liệu ....";
            else
                        if (progressBar1.Value <= 100)
                lbSplash.Text = "Đề nghị chờ ....";
            //
            if (progressBar1.Value == 100)
            {
                Splash_timer.Dispose();
                this.Hide();
            }
        }
        

        private void Flash_Load(object sender, EventArgs e)
        {
            Splash_timer.Enabled = true;
        }
    }
}
