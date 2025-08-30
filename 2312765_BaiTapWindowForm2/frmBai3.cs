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
    public partial class frmBai3 : Form
    {
        XuLy xl = new XuLy();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnNoi_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string kq;
            xl.NoiChuoi(ho, ten, out kq);
            lblHoTen.Text = kq;
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiaiThua_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtN.Text);
                if (n < 0)
                {
                    MessageBox.Show("n phải là số nguyên dương!", "Lỗi");
                    return;
                }

                long kq = xl.GiaiThua(n);
                lblGiaiThua.Text = $"{n}! = {kq}";
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi");
            }
        }
    }
}
