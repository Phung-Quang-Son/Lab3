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
    public class Bai1Test
    {
        [Test]
        public void Test1()
        {
            TinhTich tong = new TinhTich();
            int result = tong.Tich("2", "3");
            int expected = 5;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test2()
        {
            TinhTich tong = new TinhTich();
            int result = tong.Tich("2.5", "2");
            int expected = 5;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test3()
        {
            TinhTich tong = new TinhTich();
            int result = tong.Tich("0", "3");
            int expected = 0;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test4()
        {
            TinhTich tong = new TinhTich();
            int result = tong.Tich("2", "3");
            int expected = 5;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test5()
        {
            TinhTich tong = new TinhTich();
            int result = tong.Tich("10", "10");
            int expected = 100;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test6()
        {
            TinhTich tong = new TinhTich();
            int result = tong.Tich("0",int.MaxValue.ToString());
            int expected = 0;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test7()
        {
            TinhTich tong = new TinhTich();
            int result = tong.Tich(int.MinValue.ToString(), int.MaxValue.ToString());
            int expected = int.MinValue;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test8()
        {
            TinhTich tong = new TinhTich();
            int result = tong.Tich("0",int.MinValue.ToString());
            int expected = int.MinValue;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test9()
        {
            TinhTich tong = new TinhTich();
            int result = tong.Tich("-2", "3");
            int expected = -6;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test10()
        {
            TinhTich tong = new TinhTich();
            int result = tong.Tich("1", "3");
            int expected = 3;
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
