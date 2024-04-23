using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.ViewModel
{
    public class ThongKeTheoLoaiThuocGridView
    {
        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string DVT { get; set; }

        public string TenLoai { get; set; }

        public int MaLoai { get; set; }
        //Lấy tên nhà cung
        public Nullable<decimal> GiaBan { get; set; }
    }
}
