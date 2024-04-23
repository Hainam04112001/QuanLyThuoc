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

namespace QLThuoc.NhaCungCap1
{
    public partial class frmXemNhaCungCap : Form
    {
        int mIdNCC;
        QLThuocEntities qlNCC = new QLThuocEntities();
        public frmXemNhaCungCap(int IdNCC)
        {
            InitializeComponent();
            mIdNCC = IdNCC;
            txt_mancc.Text = mIdNCC.ToString();
        }

        private void frmXemNhaCungCap_Load(object sender, EventArgs e)
        {
            var thongTinNCC = qlNCC.NhaCungCaps.Where(x => x.MaNCC == mIdNCC).FirstOrDefault();
            txt_mancc.Text = thongTinNCC.MaNCC.ToString();
            txt_tenncc.Text = thongTinNCC.TenNCC.ToString();
            txt_diachi.Text = thongTinNCC.DiaChi.ToString();
            txt_sdt.Text = thongTinNCC.SDT.ToString();

            var nhaCC = mIdNCC.ToString();
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(nhaCC, 50);
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

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
