using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.ViewModel
{
    public class ThuocGridView
    {
        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string DVT { get; set; }

        public string TenLoai { get; set; }

        //Lấy tên nhà cung
        public string NhaCC { get; set; }
        public Nullable<decimal> GiaBan { get; set; }
    }
}
