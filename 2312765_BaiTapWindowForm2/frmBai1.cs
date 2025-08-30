using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312765_BaiTapWindowForm2
{
	public partial class frmBai1 : Form
	{
		public frmBai1()
		{
			InitializeComponent();
		}

		private void txtTT_Click(object sender, EventArgs e)
		{

		}

        private void frmBai1_Load(object sender, EventArgs e)
        {
			ThietBi tb = new ThietBi();
			tb.MaThietBi = "M001";
			tb.TenThietBi = "CPU";
			tb.NuocSanXuat = "Mỹ";
			tb.DonGia = 2000000;
			tb.SoLuong = 2;
			txtTT.Text = tb.HienThi();
        }
    }
}
