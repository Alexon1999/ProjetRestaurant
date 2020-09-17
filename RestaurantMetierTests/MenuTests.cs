using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantMetier;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMetier.Tests
{
    [TestClass()]
    public class MenuTests
    {
        [TestMethod()]
        public void CalculerNoteTest()
        {
            Menu m1 = new Menu(1, "soir");

            Plat p1 = new Plat(1, "image.png", "pizza", 8);
            Plat p2 = new Plat(2, "image.png", "briyani", 10);
            Plat p3 = new Plat(3, "image.png", "kebab", 5);
            Plat p4 = new Plat(4, "image.png", "mcdo", 3);

            m1.AjouterPlat(p1);
            m1.AjouterPlat(p2);
            m1.AjouterPlat(p3);
            m1.AjouterPlat(p4);


            Assert.AreEqual(26, m1.CalculerNote());
        }

        [TestMethod()]
        public void AjouterPlatTest()
        {
            Menu m1 = new Menu(1, "soir");

            Plat p1 = new Plat(1, "image.png", "pizza", 8);
            Plat p2 = new Plat(2, "image.png", "briyani", 10);
            Plat p3 = new Plat(3, "image.png", "kebab", 5);
            Plat p4 = new Plat(4, "image.png", "mcdo", 3);

            m1.AjouterPlat(p1);
            m1.AjouterPlat(p2);
            m1.AjouterPlat(p3);
            m1.AjouterPlat(p4);


            Assert.AreEqual(4, m1.LesPlats.Count);

        }
    }
}