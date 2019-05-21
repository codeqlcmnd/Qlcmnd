using PatternRecognition.FingerprintRecognition.Core;
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
    public partial class ToKhai : Form
    {
        public ToKhai()
        {
            InitializeComponent();
        }
        string macmndcu = "";
        string idtokhai = "";
        private Bitmap img;
        private string urlanh = null;
        Business Bll = new Business();
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
            string[] CheckTK = new string[22];
           
            CheckTK[1] = txtHoTen.Text;
            CheckTK[2] = cboGioiTinh.Text;
            CheckTK[3] = txtTenGoiKhac.Text;
            CheckTK[4] = txtNgaySinh.Text;
            CheckTK[5] = txtNoiSinh.Text;
            CheckTK[6] = txtNguyenQuan.Text;
            CheckTK[7] = txtDKHKTT.Text;
            CheckTK[8] = txtNgheNghiep.Text;
            CheckTK[9] = cboDanToc.Text;
            CheckTK[10] = cboTonGiao.Text;
            CheckTK[11] = txtTrinhDo.Text;
            CheckTK[12] = txtTenCha.Text;
            CheckTK[13] = txtTenMe.Text;
            CheckTK[14] = txtTenVoChong.Text;
            CheckTK[15] = txtDauVetRieng.Text;

            CheckTK[19] = txtLyDo.Text;
           
           
            Boolean oke = true;
            foreach (string i in CheckTK)
            {
                if(i != null)
                    if (i.Equals(""))
                    {
                        MessageBox.Show("Bạn chưa điền đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        oke = false;
                        break;
                    }
            }
            if(Bll.Dem_TK(String.Format("SoCMND = '{0}'", txtSoCMND.Text))>0)
            {
                MessageBox.Show("Số CMND bị trùng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                oke = false;
              
            }
            if(oke)
            {
                Bll.Them_ToKhai(ToKhaiInfo);
                MessageBox.Show("Đã thêm thành công tờ khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ToKhai_Load(sender, e);
            }

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kết thúc", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            return;
        }

        private void txtSoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (Bll.Dem_TK(String.Format("SoCMND = '{0}'", txtSoCMND.Text)) > 0)
                {
                    
                    ToKhai_Load(sender, e);
                    btnSua.Visible = true;
                    BtnVanTay.Visible = true;
                    DataTable dt2 = Bll.get_Table(String.Format("Select * from tokhai where SoCMND like {0}", txtSoCMND.Text));
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

        private void ToKhai_Load(object sender, EventArgs e)
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
            btnSua.Visible = false;
            BtnVanTay.Visible = false;


        }

        private void btnSua_Click(object sender, EventArgs e)
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
            string[] CheckTK = new string[22];

            CheckTK[1] = txtHoTen.Text;
            CheckTK[2] = cboGioiTinh.Text;
            CheckTK[3] = txtTenGoiKhac.Text;
            CheckTK[4] = txtNgaySinh.Text;
            CheckTK[5] = txtNoiSinh.Text;
            CheckTK[6] = txtNguyenQuan.Text;
            CheckTK[7] = txtDKHKTT.Text;
            CheckTK[8] = txtNgheNghiep.Text;
            CheckTK[9] = cboDanToc.Text;
            CheckTK[10] = cboTonGiao.Text;
            CheckTK[11] = txtTrinhDo.Text;
            CheckTK[12] = txtTenCha.Text;
            CheckTK[13] = txtTenMe.Text;
            CheckTK[14] = txtTenVoChong.Text;
            CheckTK[15] = txtDauVetRieng.Text;

            CheckTK[19] = txtLyDo.Text;


            Boolean oke = true;
            foreach (string i in CheckTK)
            {
                if (i != null)
                    if (i.Equals(""))
                    {
                        MessageBox.Show("Bạn chưa điền đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        oke = false;
                        break;
                    }
            }
            if (Bll.Dem_TK(String.Format("SoCMND = '{0}'", txtSoCMND.Text)) > 0 && (txtSoCMND.Text!=macmndcu))
            {
                MessageBox.Show("Số CMND bị trùng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                oke = false;

            }
            if (oke)
            {
                Bll.Sua_ToKhai(ToKhaiInfo,idtokhai);
                MessageBox.Show("Đã sửa thành công tờ khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ToKhai_Load(sender, e);
            }
        }
    }
}
