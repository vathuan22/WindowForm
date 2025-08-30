using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312765_BaiTapWindowForm3
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public double HeSoLuong { get; set; }
        public double HeSoPhuCap { get; set; }

        // Hàm khởi tạo có tham số
        public NhanVien() { }
        public NhanVien(string ma, string ten, DateTime ns, double hsl, double hspc)
        {
            MaNV = ma;
            HoTen = ten;
            NgaySinh = ns;
            HeSoLuong = hsl;
            HeSoPhuCap = hspc;
        }

        // Phương thức tính tổng lương
        public double TongLuong()
        {
            return (HeSoLuong + HeSoPhuCap) * 1150000;
        }

        // Phương thức hiển thị thông tin
        public string HienThi()
        {
            return $"Mã NV: {MaNV}, Họ tên: {HoTen}, Ngày sinh: {NgaySinh.ToShortDateString()}, " +
                   $"Hệ số lương: {HeSoLuong}, Hệ số phụ cấp: {HeSoPhuCap}, " +
                   $"Tổng lương: {TongLuong():N0} VNĐ";
        }


    }
}
