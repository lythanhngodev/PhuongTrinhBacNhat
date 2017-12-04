using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhuongTrinhBacNhat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBacNhat.Tests
{
    [TestClass()]
    public class ptbnTests
    {
        [TestMethod()]
        // bat loi nhap xuat
        public void BatLoiTest()
        {
            Assert.AreEqual(new ptbn().BatLoi("a"), false);
            Assert.AreEqual(new ptbn().BatLoi("10"), true);
        }

        [TestMethod()]
        // bat loi doi chuoi sang so (float)
        public void DoiTest()
        {
            Assert.AreEqual(new ptbn().Doi("3.3"), 3.3f);
        }

        [TestMethod()]
        public void GPTTest()
        {
            Assert.AreEqual(new ptbn().GPT(1.0f, 2.0f), "co nghiem: -2");
            Assert.AreEqual(new ptbn().GPT(0.0f, 2.0f), "vo nghiem");
            Assert.AreEqual(new ptbn().GPT(0.0f, 0.0f), "vo so nghiem");
        }
    }
}