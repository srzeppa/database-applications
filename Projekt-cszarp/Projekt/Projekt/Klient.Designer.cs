namespace Projekt
{
    partial class Klient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_baza = new Projekt.DataSet_baza();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientTableAdapter = new Projekt.DataSet_bazaTableAdapters.klientTableAdapter();
            this.adresTableAdapter = new Projekt.DataSet_bazaTableAdapters.adresTableAdapter();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataUrodzenia = new System.Windows.Forms.TextBox();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.cmbAdres = new System.Windows.Forms.ComboBox();
            this.adresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetbazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.picZdjecie = new System.Windows.Forms.PictureBox();
            this.btnZdjecie = new System.Windows.Forms.Button();
            this.btnZapiszZdjecie = new System.Windows.Forms.Button();
            this.searchNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.nazwiskoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nazwiskoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.idklientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zdjecie = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetbazaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZdjecie)).BeginInit();
            this.searchNameToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idklientDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.peselDataGridViewTextBoxColumn,
            this.dataurDataGridViewTextBoxColumn,
            this.idadresDataGridViewTextBoxColumn,
            this.zdjecie});
            this.dataGridView1.DataSource = this.klientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(790, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // adresBindingSource
            // 
            this.adresBindingSource.DataMember = "adres";
            this.adresBindingSource.DataSource = this.dataSet_baza;
            // 
            // dataSet_baza
            // 
            this.dataSet_baza.DataSetName = "DataSet_baza";
            this.dataSet_baza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "klient";
            this.klientBindingSource.DataSource = this.dataSet_baza;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // adresTableAdapter
            // 
            this.adresTableAdapter.ClearBeforeFill = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 393);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Zmień";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(93, 393);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 2;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // txtImie
            // 
            this.txtImie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "imie", true));
            this.txtImie.Location = new System.Drawing.Point(93, 234);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(121, 20);
            this.txtImie.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Imię";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data urodzenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "pesel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adres";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDataUrodzenia
            // 
            this.txtDataUrodzenia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "data_ur", true));
            this.txtDataUrodzenia.Location = new System.Drawing.Point(93, 314);
            this.txtDataUrodzenia.Name = "txtDataUrodzenia";
            this.txtDataUrodzenia.Size = new System.Drawing.Size(121, 20);
            this.txtDataUrodzenia.TabIndex = 10;
            // 
            // txtPesel
            // 
            this.txtPesel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "pesel", true));
            this.txtPesel.Location = new System.Drawing.Point(93, 288);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(121, 20);
            this.txtPesel.TabIndex = 11;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "nazwisko", true));
            this.txtNazwisko.Location = new System.Drawing.Point(93, 261);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(121, 20);
            this.txtNazwisko.TabIndex = 12;
            // 
            // cmbAdres
            // 
            this.cmbAdres.DataSource = this.adresBindingSource1;
            this.cmbAdres.DisplayMember = "miejscowosc";
            this.cmbAdres.FormattingEnabled = true;
            this.cmbAdres.Location = new System.Drawing.Point(93, 338);
            this.cmbAdres.Name = "cmbAdres";
            this.cmbAdres.Size = new System.Drawing.Size(121, 21);
            this.cmbAdres.TabIndex = 13;
            this.cmbAdres.ValueMember = "id_adres";
            // 
            // adresBindingSource1
            // 
            this.adresBindingSource1.DataMember = "adres";
            this.adresBindingSource1.DataSource = this.dataSetbazaBindingSource;
            // 
            // dataSetbazaBindingSource
            // 
            this.dataSetbazaBindingSource.DataSource = this.dataSet_baza;
            this.dataSetbazaBindingSource.Position = 0;
            // 
            // klientBindingSource1
            // 
            this.klientBindingSource1.DataMember = "klient";
            this.klientBindingSource1.DataSource = this.dataSet_baza;
            // 
            // picZdjecie
            // 
            this.picZdjecie.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.klientBindingSource, "zdjecie", true));
            this.picZdjecie.Location = new System.Drawing.Point(375, 233);
            this.picZdjecie.Name = "picZdjecie";
            this.picZdjecie.Size = new System.Drawing.Size(168, 183);
            this.picZdjecie.TabIndex = 14;
            this.picZdjecie.TabStop = false;
            this.picZdjecie.Click += new System.EventHandler(this.picZdjecie_Click);
            // 
            // btnZdjecie
            // 
            this.btnZdjecie.Location = new System.Drawing.Point(174, 393);
            this.btnZdjecie.Name = "btnZdjecie";
            this.btnZdjecie.Size = new System.Drawing.Size(75, 23);
            this.btnZdjecie.TabIndex = 15;
            this.btnZdjecie.Text = "Przeglądaj";
            this.btnZdjecie.UseVisualStyleBackColor = true;
            this.btnZdjecie.Click += new System.EventHandler(this.btnZdjecie_Click);
            // 
            // btnZapiszZdjecie
            // 
            this.btnZapiszZdjecie.Location = new System.Drawing.Point(255, 393);
            this.btnZapiszZdjecie.Name = "btnZapiszZdjecie";
            this.btnZapiszZdjecie.Size = new System.Drawing.Size(75, 23);
            this.btnZapiszZdjecie.TabIndex = 16;
            this.btnZapiszZdjecie.Text = "Zapisz";
            this.btnZapiszZdjecie.UseVisualStyleBackColor = true;
            this.btnZapiszZdjecie.Click += new System.EventHandler(this.btnZapiszZdjecie_Click);
            // 
            // searchNameToolStrip
            // 
            this.searchNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazwiskoToolStripLabel,
            this.nazwiskoToolStripTextBox,
            this.searchNameToolStripButton});
            this.searchNameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchNameToolStrip.Name = "searchNameToolStrip";
            this.searchNameToolStrip.Size = new System.Drawing.Size(811, 25);
            this.searchNameToolStrip.TabIndex = 17;
            this.searchNameToolStrip.Text = "searchNameToolStrip";
            // 
            // nazwiskoToolStripLabel
            // 
            this.nazwiskoToolStripLabel.Name = "nazwiskoToolStripLabel";
            this.nazwiskoToolStripLabel.Size = new System.Drawing.Size(60, 22);
            this.nazwiskoToolStripLabel.Text = "Nazwisko:";
            // 
            // nazwiskoToolStripTextBox
            // 
            this.nazwiskoToolStripTextBox.Name = "nazwiskoToolStripTextBox";
            this.nazwiskoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchNameToolStripButton
            // 
            this.searchNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchNameToolStripButton.Name = "searchNameToolStripButton";
            this.searchNameToolStripButton.Size = new System.Drawing.Size(41, 22);
            this.searchNameToolStripButton.Text = "Filtruj";
            this.searchNameToolStripButton.Click += new System.EventHandler(this.searchNameToolStripButton_Click);
            // 
            // idklientDataGridViewTextBoxColumn
            // 
            this.idklientDataGridViewTextBoxColumn.DataPropertyName = "id_klient";
            this.idklientDataGridViewTextBoxColumn.HeaderText = "id_klient";
            this.idklientDataGridViewTextBoxColumn.Name = "idklientDataGridViewTextBoxColumn";
            this.idklientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idklientDataGridViewTextBoxColumn.Visible = false;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // peselDataGridViewTextBoxColumn
            // 
            this.peselDataGridViewTextBoxColumn.DataPropertyName = "pesel";
            this.peselDataGridViewTextBoxColumn.HeaderText = "PESEL";
            this.peselDataGridViewTextBoxColumn.Name = "peselDataGridViewTextBoxColumn";
            // 
            // dataurDataGridViewTextBoxColumn
            // 
            this.dataurDataGridViewTextBoxColumn.DataPropertyName = "data_ur";
            this.dataurDataGridViewTextBoxColumn.HeaderText = "Data urodzenia";
            this.dataurDataGridViewTextBoxColumn.Name = "dataurDataGridViewTextBoxColumn";
            // 
            // idadresDataGridViewTextBoxColumn
            // 
            this.idadresDataGridViewTextBoxColumn.DataPropertyName = "id_adres";
            this.idadresDataGridViewTextBoxColumn.DataSource = this.adresBindingSource;
            this.idadresDataGridViewTextBoxColumn.DisplayMember = "miejscowosc";
            this.idadresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.idadresDataGridViewTextBoxColumn.Name = "idadresDataGridViewTextBoxColumn";
            this.idadresDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idadresDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idadresDataGridViewTextBoxColumn.ValueMember = "id_adres";
            // 
            // zdjecie
            // 
            this.zdjecie.DataPropertyName = "zdjecie";
            this.zdjecie.HeaderText = "Zdjęcie";
            this.zdjecie.Name = "zdjecie";
            this.zdjecie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zdjecie.Visible = false;
            // 
            // Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 436);
            this.Controls.Add(this.searchNameToolStrip);
            this.Controls.Add(this.btnZapiszZdjecie);
            this.Controls.Add(this.btnZdjecie);
            this.Controls.Add(this.picZdjecie);
            this.Controls.Add(this.cmbAdres);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.txtPesel);
            this.Controls.Add(this.txtDataUrodzenia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Klient";
            this.Text = "Zmień";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Klient_FormClosing);
            this.Load += new System.EventHandler(this.Klient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetbazaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZdjecie)).EndInit();
            this.searchNameToolStrip.ResumeLayout(false);
            this.searchNameToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet_baza dataSet_baza;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private DataSet_bazaTableAdapters.klientTableAdapter klientTableAdapter;
        private System.Windows.Forms.BindingSource adresBindingSource;
        private DataSet_bazaTableAdapters.adresTableAdapter adresTableAdapter;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataUrodzenia;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.ComboBox cmbAdres;
        private System.Windows.Forms.BindingSource adresBindingSource1;
        private System.Windows.Forms.BindingSource dataSetbazaBindingSource;
        private System.Windows.Forms.BindingSource klientBindingSource1;
        private System.Windows.Forms.PictureBox picZdjecie;
        private System.Windows.Forms.Button btnZdjecie;
        private System.Windows.Forms.Button btnZapiszZdjecie;
        private System.Windows.Forms.ToolStrip searchNameToolStrip;
        private System.Windows.Forms.ToolStripLabel nazwiskoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nazwiskoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchNameToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idadresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn zdjecie;
    }
}