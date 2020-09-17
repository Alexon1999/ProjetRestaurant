using System;

namespace RestaurantMetier
{
    public class Plat
    {
        private int idPlat;
        private string imagePlat;
        private string nomPlat;
        private int notePlat;


        public Plat(int unIdPlat ,  string unNomPlat, int uneNotePlat, string uneImagePlat)
        {
            IdPlat = unIdPlat;
            ImagePlat = uneImagePlat;
            NomPlat = unNomPlat;
            NotePlat = uneNotePlat;
        }

        public int IdPlat { get => idPlat; set => idPlat = value; }
        public string ImagePlat { get => imagePlat; set => imagePlat = value; }
        public string NomPlat { get => nomPlat; set => nomPlat = value; }
        public int NotePlat { get => notePlat; set => notePlat = value; }


        public void NoterUnPlat(int uneNote)
        {
            NotePlat += uneNote;
        }

    }
}
