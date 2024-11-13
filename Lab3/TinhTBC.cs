using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class TinhTBC
    {
        public double CalculateAverage(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArithmeticException("Cannot calculate average of an empty list.");
            }

            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return (double)sum / numbers.Count;
        }
    }
}
