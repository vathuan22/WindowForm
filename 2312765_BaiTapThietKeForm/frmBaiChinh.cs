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
	public partial class frmBaiChinh : Form
	{
		public frmBaiChinh()
		{
			InitializeComponent();
		}

		private void tsmBai1_Click(object sender, EventArgs e)
		{
			FrmBai1 frmBai1 = new FrmBai1();
			frmBai1.ShowDialog();
		}

		private void tsmBai2_Click(object sender, EventArgs e)
		{
			frmBai2 frmBai2 = new frmBai2();
			frmBai2.ShowDialog();
		}

		private void tsmBai3_Click(object sender, EventArgs e)
		{
			frmBai3 frmBai3 = new frmBai3();
			frmBai3.ShowDialog();
		}

		private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmBai4 frmBai4 = new frmBai4();
			frmBai4.ShowDialog();
		}
	}
}
