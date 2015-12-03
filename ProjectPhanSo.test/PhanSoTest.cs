using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPhanSo;
using NUnit.Framework;

namespace ProjectPhanSo.test
{
    [TestFixture]
    public class PhanSoTest
    {
        [Test]
        public void TestHamDungMacDinh()
        {
            PhanSo p;
            p = new PhanSo();
            Assert.AreEqual(0, p.Tu, "Loi o tu so");
            Assert.AreEqual(1, p.Mau, "Loi o mau so");
        }
        [Test]
        public void TestHamDung2ThamSo()
        {
            PhanSo p;
            p = new PhanSo(3,4);
            Assert.AreEqual(3, p.Tu, "Loi o tu so");
            Assert.AreEqual(4, p.Mau, "Loi o mau so");
        }
        [Test]
        public void Test_CongPSDuong()
        {
            PhanSo p1 = new PhanSo(1, 2);
            PhanSo p2 = new PhanSo(3, 4);
            PhanSo p3 = p1.Cong(p2);
            Assert.AreEqual(10, p3.Tu, "Loi o tu so");
            Assert.AreEqual(8, p3.Mau, "Loi o tu so");
          
        }
    }
}
