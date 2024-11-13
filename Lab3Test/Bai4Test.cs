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
    public class Bai4Test
    {
        [Test]
        public void B4TruyXuat()
        {
            Bai4 t = new Bai4();
            int result = t.TruyXuat(2);
            int expected = 3;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B4TruyXuat2()
        {
            Bai4 t = new Bai4();
            Assert.Throws<IndexOutOfRangeException>(() => t.TruyXuat(16));
        }
    }
}
