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
	public partial class frmBai3 : Form
	{
		public frmBai3()
		{
			InitializeComponent();
		}

		private void btnTinh_Click(object sender, EventArgs e)
		{
			int a = int.Parse(txtA.Text);
			int b=int.Parse(txtB.Text);
			int n = int.Parse(txtN.Text);
			int kq = 0;
			if(rdTong2So.Checked)
			{
				 TinhToan.CongHaiSo(a,b,ref kq);
			}
			else
			{
				kq = TinhToan.TongDaySo(n);
			}
			lblKQ.Text = kq.ToString();
		}
	}
}
