using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuoc.ChiNhanh1
{
    public partial class frmXemChiNhanh : Form
    {
        int mIdChiNhanh;
        QLThuocEntities qlcn = new QLThuocEntities();
        public frmXemChiNhanh(int IDChiNhanh = -1)
        {
            InitializeComponent();
            mIdChiNhanh=IDChiNhanh;
            txt_machinhanh.Text = mIdChiNhanh.ToString();
        }

        private void frmXemChiNhanh_Load(object sender, EventArgs e)
        {
            var thongTinChiNhanh = qlcn.ChiNhanhs.Where(x => x.MaChiNhanh == mIdChiNhanh).FirstOrDefault();
            txt_machinhanh.Text = thongTinChiNhanh.MaChiNhanh.ToString();
            txt_tenchinhanh.Text = thongTinChiNhanh.TenChiNhanh.ToString();
            txt_diachi.Text = thongTinChiNhanh.DiaChi.ToString();
            txt_sdt.Text = thongTinChiNhanh.SoDienThoai.ToString();

            var chinhanh = mIdChiNhanh.ToString();
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(chinhanh, 50);
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Jpeg image | *.jpg";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                string path1 = saveFileDialog1.FileName;
                pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Luu thanh cong");
            }
        }
    }
}
