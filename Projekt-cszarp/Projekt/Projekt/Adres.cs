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
    public partial class Adres : Form
    {
        public Adres()
        {
            InitializeComponent();
        }

        private void Adres_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_baza.adres' table. You can move, or remove it, as needed.
            this.adresTableAdapter.Fill(this.dataSet_baza.adres);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //aktualizuje bazę o wpisy w 
            adresTableAdapter.Update(dataSet_baza.adres);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            //sprawdza czy jest zaznaczony wiersz
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                //usuwa zaznaczony wiersz
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }
        private void Adres_FormClosing(object sender, FormClosingEventArgs e)
        {
            Start.sprawdzanieAdres = 1;
            DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie zmiany, które wprowadziłeś?", "UWAGA!!!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                adresTableAdapter.Update(dataSet_baza.adres);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
