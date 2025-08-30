using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312765_BaiTapWindowForm2
{
	internal class ThietBi
	{
		public string MaThietBi {  get; set; }	
		public string TenThietBi { get; set; }
		public string NuocSanXuat {  get; set; }
		public int DonGia {  get; set; }
		public int SoLuong {  get; set; }
		public ThietBi() { }
		public ThietBi(string maTB,string tenTB,string nuocSX,int donGia,int soLuong)
		{
			this.MaThietBi = maTB;
			this.TenThietBi = tenTB;
			this.NuocSanXuat = nuocSX;
			this.DonGia = donGia;
			this.SoLuong = soLuong;

		}
		public int ThanhTien()
		{
			int kq = DonGia * SoLuong;
			return kq;
		}
        public string HienThi()
        {
            return $"Mã: {MaThietBi}, Tên: {TenThietBi}, Nước SX: {NuocSanXuat}, " +
                   $"Đơn giá: {DonGia}, Số lượng: {SoLuong}, Thành tiền: {ThanhTien()}";
        }
    }
}
