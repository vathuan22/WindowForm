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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXep_Click(object sender, EventArgs e)
        {
            try
            {
                double diemLT = double.Parse(txtLT.Text);
                double diemTH = double.Parse(txtTH.Text);
                if(diemLT < 0 || diemLT > 10 || diemTH < 0 || diemTH > 10)
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string xepLoai;
                double diemTB = (diemLT + diemTH) / 2;

                // Xếp loại theo yêu cầu
                if (diemLT < 5 || diemTH < 5)
                {
                    xepLoai = "Yếu";
                }
                else if (diemTB < 7)
                {
                    xepLoai = "Trung bình";
                }
                else if (diemTB < 8)
                {
                    xepLoai = "Khá";
                }
                else if (diemTB < 9)
                {
                    xepLoai = "Giỏi";
                }
                else
                {
                    xepLoai = "Xuất sắc";
                }
                lblKQ.Text = xepLoai;

            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
