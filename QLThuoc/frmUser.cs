using Guna.UI2.WinForms;
using QLThuoc.NhanVien1;
using QLThuoc.TaiKhoan;
using QLThuoc.ThongKe;
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
    public partial class frmUser : Form
    {
        string chucvuhientai = "";
        public frmUser(string chucvu)
        {
            InitializeComponent();
            this.chucvuhientai = chucvu;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.panel_content.Controls.Clear();
            frmThuoc frmThuoc = new frmThuoc();
            frmThuoc.TopLevel = false;
            frmThuoc.Dock = DockStyle.Fill;
            frmThuoc.AutoScroll = true;
            this.panel_content.Controls.Add(frmThuoc);
            frmThuoc.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.panel_content.Controls.Clear();
            frmLoaiThuoc frmLoaiThuoc = new frmLoaiThuoc();
            frmLoaiThuoc.TopLevel = false;
            frmLoaiThuoc.Dock= DockStyle.Fill;
            frmLoaiThuoc.AutoScroll= true;
            this.panel_content.Controls.Add(frmLoaiThuoc);
            frmLoaiThuoc .Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.panel_content.Controls.Clear();
            frmNhaCungCap frmNhaCungCap = new frmNhaCungCap();
            frmNhaCungCap.TopLevel = false;
            frmNhaCungCap.Dock = DockStyle.Fill;
            frmNhaCungCap.AutoScroll= true;
            this.panel_content.Controls.Add (frmNhaCungCap);
            frmNhaCungCap .Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.panel_content.Controls.Clear();
            frmDonThuoc frmDonThuoc = new frmDonThuoc();
            frmDonThuoc.TopLevel = false;
            frmDonThuoc.Dock = DockStyle.Fill;
            frmDonThuoc.AutoScroll= true;
            this.panel_content.Controls.Add(frmDonThuoc); 
            frmDonThuoc .Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.panel_content.Controls.Clear();
            frmKhachHang frmKhachHang = new frmKhachHang();
            frmKhachHang.TopLevel = false;
            frmKhachHang.Dock = DockStyle.Fill;
            frmKhachHang.AutoScroll= true;
            this.panel_content.Controls.Add(frmKhachHang);
            frmKhachHang .Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.panel_content.Controls.Clear();
            frmChiNhanh frmChiNhanh = new frmChiNhanh();
            frmChiNhanh.TopLevel = false;
            frmChiNhanh.Dock = DockStyle.Fill;
            frmChiNhanh.AutoScroll= true;
            this.panel_content.Controls.Add(frmChiNhanh);
            frmChiNhanh .Show();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            checkquyen();
        }
        public void checkquyen()
        {
            if (this.chucvuhientai != "Quan Ly")
            {
                btn_nhanvien.Visible = false;
                guna2Button3.Visible = true;//Thuoc
                guna2Button6.Visible = false;//Loai Thuoc
                guna2Button4.Visible = false;//Nha Cung Cap
                guna2Button2.Visible = false;//Chi Nhanh
                btn_nhanvien.Visible = false;
                btn_TaiKhoan.Visible = false;
            }
            else
            {
                btn_nhanvien.Visible = true;
                guna2Button6.Visible = true;
            }
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            this.panel_content.Controls.Clear();
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.TopLevel = false;
            frmNhanVien.Dock = DockStyle.Fill;
            frmNhanVien.AutoScroll = true;
            this.panel_content.Controls.Add(frmNhanVien);
            frmNhanVien .Show();
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            this.panel_content.Controls.Clear();
            frmTaiKhoan frmTaiKhoan = new frmTaiKhoan();
            frmTaiKhoan.TopLevel = false;
            frmTaiKhoan.Dock = DockStyle.Fill;
            frmTaiKhoan.AutoScroll = true;
            this.panel_content.Controls.Add(frmTaiKhoan);
            frmTaiKhoan.Show();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            this.panel_content.Controls.Clear();
            frmMainThongKe frmMainThongKe = new frmMainThongKe();
            frmMainThongKe.TopLevel = false;
            frmMainThongKe.Dock = DockStyle.Fill;
            frmMainThongKe.AutoScroll = true;
            this.panel_content.Controls.Add(frmMainThongKe);
            frmMainThongKe.Show();
        }
    }
}
