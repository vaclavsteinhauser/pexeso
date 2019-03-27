using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace pexeso
{
    static class Program
    {
        public static int policka,sloupce,radky,pocetdruhu;
        public static Image[] obrazky;
        public static Image zadni;
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Zobrazím dotaz na počet druhu obrazku a pocet paru
            Application.Run(new Dotaz());
            //pokud nedobehl, nebo nastavil druhy pocet druhu na 0 tak proste spadnu
            if (pocetdruhu <= 0)
                return;
            //nastavim radky a sloupce tak aby mi vysel co "nejctvercovejsi" ležaty obdelnik
            radky = (int)Math.Sqrt(policka) + 1;
            while (sloupce * radky != policka)
            {
                radky--;
                sloupce = policka / radky;
            }
            //spustim vyber obrazku
            Application.Run(new Vyber());
            //pokud nedobehl tak skoncim
            if (obrazky[0] == null)
                return;
            //spustim pexeso
            Application.Run(new Pexeso(policka,sloupce,radky,pocetdruhu));
            
        }
    }
}
