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
    public partial class frmThemKhachHang : Form
    {
        int mIdKH;
        QLThuocEntities qlkh = new QLThuocEntities();

        public frmThemKhachHang(int IdKH =-1)
        {
            InitializeComponent();
            if(IdKH != -1)
            {
                lbl_text.Text = "Sửa Khách Hàng";
                btn_them.Text = "Sửa";
            }
            mIdKH = IdKH;
            txt_makh.Text = mIdKH.ToString();
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lamoi_Click(object sender, EventArgs e)
        {
            forcus();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (mIdKH == -1)
            {
                if (txt_tenkh.Text == "")
                {
                    MessageBox.Show("Vui long khong bo trong du lieu");
                    txt_tenkh.Focus();
                }
                else if (txt_diachi.Text == "")
                {
                    MessageBox.Show("Vui long khong bo trong du lieu");
                    txt_diachi.Focus();
                }
                else if (txt_sdt.Text == "")
                {
                    MessageBox.Show("Vui long khong bo trong du lieu");
                    txt_sdt.Focus();
                }
                else { ThemMoi(); }
                
            }
            else
            {
                CapNhat();
            }
        }
        public void forcus()
        {
            txt_tenkh.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            txt_tenkh.Focus();
        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            if (mIdKH != -1)
            {
                var khachhang = qlkh.KhachHangs.Where(x => x.MaKH == mIdKH && x.DaXoa != true).FirstOrDefault();
                {
                    txt_makh.Text = khachhang.MaKH.ToString();
                    txt_tenkh.Text = khachhang.TenKH.ToString();
                    txt_diachi.Text = khachhang.DiaChi.ToString();
                    txt_sdt.Text = khachhang.SDT.ToString();
                }
            }
        }
        public void ThemMoi()
        {
            KhachHang khachHang = new KhachHang();
            khachHang.TenKH = txt_tenkh.Text;
            khachHang.DiaChi = txt_diachi.Text;
            khachHang.SDT = txt_sdt.Text;
            qlkh.KhachHangs.Add(khachHang);
            qlkh.SaveChanges();
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            forcus();
        }
        public void CapNhat()
        {
            var itemCanCapNhat = qlkh.KhachHangs.Where(x => x.MaKH == mIdKH && x.DaXoa != true).FirstOrDefault();
            itemCanCapNhat.TenKH = txt_tenkh.Text;
            itemCanCapNhat.SDT = txt_sdt.Text;
            itemCanCapNhat.DiaChi = txt_diachi.Text;
            itemCanCapNhat.DaXoa = false;
            qlkh.SaveChanges();
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
