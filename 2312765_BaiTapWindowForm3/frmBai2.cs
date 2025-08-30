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
    public partial class frmBai2 : Form
    {
        XuLy xl = new XuLy();
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtN.Text);
                int kq;
                if (n < 0)
                {
                    MessageBox.Show("n phải là số nguyên dương!", "Lỗi");
                    return;
                }
                else if (rdTong.Checked)
                {
                    kq= xl.Tong(n);
                    lblKQ.Text = "Kết quả: " + kq.ToString();
                }
                else
                {
                   long kQ= xl.GiaiThua(n);
                    lblKQ.Text = "Kết quả: " + kQ.ToString();
                }
                
                
            }
            catch (Exception){
                MessageBox.Show("Vui lòng nhập đúng số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
