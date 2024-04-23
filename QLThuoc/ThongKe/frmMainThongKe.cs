using QLThuoc.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuoc.ThongKe
{
    public partial class frmMainThongKe : Form
    {

        List<ThongKeTheoNCCGridView> thuocGridViews = new List<ThongKeTheoNCCGridView>();
        private List<ThongKeTheoLoaiThuocGridView> thuocGridViews1 = new List<ThongKeTheoLoaiThuocGridView>();
        public frmMainThongKe()
        {
            InitializeComponent();
        }

        private void cmb_tk_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị của ComboBox đã chọn
            string selectedValue = cmb_tk.SelectedItem?.ToString();

            // Kiểm tra xem giá trị đã chọn có tồn tại không
            if (!string.IsNullOrEmpty(selectedValue))
            {
                // Tùy thuộc vào giá trị đã chọn, mở form thống kê tương ứng
                if (selectedValue.Equals("Theo Loại"))
                {
                    // Gọi form thống kê theo loại
                    frmThongKeTheoLoaiThuoc frmThongKeTheoLoaiThuoc = new frmThongKeTheoLoaiThuoc(thuocGridViews1);
                    frmThongKeTheoLoaiThuoc.ShowDialog();
                }
                else if (selectedValue.Equals("Theo Nhà Cung Cấp"))
                {
                    // Gọi form thống kê theo nhà cung cấp
                    ThongKeThuoc thongKeThuoc = new ThongKeThuoc(thuocGridViews);
                    thongKeThuoc.ShowDialog();
                }
            }
        }
    }
}
