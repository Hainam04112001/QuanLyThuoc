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
    public partial class frmThemNhaCC : Form
    {
        int mIdNCC;
        QLThuocEntities qlncc = new QLThuocEntities();  
        public frmThemNhaCC(int IdNCC=-1)
        {
            InitializeComponent();
            if(IdNCC != -1)
            {
                lbl_text.Text = "Sửa Nhà Cung Cấp";
                btn_them.Text = "Sửa";
            }
            mIdNCC = IdNCC;
            txt_mancc.Text = mIdNCC.ToString();
        }
        public void Forcus()
        {
            txt_mancc.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            txt_tenncc.Text = "";
            txt_tenncc.Focus();
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string text = "null";
            if (mIdNCC == -1)
            {
                if (txt_tenncc.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập vào tên nhà cung câp!!");
                    txt_tenncc.Focus();
                }
                else if (txt_diachi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập vào tên nhà cung câp!!");
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

        private void btn_lamoi_Click(object sender, EventArgs e)
        {
            Forcus();
        }

        public void ThemMoi()
        {
            NhaCungCap nhaCungCap = new NhaCungCap();
            nhaCungCap.TenNCC = txt_tenncc.Text;
            nhaCungCap.DiaChi = txt_diachi.Text;
            nhaCungCap.SDT = txt_sdt.Text;
            qlncc.NhaCungCaps.Add(nhaCungCap);
            qlncc.SaveChanges();
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Forcus();
        }
        public void CapNhat()
        {
            var itemCanCapNhat = qlncc.NhaCungCaps.Where(x => x.MaNCC == mIdNCC && x.DaXoa != true).FirstOrDefault();
            itemCanCapNhat.TenNCC = txt_tenncc.Text;
            itemCanCapNhat.DiaChi = txt_diachi.Text;
            itemCanCapNhat.SDT = txt_sdt.Text;
            itemCanCapNhat.DaXoa = false;
            qlncc.SaveChanges();
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmThemNhaCC_Load(object sender, EventArgs e)
        {
            if (mIdNCC != -1)
            {
                var thuoc = qlncc.NhaCungCaps.Where(x => x.MaNCC == mIdNCC && x.DaXoa != true).FirstOrDefault();
                {
                    txt_mancc.Text = thuoc.MaNCC.ToString();
                    txt_tenncc.Text = thuoc.TenNCC.ToString();
                    txt_sdt.Text = thuoc.SDT.ToString();
                    txt_diachi.Text = thuoc.DiaChi.ToString();
                }
            }
        }
    }
}
