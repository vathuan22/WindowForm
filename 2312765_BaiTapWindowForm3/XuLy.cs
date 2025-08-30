using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312765_BaiTapWindowForm3
{
    internal class XuLy
    {
        // Bài 2

        public int Tong(int n)
        {
            int kq = 0;
            for(int i = 0; i < n; i++)
            {
                kq += i;
            }
            return kq;
        }
        public long GiaiThua(int n)
        {
            long kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq *= i;
            }
            return kq;
        }
        // Bài 3
        public void TachChuoi(string hoten, out string s1, out string s2)
        {
            string[] parts = hoten.Trim().Split(' ');
            s1 = parts[0]; // họ
            s2 = parts[parts.Length - 1]; // tên
        }

        
        public bool ThuTu(int n1, int n2)
        {
            return n2 == n1 + 1;
        }
    }
}
