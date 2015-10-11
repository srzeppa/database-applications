using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Projekt
{
    public partial class Klient : Form
    {
        string imgLoc = "";
        public Klient()
        {
            InitializeComponent();
        }

        private void Klient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_baza.adres' table. You can move, or remove it, as needed.
            this.adresTableAdapter.Fill(this.dataSet_baza.adres);
            // TODO: This line of code loads data into the 'dataSet_baza.klient' table. You can move, or remove it, as needed.
            this.klientTableAdapter.Fill(this.dataSet_baza.klient);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //aktualizuje bazę o wpisy w 
            klientTableAdapter.Update(dataSet_baza.klient);
        }

        private void Klient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Start.sprawdzanieKlient = 1;
            DialogResult dr = MessageBox.Show("Czy chcesz zapisać wszystkie zmiany, które wprowadziłeś?", "UWAGA!!!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                klientTableAdapter.Update(dataSet_baza.klient);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picZdjecie_Click(object sender, EventArgs e)
        {

        }

        private void btnZdjecie_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Wybierz zdjęcie";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    picZdjecie.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZapiszZdjecie_Click(object sender, EventArgs e)
        {
            byte[] img = null;
            FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            klientTableAdapter.Update(dataSet_baza.klient);
        }

        private void searchNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.klientTableAdapter.SearchName(this.dataSet_baza.klient, nazwiskoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
