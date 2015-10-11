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
    public partial class Wypozyczenie_samochod : Form
    {
        public Wypozyczenie_samochod()
        {
            InitializeComponent();
        }

        private void Wypozyczenie_samochod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_baza.samochod' table. You can move, or remove it, as needed.
            this.samochodTableAdapter.Fill(this.dataSet_baza.samochod);
            // TODO: This line of code loads data into the 'dataSet_baza.wypozyczenie' table. You can move, or remove it, as needed.
            this.wypozyczenieTableAdapter.Fill(this.dataSet_baza.wypozyczenie);
            // TODO: This line of code loads data into the 'dataSet_baza.wypozyczenie_samochod' table. You can move, or remove it, as needed.
            this.wypozyczenie_samochodTableAdapter.Fill(this.dataSet_baza.wypozyczenie_samochod);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            wypozyczenie_samochodTableAdapter.Update(dataSet_baza.wypozyczenie_samochod);
        }

        private void Wypozyczenie_samochod_FormClosing(object sender, FormClosingEventArgs e)
        {
            Start.sprawdzanieSamochodWypozyczenie = 1;
            DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie zmiany, które wprowadziłeś?", "UWAGA!!!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                wypozyczenie_samochodTableAdapter.Update(dataSet_baza.wypozyczenie_samochod);
            }
        }
    }
}
