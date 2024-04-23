using CsvHelper.Configuration;
using CsvHelper;
using QLThuoc.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuoc.ThongKe
{
    public partial class ThongKeThuoc : Form
    {
        QLThuocEntities qlt = new QLThuocEntities();
        List<ThongKeTheoNCCGridView> thuocGridViews = new List<ThongKeTheoNCCGridView>();
        List<ThongKeTheoNCCGridView> fiterthuocGridViews = new List<ThongKeTheoNCCGridView>();
        public ThongKeThuoc(List<ThongKeTheoNCCGridView> thuocGridViews)
        {
            InitializeComponent();
        }

        private void ThongKeThuoc_Load(object sender, EventArgs e)
        {
            var nhaCCList = qlt.NhaCungCaps.ToList();

            // Đổ dữ liệu vào ComboBox
            cmb_ThongKe.DataSource = nhaCCList;
            cmb_ThongKe.DisplayMember = "TenNCC"; // Thay "TenNCC" bằng tên trường bạn muốn hiển thị
            cmb_ThongKe.ValueMember = "MaNCC"; // Thay "MaNCC" bằng tên trường ID của nhà cung cấp

            // Load dữ liệu cho DataGridView
            LoadData();
        }



        private void cmb_ThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi người dùng chọn một nhà cung cấp, thực hiện thống kê
            if (cmb_ThongKe.SelectedItem != null)
            {
                NhaCungCap selectedNhaCC = (NhaCungCap)cmb_ThongKe.SelectedItem;
                int selectedNhaCCId = selectedNhaCC.MaNCC;

                // Lọc danh sách sản phẩm theo nhà cung cấp đã chọn
                fiterthuocGridViews = thuocGridViews.Where(x => x.MaNhaCC == selectedNhaCCId).ToList();

                // Hiển thị kết quả lên DataGridView
                dgv_ThongKe.DataSource = fiterthuocGridViews;
            }
        }


        private void LoadData()
        {
            thuocGridViews = qlt.Thuocs.Select(x => new ThongKeTheoNCCGridView
            {
                MaThuoc = x.MaThuoc,
                TenThuoc = x.TenThuoc,
                DVT = x.DVT,
                TenLoai = x.LoaiThuoc.TenLoai,
                MaNhaCC = x.NhaCungCap.MaNCC, // Thêm MaNCC vào ThongKeTheoNCCGridView để có thể lọc theo nhà cung cấp
                GiaBan = x.GiaBan
            }).ToList();

            // Đặt filteredThuocGridViews bằng thuocGridViews ban đầu
            fiterthuocGridViews = thuocGridViews;

            // Hiển thị dữ liệu trên DataGridView
            dgv_ThongKe.DataSource = fiterthuocGridViews;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ExportCSV();
        }
        public void ExportCSV()//them nay
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Export CSV";
            saveFileDialog1.Filter = "CSV|*.csv";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
                {
                    HasHeaderRecord = true,
                    Delimiter = ",",
                    Encoding = Encoding.UTF8,
                };
                string mpath = saveFileDialog1.FileName;
                using (var write = new StreamWriter(mpath, false, new UTF8Encoding(true)))
                using (var csvWriter = new CsvWriter(write, csvConfig))
                {
                    csvWriter.WriteRecords(fiterthuocGridViews);
                }
            }
            MessageBox.Show("Xuất Data Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
