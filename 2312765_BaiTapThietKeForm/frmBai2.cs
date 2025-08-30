using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312765_BaiTapThietKeForm
{
	public partial class frmBai2 : Form
	{
		public frmBai2()
		{
			InitializeComponent();
		}

		private void btnChon_Click(object sender, EventArgs e)
		{
			var item = listBox1.SelectedItems[0];
			listBox2.Items.Add(item);

		}

		private void btnBo_Click(object sender, EventArgs e)
		{
			listBox2.Items.Remove(listBox2.SelectedItems[0]);
		}

		private void btnTinhTien_Click(object sender, EventArgs e)
		{
			int soTien = 0;
			foreach(string hang in listBox1.Items)
			{
				switch (hang)
				{
					case "Chuột":
						soTien += 100000;
						break;
					case "Bàn phím":
						soTien += 150000;
						break;
					case "Máy in":
						soTien += 2000000;
						break;
					case "USB Kingmax":
						soTien += 200000;
						break;
						default: break;
				}
				lblTongTien.Text = soTien + "đồng";
			}
		}
	}
}
