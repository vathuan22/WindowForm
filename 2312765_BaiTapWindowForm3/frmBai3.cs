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
    public partial class frmBai3 : Form
    {   XuLy xl = new XuLy();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnTach1_Click(object sender, EventArgs e)
        {
            string ho, ten;
            xl.TachChuoi(txtHoTen.Text, out ho, out ten);
            txtHo.Text = ho;
            txtTen.Text = ten;
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);    

            if (xl.ThuTu(n1, n2))
                MessageBox.Show("Hai số liên tiếp!");
            else
                MessageBox.Show("Không phải hai số liên tiếp!");
        }
    }
}
