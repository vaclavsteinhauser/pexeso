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
    public partial class Pexeso : Form
    {
        private int zbyvajicidvojice;
        private int[,] reseni;
        private Button[] otocene=new Button[2];
        private int otoceneColumn=-1, otoceneRow=-1;
        Label skore;
        bool uhodnuto=false;
        public Pexeso(int policka,int sloupce,int radky,int pocetdruhu)
        {
            InitializeComponent();
            reseni = new int[sloupce, radky];
            GeneratorReseni(sloupce,radky, policka,pocetdruhu);
            zbyvajicidvojice = policka / 2;
            tabulka.RowCount = Program.radky+1;
            tabulka.ColumnCount = Program.sloupce;
            skore = new Label();
            tabulka.Controls.Add(skore, tabulka.ColumnCount / 2, tabulka.RowCount);
            skore.Text = "Zbývá "+zbyvajicidvojice.ToString()+" dvojic";
            for (int i = 0; i < tabulka.ColumnCount; i++)
                for (int j = 0; j < tabulka.RowCount-1; j++)
                {
                    Button novy = new Button
                    {
                        Size = new Size(100, 100),
                        Image = Program.zadni,
                        Name = $"{i} {j}"
                    };
                    novy.Click += Kliknuti;
                    tabulka.Controls.Add(novy, i, j);
                }

        }
        private void GeneratorReseni(int sloupce,int radky,int policka,int pocetdruhu)
        {
            Random rnd = new Random();
            int pocetoddruhu = 2 * zbyvajicidvojice / pocetdruhu;
            List<int> zasoba = new List<int>();
            for (int i = 0; i < pocetdruhu; i++)
                for (int j = 0; j < policka/pocetdruhu; j++)
                    zasoba.Add(i);
            for (int i = 0; i < sloupce; i++)
                for (int j = 0; j < radky; j++)
                {
                    int mezivysledek= rnd.Next()%zasoba.Count;
                    reseni[i, j] = zasoba[mezivysledek];
                    zasoba.RemoveAt(mezivysledek);
                }
        }
        private void Kliknuti(object sender, EventArgs e)
        {
            if (uhodnuto)
            {
                for (int i = 0; i < 2; i++)
                {
                    otocene[i].Dispose();
                    otocene[i] = null;
                }
                uhodnuto = false;
            }
            if (otocene[1] != null)
            {
                for(int i=0;i<2;i++)
                {
                    otocene[i].Image = Program.zadni;
                    otocene[i] = null;
                }
            }
            Button zmacknuty = (Button)sender;
            string[] aktualni = zmacknuty.Name.Split(' ');
            int aktualniColumn = int.Parse(aktualni[0]);
            int aktualniRow = int.Parse(aktualni[1]);
            if (otocene[0]==null)
            {
                otocene[0] = zmacknuty;
                otoceneColumn = aktualniColumn;
                otoceneRow = aktualniRow;
                zmacknuty.Image = Program.obrazky[reseni[aktualniColumn, aktualniRow]];
                return;
            }
            if(otocene[0]==zmacknuty)
            {
                otocene[0] = null;
                zmacknuty.Image = Program.zadni;
                return;
            }
            otocene[1] = zmacknuty;
            zmacknuty.Image = Program.obrazky[reseni[aktualniColumn, aktualniRow]];
            if (reseni[aktualniColumn, aktualniRow] == reseni[otoceneColumn, otoceneRow])
            { 
                zbyvajicidvojice--;
                skore.Text = "Zbývá " + zbyvajicidvojice.ToString() + " dvojic";
                if(zbyvajicidvojice==0)
                {
                    MessageBox.Show("Vyhral jsi");
                    this.Dispose();
                }
                uhodnuto = true;
            }                 
        }
    }
}
