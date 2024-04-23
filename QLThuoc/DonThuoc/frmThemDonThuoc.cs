using QLThuoc.DonThuoc1;
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
    public partial class frmThemDonThuoc : Form
    {
        int mIdDonThuoc;
        QLThuocEntities qldt = new QLThuocEntities();
        public frmThemDonThuoc(int IdDonThuoc = -1)
        {
            InitializeComponent();
            if(IdDonThuoc != -1)
            {
                txt_text.Text = "Sửa Đơn Thuốc";
                btn_them.Text = "Sửa";
            }
            mIdDonThuoc = IdDonThuoc;
            txt_madonthuoc.Text = mIdDonThuoc.ToString();
        }
        public void Forcus()
        {
            txt_ngaylap.Text = "";
            cb_machinhanh.SelectedIndex = -1;
            cb_makhachhang.SelectedIndex = -1;
            txt_ngaylap.Focus();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (mIdDonThuoc == -1)
            {
                ThemMoi();
            }
            else
            {
                CapNhat();
            }
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemDonThuoc_Load(object sender, EventArgs e)
        {
            //Load Nhan Vien
            cmb_nhanvien.DataSource = qldt.NhanViens.Where(x => x.DaXoa != true).Select(x => new
            {
                x.MaNV,
                x.TenNV
            }).ToList();
            cmb_nhanvien.DisplayMember = "TenNV";
            cmb_nhanvien.ValueMember = "MaNV";
            //Load chi nhanh
            cb_machinhanh.DataSource = qldt.ChiNhanhs.Where(x => x.DaXoa != true).Select(x => new
            {
                x.MaChiNhanh,
                x.TenChiNhanh
            }).ToList();
            cb_machinhanh.DisplayMember = "TenChiNhanh";
            cb_machinhanh.ValueMember = "MaChiNhanh";

            //Load Nha cung cap
            cb_makhachhang.DataSource = qldt.KhachHangs.Where(x => x.DaXoa != true).Select(x => new
            {
                x.MaKH,
                x.TenKH
            }).ToList();
            cb_makhachhang.DisplayMember = "TenKH";
            cb_makhachhang.ValueMember = "MaKH";

            ////Load Khách Hàng
            //cb_makhachhang.DataSource = qldt.DonThuocs
            //    .Where(sp => sp.MaDon == mIdDonThuoc)
            //    .Join(qldt.KhachHangs.Where(x => x.DaXoa != true),
            //        sp => sp.MaKH,
            //        kh => kh.MaKH,
            //        (sp, kh) => new
            //        {
            //            kh.MaKH,
            //            kh.TenKH
            //        })
            //    .ToList();

            //cb_makhachhang.DisplayMember = "TenKH";
            //cb_makhachhang.ValueMember = "MaKH";


            ////Load Chi Nhánh
            //cb_machinhanh.DataSource = qldt.DonThuocs
            //    .Where(sp => sp.MaDon == mIdDonThuoc)
            //    .Join(qldt.ChiNhanhs.Where(x => x.DaXoa != true),
            //        sp => sp.MaChiNhanh,
            //        ncc => ncc.MaChiNhanh,
            //        (sp, ncc) => new
            //        {
            //            ncc.MaChiNhanh,
            //            ncc.TenChiNhanh
            //        })
            //    .ToList();

            //cb_machinhanh.DisplayMember = "TenChiNhanh";
            //cb_machinhanh.ValueMember = "MaChiNhanh";


            ////Load Nhân Viên
            //cmb_nhanvien.DataSource = qldt.DonThuocs
            //    .Where(sp => sp.MaDon == mIdDonThuoc)
            //    .Join(qldt.NhanViens.Where(x => x.DaXoa != true),
            //        sp => sp.MaNV,
            //        ncc => ncc.MaNV,
            //        (sp, ncc) => new
            //        {
            //            ncc.MaNV,
            //            ncc.TenNV
            //        }).ToList();
            //cmb_nhanvien.DisplayMember = "TenNV";
            //cmb_nhanvien.ValueMember = "MaNV";

            if (mIdDonThuoc != -1)
            {
                var thuoc = qldt.DonThuocs.Where(x => x.MaDon == mIdDonThuoc && x.DaXoa != true).FirstOrDefault();
                {
                    txt_madonthuoc.Text = thuoc.MaDon.ToString();
                    txt_ngaylap.Text = thuoc.NgayLap.ToString();

                }
            }
        }

        private void btn_lamoi_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmXemCTDonThuoc frmXemCTDonThuoc = new frmXemCTDonThuoc(mIdDonThuoc);
            frmXemCTDonThuoc.ShowDialog();
        }

        public void ThemMoi()
        {
            DonThuoc donThuoc = new DonThuoc();
            donThuoc.NgayLap = DateTime.Parse(txt_ngaylap.Text);
            donThuoc.MaChiNhanh = (int?)cb_machinhanh.SelectedValue;
            donThuoc.MaKH = (int?)cb_makhachhang.SelectedValue;
            donThuoc.MaNV = (int?)cmb_nhanvien.SelectedValue;
            donThuoc.DaXoa = false;
            qldt.DonThuocs.Add(donThuoc);
            qldt.SaveChanges();
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Focus();
        }
        public void CapNhat()
        {
            var itemCanCapNhat = qldt.DonThuocs.Where(x => x.MaDon == mIdDonThuoc && x.DaXoa != true).FirstOrDefault();
            itemCanCapNhat.NgayLap = DateTime.Parse(txt_ngaylap.Text);
            itemCanCapNhat.MaChiNhanh = (int?)cb_machinhanh.SelectedValue;
            itemCanCapNhat.MaChiNhanh = (int?)cb_makhachhang.SelectedValue;
            itemCanCapNhat.MaNV = (int?)cmb_nhanvien.SelectedValue;
            qldt.SaveChanges();
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
