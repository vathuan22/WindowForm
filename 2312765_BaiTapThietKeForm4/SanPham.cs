using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312765_BaiTapThietKeForm4
{
    internal class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public DateTime NgaySanXuat { get; set; }

        
        public SanPham() { }

     
        public int NamHetHan()
        {
            return NgaySanXuat.Year + 3;
        }

        // Phương thức hiển thị thông tin
        public string HienThi()
        {
            return $"Mã SP: {MaSanPham}\n" +
                   $"Tên SP: {TenSanPham}\n" +
                   $"Loại SP: {LoaiSanPham}\n" +
                   $"Ngày sản xuất: {NgaySanXuat.ToShortDateString()}\n" +
                   $"Năm hết hạn: {NamHetHan()}";
        }
    }
}
