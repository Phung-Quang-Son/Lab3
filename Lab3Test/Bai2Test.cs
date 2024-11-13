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
    public class Bai2Test
    {
        [Test]
        public void test1()
        {
            TinhThuong tinh = new TinhThuong();
            float result = tinh.Chia2So(4, 2);
            float expected = 2;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void test2()
        {
            TinhThuong tinh = new TinhThuong();
            float result = tinh.Chia2So(0, 2);
            float expected = 0;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void test3()
        {
            TinhThuong tinh = new TinhThuong();
            float result = tinh.Chia2So(10, 2);
            float expected = 5;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void test4()
        {
            TinhThuong tinh = new TinhThuong();
            float result = tinh.Chia2So(int.MaxValue , int.MinValue);
            float expected = -1;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void test5()
        {
            TinhThuong tinh = new TinhThuong();
            float result = tinh.Chia2So(0, int.MaxValue);
            float expected = 0;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void test6()
        {
            TinhThuong tinh = new TinhThuong();
            float result = tinh.Chia2So(4, 2);
            float expected = 2;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void test7()
        {
            TinhThuong tinh = new TinhThuong();
            Assert.Throws<ArgumentException>(() => tinh.Chia2So(4, 0));
        }
        [Test]
        public void test8()
        {
            TinhThuong tinh = new TinhThuong();
            float result = tinh.Chia2So(100, 10);
            float expected = 10;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void test9()
        {
            TinhThuong tinh = new TinhThuong();
            float result = tinh.Chia2So(0, int.MinValue);
            float expected = 0;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void test10()
        {
            TinhThuong tinh = new TinhThuong();
            float result = tinh.Chia2So(4, 4);
            float expected = 1;
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
