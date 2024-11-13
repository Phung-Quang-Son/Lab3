using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class TinhTich
    {
        public int Tich(string a, string b)
        {
            if (int.TryParse(a, out int so1) && (int.TryParse(b, out int so2)))
            {
                return so1 * so2;
            }
            throw new ArgumentException("phai nhap 2 so nguyen");
        }
    }
}
