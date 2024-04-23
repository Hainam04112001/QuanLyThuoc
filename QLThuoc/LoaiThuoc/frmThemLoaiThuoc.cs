﻿using QLThuoc.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuoc
{
    public partial class frmThemLoaiThuoc : Form
    {
        int mIdLoaiThuoc;
        QLThuocEntities qllt = new QLThuocEntities();
        public frmThemLoaiThuoc(int IdLoaiThuoc = -1)
        {
            InitializeComponent();
            if (IdLoaiThuoc != -1)
            {
                lbl_text.Text = "Sửa Loại Thuốc";
                btn_them.Text = "Sửa";
            }
            mIdLoaiThuoc =IdLoaiThuoc;
            txt_maloaithuoc.Text = mIdLoaiThuoc.ToString();
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (mIdLoaiThuoc == -1)
            {
                if(txt_tenloaithuoc.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập vào tên loại!!");
                }
                else { ThemMoi(); }
                
            }
            else
            {
                CapNhat();
            }
        }

        public void Forcus()
        {
            txt_tenloaithuoc.Text = "";
            txt_tenloaithuoc.Focus();
        }

        private void btn_lamoi_Click(object sender, EventArgs e)
        {
            txt_tenloaithuoc.Text = "";
            txt_tenloaithuoc.Focus();
        }

        public void ThemMoi()
        {
            LoaiThuoc loaiThuoc = new LoaiThuoc();
            loaiThuoc.TenLoai = txt_tenloaithuoc.Text;
            qllt.LoaiThuocs.Add(loaiThuoc);
            qllt.SaveChanges();
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Forcus();
        }
        
        public void CapNhat()
        {
            var itemCanCapNhat = qllt.LoaiThuocs.Where(x => x.MaLoai == mIdLoaiThuoc && x.DaXoa != true).FirstOrDefault();
            itemCanCapNhat.TenLoai = txt_tenloaithuoc.Text;
            itemCanCapNhat.DaXoa = false;
            qllt.SaveChanges();
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmThemLoaiThuoc_Load(object sender, EventArgs e)
        {
            if (mIdLoaiThuoc != -1)
            {
                var loaithuoc = qllt.LoaiThuocs.Where(x => x.MaLoai == mIdLoaiThuoc && x.DaXoa != true).FirstOrDefault();
                {
                    txt_maloaithuoc.Text = loaithuoc.MaLoai.ToString();
                    txt_tenloaithuoc.Text = loaithuoc.TenLoai.ToString();
                }
            }
        }
    }
}
