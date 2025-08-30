using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312765_BaiTapThietKeForm4
{
    internal class XuLy
    {
        public void ChaoHoi(string hoten, bool gioitinh)
        {
            if (gioitinh) // True = Nam
                MessageBox.Show("Chào Ông " + hoten, "Thông báo");
            else
                MessageBox.Show("Chào Bà " + hoten, "Thông báo");
        }

        
        public int USCLN(int m, int n)
        {
            while (m != n)
            {
                if (m > n)
                    m -= n;
                else
                    n -= m;
            }
            return m;
        }
    }
}
