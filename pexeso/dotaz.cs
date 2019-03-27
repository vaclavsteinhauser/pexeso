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
    public partial class Dotaz : Form
    {
        public Dotaz()
        {
            InitializeComponent();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            paircount.Value = 1;
            ImgTypes.Value = 8;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            Program.pocetdruhu = (int)ImgTypes.Value;
            Program.obrazky = new Image[(int)ImgTypes.Value];
            Program.policka = (int)ImgTypes.Value * 2 * (int)paircount.Value;
            this.Dispose();
        }

        private void Dotaz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Done_Click(sender,e);
            }
        }
    }
}
