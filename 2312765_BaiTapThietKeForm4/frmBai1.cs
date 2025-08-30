using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312765_BaiTapThietKeForm4
{
    public partial class frmBai1 : Form
    {
        SanPham sp = new SanPham();
        public frmBai1()
        {
            InitializeComponent();
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            // Gán giá trị từ form vào đối tượng
            sp.MaSanPham = txtMaSP.Text;
            sp.TenSanPham = txtTenSP.Text;
            sp.LoaiSanPham = txtLoaiSP.Text;
            sp.NgaySanXuat = dtpNgaySX.Value;

            // Hiển thị kết quả
            txtKetQua.Text = sp.HienThi();
        }
    }
}
