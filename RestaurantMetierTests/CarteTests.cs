using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantMetier;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMetier.Tests
{
    [TestClass()]
    public class CarteTests
    {
        [TestMethod()]
        public void AjouterMenuTest()
        {
            Carte c1 = new Carte(1, "special");

            Menu m1 = new Menu(1, "soir");
            Menu m2 = new Menu(2, "apres-midi");
            Menu m3 = new Menu(3, "matin");

           
            // System.Diagnostics.Debug.WriteLine(c1.LesMenus);
           

            c1.AjouterMenu(m1);
            c1.AjouterMenu(m2);
            c1.AjouterMenu(m3);

            Assert.AreEqual("soir", c1.LesMenus[0].NomMenu);
            Assert.AreEqual("apres-midi", c1.LesMenus[1].NomMenu);
            Assert.AreEqual("matin", c1.LesMenus[2].NomMenu);


        }

        [TestMethod()]
        public void CarteTest()
        {
            Carte c1 = new Carte(1, "special");
            Assert.AreEqual("special", c1.NomCarte);
        }

       
    }
}