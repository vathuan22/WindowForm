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
    
    public partial class frmBai3 : Form
        
    {
        XuLy xl = new XuLy();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnTB_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text;
            bool gt = rdNam.Checked;
            xl.ChaoHoi(hoten, gt);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
           
            try
            {
                int m = int.Parse(txtM.Text);
                int n = int.Parse(txtN.Text);
                int kq=  xl.USCLN(m,n);

                txtKQ.Text = kq.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng số nguyên!", "Lỗi");
            }
        }
    }
}
