using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMetier.Tests
{
    [TestClass()]
    public class PlatTests
    {
        [TestMethod()]
        public void NoterUnPlatTest()
        {
            Plat p1 = new Plat(1, "image.png", "pizza", 10);

            p1.NoterUnPlat(5);

            int noteDuPlat = p1.NotePlat;

            Assert.AreEqual(noteDuPlat, 5);
        }
    }
}