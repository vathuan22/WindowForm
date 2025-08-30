using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312765_BaiTapWindowForm3
{
    
    public partial class frmBai1 : Form
    {
        NhanVien nv = new NhanVien();
        public frmBai1()
        {
            InitializeComponent();
        }
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            try
            {
                nv.MaNV = txtMaNV.Text;
                nv.HoTen = txtHoTen.Text;
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.HeSoLuong = double.Parse(txtHeSoLuong.Text);
                nv.HeSoPhuCap = double.Parse(txtLuongCoBan.Text);

                double luong = nv.TongLuong();
                MessageBox.Show("Lương của nhân viên: " + luong.ToString("N0"));    
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ!");
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nv.HienThi());
        }
    }
}
