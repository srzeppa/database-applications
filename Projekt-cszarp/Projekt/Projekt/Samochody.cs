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
    public partial class Samochody : Form
    {
        public Samochody()
        {
            InitializeComponent();
        }

        private void Samochody_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_baza.samochod' table. You can move, or remove it, as needed.
            this.samochodTableAdapter.Fill(this.dataSet_baza.samochod);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //aktualizuje bazę o wpisy w 
            samochodTableAdapter.Update(dataSet_baza.samochod);
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

        private void Samochody_FormClosing(object sender, FormClosingEventArgs e)
        {
            Start.sprawdzanieSamochod = 1;
            DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie zmiany, które wprowadziłeś?", "UWAGA!!!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                samochodTableAdapter.Update(dataSet_baza.samochod);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void samochodFiltrujToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.samochodTableAdapter.SamochodFiltruj(this.dataSet_baza.samochod);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void samochodFiltruj1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.samochodTableAdapter.SamochodFiltruj1(this.dataSet_baza.samochod, nazwaToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
