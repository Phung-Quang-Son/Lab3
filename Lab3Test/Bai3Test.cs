using Lab3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Test
{
    [TestFixture]
    public class Bai3Test

    {
        [Test]
        public void test1()
        {
            TinhTBC TBC = new TinhTBC();
            List<int> emptyList = new List<int>();

            Assert.Throws<ArithmeticException>(() => TBC.CalculateAverage(emptyList));
        }
    }
}
