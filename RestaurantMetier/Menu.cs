using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMetier
{
    public class Menu
    {
        private int idMenu;
        private string nomMenu;
        private List<Plat> lesPlats;


        public Menu(int unIdMenu , string unNomMenu)
        {
            IdMenu = unIdMenu;
            NomMenu = unNomMenu;
            LesPlats = new List<Plat>();
        }

        public int IdMenu { get => idMenu; set => idMenu = value; }
        public string NomMenu { get => nomMenu; set => nomMenu = value; }
        public List<Plat> LesPlats { get => lesPlats; set => lesPlats = value; }


        public void AjouterPlat(Plat nouveauPlat)
        {
            lesPlats.Add(nouveauPlat);
        }

        public int CalculerNote()
        {
            int totalNotes = 0;
            lesPlats.ForEach(plat =>
            {
                totalNotes += plat.NotePlat;
            });

            return totalNotes;
        }


    }
}
