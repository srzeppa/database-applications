using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Start : Form
    {
        public static int sprawdzanieKlient = 1;
        public static int sprawdzanieAdres = 1;
        public static int sprawdzanieWypozyczenie = 1;
        public static int sprawdzanieSamochod = 1;
        public static int sprawdzanieSamochodWypozyczenie = 1;

        public Start()
        {
            InitializeComponent();
        }

        private void tabeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void klientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Klient klient = new Klient();
            if(sprawdzanieKlient == 1){
                klient.MdiParent = this;
                klient.Show();
                sprawdzanieKlient = 0;
            }
        }

        private void adresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adres adres = new Adres();
            if (sprawdzanieAdres == 1)
            {
                adres.MdiParent = this;
                adres.Show();
                sprawdzanieAdres = 0;
            }
        }

        private void samochódToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Samochody samochod = new Samochody();
            if (sprawdzanieSamochod == 1)
            {
                samochod.MdiParent = this;
                samochod.Show();
                sprawdzanieSamochod = 0;
            }
        }

        private void wypożyczenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wypożyczenie wypozyczenie = new Wypożyczenie();
            if (sprawdzanieWypozyczenie == 1)
            {
                wypozyczenie.MdiParent = this;
                wypozyczenie.Show();
                sprawdzanieWypozyczenie = 0;
            }
        }

        private void wypożyczenieSamochoduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wypozyczenie_samochod wypozyczeniesamochod = new Wypozyczenie_samochod();
            if (sprawdzanieSamochodWypozyczenie == 1)
            {
                wypozyczeniesamochod.MdiParent = this;
                wypozyczeniesamochod.Show();
                sprawdzanieSamochodWypozyczenie = 0;
            }
        }
    }
}
