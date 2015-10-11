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
    public partial class Wypożyczenie : Form
    {
        public Wypożyczenie()
        {
            InitializeComponent();
        }

        private void Wypożyczenie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_baza.klient' table. You can move, or remove it, as needed.
            this.klientTableAdapter.Fill(this.dataSet_baza.klient);
            // TODO: This line of code loads data into the 'dataSet_baza.wypozyczenie' table. You can move, or remove it, as needed.
            this.wypozyczenieTableAdapter.Fill(this.dataSet_baza.wypozyczenie);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //aktualizuje bazę o wpisy w 
            wypozyczenieTableAdapter.Update(dataSet_baza.wypozyczenie);
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

        private void Wypożyczenie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Start.sprawdzanieWypozyczenie = 1;
            DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie zmiany, które wprowadziłeś?", "UWAGA!!!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                wypozyczenieTableAdapter.Update(dataSet_baza.wypozyczenie);
            }
        }
    }
}
