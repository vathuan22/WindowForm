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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtA.Text);
                double so2 = double.Parse(txtB.Text);
                double kq = 0;

                if (rdCong.Checked)
                {
                    kq = so1 + so2;
                }
                else if (rdTru.Checked)
                {
                    kq = so1 - so2;
                }
                else if (rdNhan.Checked)
                {
                    kq = so1 * so2;
                }
                else if (rdChia.Checked)
                {
                    if (so2 != 0)
                        kq = so1 / so2;
                    else
                    {
                        MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                lblKQ.Text = "Kết quả là: " + kq.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
    }
}
