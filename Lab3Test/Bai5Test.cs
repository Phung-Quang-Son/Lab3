using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab3.Bai5;

namespace Lab3Test
{
    [TestFixture]
    public class Bai5Test
    {
        [Test]
        public void LayTen()
        {
            UserService service = new UserService();

            Assert.Throws<NullReferenceException>(() => service.GetName(null));
        }

        [Test]
        public void LayTen1()
        {
            UserService service = new UserService();
            UserProfile profile = new UserProfile { Name = "Son" };

            string result = service.GetName(profile);

            Assert.That(result, Is.EqualTo("Son"));
        }
    }
}
