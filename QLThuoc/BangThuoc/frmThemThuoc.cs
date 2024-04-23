using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuoc
{
    public partial class frmThemThuoc : Form
    {
        int mIdThuoc;
        QLThuocEntities qlt = new QLThuocEntities();    

        public frmThemThuoc(int Idthuoc =-1)
        {
            InitializeComponent();
            if(Idthuoc != -1)
            {
                lbl_text.Text = "Sửa sản phẩm";
                btn_them.Text = "Sửa";
            }
            mIdThuoc = Idthuoc;
            txt_mathuoc.Text = mIdThuoc.ToString();
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(mIdThuoc == -1)
            {
                if (txt_tenthuoc.Text == "")
                {
                    MessageBox.Show("Vui long khong bo trong du lieu");
                    txt_tenthuoc.Focus();
                }else if (txt_dvt.Text == "")
                {
                    MessageBox.Show("Vui long khong bo trong du lieu");
                    txt_dvt.Focus();
                }
                else if (txt_giaban.Text == "")
                {
                    MessageBox.Show("Vui long khong bo trong du lieu");
                    txt_giaban.Focus();
                }
                else if (txt_soluong.Text == "")
                {
                    MessageBox.Show("Vui long khong bo trong du lieu");
                    txt_soluong.Focus();
                }
                else if (IsNumber(txt_giaban.Text) != true )
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ, không được nhập ký tự", "Thông báo");
                    txt_giaban.Text = "";
                    
                }
                else if (IsNumber(txt_soluong.Text) != true)
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ, không được nhập ký tự", "Thông báo");
                    
                    txt_soluong.Text = "";
                }
                else { Themmoi(); }
               
            }
            else
            {
                CapNhat();
            }
        }
        public static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }

        private void frmThemThuoc_Load(object sender, EventArgs e)
        {
            //Load danh muc loai thuoc
            cb_tenloaithuoc.DataSource = qlt.LoaiThuocs.Where(x => x.DaXoa != true).Select(x => new
            {
                x.MaLoai,
                x.TenLoai
            }).ToList();
            cb_tenloaithuoc.DisplayMember = "TenLoai";
            cb_tenloaithuoc.ValueMember = "MaLoai";

            //Load Nha cung cap
            cb_ncc.DataSource = qlt.NhaCungCaps.Where(x => x.DaXoa != true).Select(x => new
            {
                x.MaNCC,
                x.TenNCC
            }).ToList();
            cb_ncc.DisplayMember = "TenNCC";
            cb_ncc.ValueMember = "MaNCC";

            ////Load loai thuoc
            //cb_tenloaithuoc.DataSource = qlt.Thuocs
            //    .Where(sp => sp.MaThuoc == mIdThuoc)
            //    .Join(qlt.LoaiThuocs.Where(x => x.DaXoa != true),
            //        sp => sp.MaLoai,
            //        lt => lt.MaLoai,
            //        (sp, lt) => new
            //        {
            //            lt.MaLoai,
            //            lt.TenLoai
            //        })
            //    .ToList();

            //cb_tenloaithuoc.DisplayMember = "TenLoai";
            //cb_tenloaithuoc.ValueMember = "MaLoai";





            ////Load nhà cung cấp
            //cb_ncc.DataSource = qlt.Thuocs
            //    .Where(sp => sp.MaThuoc == mIdThuoc)
            //    .Join(qlt.NhaCungCaps.Where(x => x.DaXoa != true),
            //        sp => sp.MaNCC,
            //        ncc => ncc.MaNCC,
            //        (sp, ncc) => new
            //        {
            //            ncc.MaNCC,
            //            ncc.TenNCC
            //        }).ToList();
            //cb_ncc.DisplayMember = "TenNCC";
            //cb_ncc.ValueMember = "MaNCC";

            if (mIdThuoc != -1)
            {
                var thuoc = qlt.Thuocs.Where(x => x.MaThuoc == mIdThuoc && x.DaXoa != true).FirstOrDefault();
                {

                    txt_mathuoc.Text = thuoc.MaThuoc.ToString();
                    txt_tenthuoc.Text = thuoc.TenThuoc.ToString();
                    txt_soluong.Text = thuoc.SoLuong.ToString();
                    txt_dvt.Text = thuoc.DVT.ToString();
                    txt_giaban.Text = thuoc.GiaBan.ToString();
                }
            }

        }
        public void Forcus()
        {
            txt_tenthuoc.Text = "";
            txt_soluong.Text = "";
            txt_giaban.Text = "";
            txt_dvt.Text = "";
            txt_tenthuoc.Focus();
        }

        public void Themmoi()
        {
            Thuoc thuoc = new Thuoc();
            thuoc.TenThuoc = txt_tenthuoc.Text;
            thuoc.SoLuong = int.Parse(txt_soluong.Text);
            thuoc.GiaBan = int.Parse(txt_giaban.Text);
            thuoc.DVT = txt_dvt.Text;
            thuoc.MaLoai = (int?)cb_ncc.SelectedValue;
            thuoc.MaNCC = (int?)cb_tenloaithuoc.SelectedValue;
            thuoc.DaXoa = false;
            qlt.Thuocs.Add(thuoc);
            qlt.SaveChanges();
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Focus();
        }

        public void CapNhat()
        {
            var itemCanCapNhat = qlt.Thuocs.Where(x => x.MaThuoc == mIdThuoc && x.DaXoa != true).FirstOrDefault();
            itemCanCapNhat.TenThuoc = txt_tenthuoc.Text;
            itemCanCapNhat.SoLuong = int.Parse(txt_soluong.Text);
            itemCanCapNhat.GiaBan = int.Parse(txt_giaban.Text);
            itemCanCapNhat.DVT = txt_dvt.Text;


            itemCanCapNhat.MaLoai = (int?)cb_tenloaithuoc.SelectedValue;
            itemCanCapNhat.MaNCC = (int?)cb_ncc.SelectedValue;
            itemCanCapNhat.DaXoa = false;
            qlt.SaveChanges();
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_lamoi_Click(object sender, EventArgs e)
        {
            Focus();
        }
    }
}
