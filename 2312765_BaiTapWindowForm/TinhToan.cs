﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312765_BaiTapWindowForm
{
	internal class TinhToan
	{
		public static void CongHaiSo(int a,int b,ref int s)
		{
			s = a + b;
		}
		public static int TongDaySo(int n)
		{
			int sum = 0;
			for(int i = 1;i<n;i++)
			{
				sum += i;
			}
			return sum;
		}
	}
}
