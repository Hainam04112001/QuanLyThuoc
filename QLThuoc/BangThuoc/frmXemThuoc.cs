﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuoc.Thuoc1
{
    public partial class frmXemThuoc : Form
    {
        int mIdthuoc;
        QLThuocEntities qlt = new QLThuocEntities();
        public frmXemThuoc(int IDthuoc=-1)
        {
            InitializeComponent();
            mIdthuoc = IDthuoc;
            txt_mathuoc.Text = mIdthuoc.ToString();
        }

        private void frmXemThuoc_Load(object sender, EventArgs e)
        {
            cb_tenloaithuoc.DataSource = qlt.LoaiThuocs.Where(x => x.DaXoa != true).Select(x => new
            {
                MaLoai = x.MaLoai,
                TenLoai = x.TenLoai
            }).ToList();
            cb_tenloaithuoc.DisplayMember = "TenLoai";
            cb_tenloaithuoc.ValueMember = "MaLoai";

            //Load Nha cung cap
            cb_ncc.DataSource = qlt.NhaCungCaps.Where(x => x.DaXoa != true).Select(x => new
            {
                MaNCC=  x.MaNCC,
                TenNCC= x.TenNCC
            }).ToList();
            cb_ncc.DisplayMember = "TenNCC";
            cb_ncc.ValueMember = "MaNCC";

            //Load loai thuoc
            //cb_tenloaithuoc.DataSource = qlt.Thuocs
            //    .Where(sp => sp.MaThuoc == mIdthuoc)
            //    .Join(qlt.LoaiThuocs.Where(x => x.DaXoa != true),
            //        sp => sp.MaLoai,
            //        lt => lt.MaLoai,
            //        (sp, lt) => new
            //        {
            //            lt.MaLoai,
            //            lt.TenLoai
            //        })
            //    .Distinct()
            //    .ToList();

            //cb_tenloaithuoc.DisplayMember = "TenLoai";
            //cb_tenloaithuoc.ValueMember = "MaLoai";





            //Load nhà cung cấp
            //cb_ncc.DataSource = qlt.Thuocs
            //    .Where(sp=>sp.MaThuoc == mIdthuoc)
            //    .Join(qlt.NhaCungCaps.Where(x=>x.DaXoa != true),
            //        sp => sp.MaNCC,
            //        ncc => ncc.MaNCC,
            //        (sp, ncc) => new
            //        {
            //            ncc.MaNCC,
            //            ncc.TenNCC
            //        }).Distinct().ToList();
            //cb_ncc.DisplayMember = "TenNCC";
            //cb_ncc.ValueMember = "MaNCC";


            var thongtinsp = qlt.Thuocs.Where(x => x.MaThuoc == mIdthuoc).FirstOrDefault();
            txt_mathuoc.Text = thongtinsp.MaThuoc.ToString();
            txt_tenthuoc.Text = thongtinsp.TenThuoc.ToString();
            txt_soluong.Text = thongtinsp.SoLuong.ToString();
            txt_dvt.Text = thongtinsp.DVT.ToString();
            txt_giaban.Text = thongtinsp.GiaBan.ToString();


            var mathuoc = mIdthuoc.ToString();
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(mathuoc, 50);
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void cb_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
