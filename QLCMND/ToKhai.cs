using PatternRecognition.FingerprintRecognition.Core;
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
    public partial class ToKhai : Form
    {
        public ToKhai()
        {
            InitializeComponent();
        }

        private Bitmap img;
        private string urlanh = null;
 
        private void button2_Click(object sender, EventArgs e)
        {
            
                 try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    urlanh = openFileDialog1.FileName.ToString();
                    img = ImageLoader.LoadImage(openFileDialog1.FileName);
                    pictureBox1.Image = img;
                }
            }
            catch
            { };
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {

        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            string[] ToKhaiInfo = new string[22];
            ToKhaiInfo[0] = txtSoCMND.Text;
            ToKhaiInfo[1] = txtHoTen.Text;
            ToKhaiInfo[2] = cboGioiTinh.Text;
            ToKhaiInfo[3] = txtTenGoiKhac.Text;
            ToKhaiInfo[4] = txtNgaySinh.Text;
            ToKhaiInfo[5] = txtNoiSinh.Text;
            ToKhaiInfo[6] = txtNguyenQuan.Text;
            ToKhaiInfo[7] = txtDKHKTT.Text;
            ToKhaiInfo[8] = txtNgheNghiep.Text;
            ToKhaiInfo[9] = cboDanToc.Text;
            ToKhaiInfo[10] = cboTonGiao.Text;
            ToKhaiInfo[11] = txtTrinhDo.Text;
            ToKhaiInfo[12] = txtTenCha.Text;
            ToKhaiInfo[13] = txtTenMe.Text;
            ToKhaiInfo[14] = txtTenVoChong.Text;
            ToKhaiInfo[15] = txtDauVetRieng.Text;
            ToKhaiInfo[16] = txtSoCMNDCu.Text;
            ToKhaiInfo[17] = txtNgayCap.Text;
            ToKhaiInfo[18] = txtNoiCap.Text;
            ToKhaiInfo[19] = txtLyDo.Text;
            ToKhaiInfo[20] = urlanh;
            ToKhaiInfo[21] = main.idlogin.ToString();



        }
    }
}
