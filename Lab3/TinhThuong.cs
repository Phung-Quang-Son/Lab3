using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class TinhThuong
    {
        public float Chia2So(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            throw new ArgumentException("b phai khac 0");
        }
    }
}
