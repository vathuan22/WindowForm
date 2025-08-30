using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312765_BaiTapWindowForm
{
	public partial class frmBai1 : Form
	{
		public frmBai1()
		{
			InitializeComponent();
		}

		private void frmBai1_Load(object sender, EventArgs e)
		{
			HangHoa hh = new HangHoa();
			hh.MaHang = "M001";
			hh.TenHang = "PC";
			hh.DVT = "Bộ";
			hh.SoLuong = 1;
			hh.DonGia = 10000000;

			lblTT.Text = hh.HienThi();

		}
	}
}
