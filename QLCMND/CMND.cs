using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using PatternRecognition.FingerprintRecognition.Core;

namespace QLCMND
{
    public partial class CMND : Form
    {
        string macmndcu = "";
        string idtokhai = "";
        private Bitmap img;
        private string urlanh = null;
        Business Bll = new Business();
        public CMND()
        {
            InitializeComponent();
        }

        private void rad_CapDoi_CheckedChanged(object sender, EventArgs e)
        {
            btntaoma.Visible = false;
        }

        private void rad_CapMoi_CheckedChanged(object sender, EventArgs e)
        {
            btntaoma.Visible = true;
        }

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

        private void btnChapNhan_Click(object sender, EventArgs e)
        {

        }

        private void txtToKhai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                string idtk = txtToKhai.Text.Replace("TK","");
               
                if (Bll.Dem_TK(String.Format("id = '{0}'", idtk)) > 0)
                {

                    CMND_Load(sender, e);
                    btnSua.Visible = true;
                    DataTable dt2 = Bll.get_Table(String.Format("Select * from tokhai where id like {0}", idtk));
                    if (rad_CapDoi.Checked)
                    {
                        txtSoCMND.Text = dt2.Rows[0]["SoCMND"].ToString();
                        btntaoma.Visible = false;
                    }
                    else
                    {
                        btntaoma.Visible = true;
                    }
                    txtHoTen.Text = dt2.Rows[0]["HoVaTen"].ToString();
                    cboGioiTinh.Text = dt2.Rows[0]["GioiTinh"].ToString();
                    txtTenGoiKhac.Text = dt2.Rows[0]["TenGoiKhac"].ToString();
                    txtNgaySinh.Text = dt2.Rows[0]["NgaySinh"].ToString();
                    txtNoiSinh.Text = dt2.Rows[0]["NoiSinh"].ToString();
                    txtNguyenQuan.Text = dt2.Rows[0]["NguyenQuan"].ToString();
                    txtDKHKTT.Text = dt2.Rows[0]["HoKhauThuongTru"].ToString();
                    txtNgheNghiep.Text = dt2.Rows[0]["NgheNghiep"].ToString();
                    cboDanToc.Text = dt2.Rows[0]["DanToc"].ToString();
                    cboTonGiao.Text = dt2.Rows[0]["TonGiao"].ToString();
                    txtTrinhDo.Text = dt2.Rows[0]["TrinhDo"].ToString();
                    txtTenCha.Text = dt2.Rows[0]["HoTenCha"].ToString();
                    txtTenMe.Text = dt2.Rows[0]["HoTenMe"].ToString();
                    txtTenVoChong.Text = dt2.Rows[0]["HoTenVoChong"].ToString();
                    txtDauVetRieng.Text = dt2.Rows[0]["DauVetRieng"].ToString();
                    txtSoCMNDCu.Text = dt2.Rows[0]["SoCMNDCu"].ToString();
                    txtNgayCap.Text = dt2.Rows[0]["NgayCapCu"].ToString();
                    txtNoiCap.Text = dt2.Rows[0]["NoiCap"].ToString();
                    txtLyDo.Text = dt2.Rows[0]["LyDo"].ToString();
                    macmndcu = txtSoCMND.Text;
                    idtokhai = dt2.Rows[0]["ID"].ToString();
                    if (dt2.Rows[0]["AnhCM"].ToString() != null)
                    {
                        if (!dt2.Rows[0]["AnhCM"].ToString().Equals(""))
                        {
                            img = ImageLoader.LoadImage(dt2.Rows[0]["AnhCM"].ToString());
                            pictureBox1.Image = img;
                        }
                    }

                }
            }
        }

        private void CMND_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            cboGioiTinh.Text = "";
            txtTenGoiKhac.Text = "";
            txtNgaySinh.Text = "";
            txtNoiSinh.Text = "";
            txtNguyenQuan.Text = "";
            txtDKHKTT.Text = "";
            txtNgheNghiep.Text = "";
            cboDanToc.Text = "";
            cboTonGiao.Text = "";
            txtTrinhDo.Text = "";
            txtTenCha.Text = "";
            txtTenMe.Text = "";
            txtTenVoChong.Text = "";
            txtDauVetRieng.Text = "";
            txtSoCMNDCu.Text = "";
            txtNgayCap.Text = "";
            txtNoiCap.Text = "";
            txtLyDo.Text = "";
            pictureBox1.Image = null;
            btntaoma.Visible = false;
            btnSua.Visible = false;
            
        }

        private void btntaoma_Click(object sender, EventArgs e)
        {

        }
    }
}
