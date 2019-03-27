using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pexeso
{
    public partial class Vyber : Form
    {
        TableLayoutPanel obrazky;
        PictureBox rub;
        Button[] seznamobrazku;
        public Vyber()
        {
            //inicializace zakladnich komponent
            InitializeComponent();
            //inicializace oken k otevirani souboru
            InicializaceVyberObrazku();
            InicializaceVyberRubu();
            InicializaceVyberJeden();
            //vytvoreni tlacitek
            Button cudlik = new Button();
            cudlik.Text = "Nový výběr";
            cudlik.Click += selectFilesButton_Click;
            Button vyberrub = new Button();
            vyberrub.Text = "Rub karet:";
            vyberrub.Click +=VyberRubu_Click;
            Button reset = new Button();
            reset.Text = "Resetovat";
            reset.Click += Reset_Click;
            this.AutoSize = true;
            Button done = new Button();
            done.Text = "Hotovo";
            done.Click += Done_Click;
            //vytvoreni nahledu rubu obrazku
            rub = new PictureBox();
            rub.AutoSize = true;
            //vytvoreni prazdnych okynek pro obrazky
            resetobrazky();
            //naskladani do tabulky
            tabulka.Controls.Add(cudlik, 0, 1);
            tabulka.Controls.Add(vyberrub, 0, 0);
            tabulka.Controls.Add(rub, 1, 0);
            tabulka.Controls.Add(reset, 0, 2);
            tabulka.Controls.Add(done, 1, 2);
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            //zresetuju tabulku obrazku a nahled rubu
            resetobrazky();
            tabulka.Controls.Remove(rub);
            rub = new PictureBox();
            tabulka.Controls.Add(rub, 1, 0);
        }
        private void resetobrazky()
        {
            //zresetuju seznam obrazku a vytvorim pro ne novou tabulku
            prazdneobrazky();
            tabulka.Controls.Remove(obrazky);
            obrazky = new TableLayoutPanel();
            obrazky.RowCount = 1;
            obrazky.ColumnCount = Program.pocetdruhu;
            obrazky.Size = new Size(250, 150);
            obrazky.AutoScroll = true;
            for (int i = 0; i < Program.pocetdruhu; i++)
                obrazky.Controls.Add(seznamobrazku[i], i, 0);
            tabulka.Controls.Add(obrazky, 1, 1);
        }
        private void Done_Click(object sender, EventArgs e)
        {
            //projde seznam obrazku a pokud je nejaky obrazek prazdny tak skoncim
            for (int i = 0; i < Program.pocetdruhu; i++)
            {
                if (seznamobrazku[i].Image == null)
                {
                    MessageBox.Show("Nevybral jsi dostatek obrázků");
                    return;
                }
                Program.obrazky[i] = seznamobrazku[i].Image;
            }
            //pokud jsou vybrane vsechny obrazky tak nahraju do hlavniho programu a sam skoncim
            Program.zadni = rub.Image;
            this.Dispose();
        }
        private void prazdneobrazky()
        {
            //vytvorim nove pole s tlacitky
            seznamobrazku = new Button[Program.pocetdruhu];
            for(int i=0;i<Program.pocetdruhu;i++)
            {
                seznamobrazku[i] = new Button();
                seznamobrazku[i].Text = "+";
                seznamobrazku[i].Click += VyberJeden;
                seznamobrazku[i].AutoSize = true;
            }
        }
        private void InicializaceVyberObrazku()
        {
            //vyber pouze obrazku s multiselect
            this.OknoVyberuObrazku.Filter =
                "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            this.OknoVyberuObrazku.Multiselect = true;
            this.OknoVyberuObrazku.Title = "Výběr obrázků";
        }
        private void InicializaceVyberRubu()
        {

            this.OknoVyberuRubu.Filter =
                "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            this.OknoVyberuRubu.Multiselect = false;
            this.OknoVyberuRubu.Title = "Výběr rubu obrázků";
        }
        private void InicializaceVyberJeden()
        {

            this.OknoVyberJeden.Filter =
                "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            this.OknoVyberJeden.Multiselect = false;
            this.OknoVyberJeden.Title = "Nahradit jeden obrázek:";
        }
        private void VyberJeden(object sender, EventArgs e)
        {
            //pokud nekdo zmacknul tlacitko a vybral obrazek tak nastavim tento obrazek jako pozadi zmacknuteho tlacitka
            DialogResult dr = this.OknoVyberJeden.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ((Button)sender).Text = "";
                ((Button)sender).Image = new Bitmap(Image.FromFile(OknoVyberJeden.FileName),100,100);
            }
        }
        private void VyberRubu_Click(object sender, EventArgs e)
        {
            //nastavim rub
            DialogResult dr = this.OknoVyberuRubu.ShowDialog();
            if (dr == DialogResult.OK)
            {
                rub.Image = new Bitmap(Image.FromFile(OknoVyberuRubu.FileName),100,100);
            }
        }
        private void selectFilesButton_Click(object sender, EventArgs e)
        {
            //Smazu zatim vybrane obrazky a nactu nekolik prvnich obrazku z vyberu
            DialogResult dr = this.OknoVyberuObrazku.ShowDialog();
            if (dr == DialogResult.OK)
            {
                resetobrazky();
                for(int i=0;i<Program.pocetdruhu;i++)
                {
                    seznamobrazku[i].Image = new Bitmap(Image.FromFile(OknoVyberuObrazku.FileNames[i]),100,100);
                }
            }
        }
    }
}
