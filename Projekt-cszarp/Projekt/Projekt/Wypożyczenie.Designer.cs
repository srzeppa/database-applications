namespace Projekt
{
    partial class Wypożyczenie
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
            this.idwypozyczenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idklientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.klientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_baza = new Projekt.DataSet_baza();
            this.datazakupuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datazwrotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wypozyczenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczenieTableAdapter = new Projekt.DataSet_bazaTableAdapters.wypozyczenieTableAdapter();
            this.klientTableAdapter = new Projekt.DataSet_bazaTableAdapters.klientTableAdapter();
            this.txtDataZakupu = new System.Windows.Forms.TextBox();
            this.txtDataZwrotu = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbKlient = new System.Windows.Forms.ComboBox();
            this.klientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idwypozyczenieDataGridViewTextBoxColumn,
            this.idklientaDataGridViewTextBoxColumn,
            this.datazakupuDataGridViewTextBoxColumn,
            this.datazwrotuDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wypozyczenieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 133);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idwypozyczenieDataGridViewTextBoxColumn
            // 
            this.idwypozyczenieDataGridViewTextBoxColumn.DataPropertyName = "id_wypozyczenie";
            this.idwypozyczenieDataGridViewTextBoxColumn.HeaderText = "id_wypozyczenie";
            this.idwypozyczenieDataGridViewTextBoxColumn.Name = "idwypozyczenieDataGridViewTextBoxColumn";
            this.idwypozyczenieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idwypozyczenieDataGridViewTextBoxColumn.Visible = false;
            // 
            // idklientaDataGridViewTextBoxColumn
            // 
            this.idklientaDataGridViewTextBoxColumn.DataPropertyName = "id_klienta";
            this.idklientaDataGridViewTextBoxColumn.DataSource = this.klientBindingSource2;
            this.idklientaDataGridViewTextBoxColumn.DisplayMember = "imie";
            this.idklientaDataGridViewTextBoxColumn.HeaderText = "Klient";
            this.idklientaDataGridViewTextBoxColumn.Name = "idklientaDataGridViewTextBoxColumn";
            this.idklientaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idklientaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idklientaDataGridViewTextBoxColumn.ValueMember = "id_klient";
            // 
            // klientBindingSource2
            // 
            this.klientBindingSource2.DataMember = "klient";
            this.klientBindingSource2.DataSource = this.dataSet_baza;
            // 
            // dataSet_baza
            // 
            this.dataSet_baza.DataSetName = "DataSet_baza";
            this.dataSet_baza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datazakupuDataGridViewTextBoxColumn
            // 
            this.datazakupuDataGridViewTextBoxColumn.DataPropertyName = "data_zakupu";
            this.datazakupuDataGridViewTextBoxColumn.HeaderText = "Data zakupu";
            this.datazakupuDataGridViewTextBoxColumn.Name = "datazakupuDataGridViewTextBoxColumn";
            // 
            // datazwrotuDataGridViewTextBoxColumn
            // 
            this.datazwrotuDataGridViewTextBoxColumn.DataPropertyName = "data_zwrotu";
            this.datazwrotuDataGridViewTextBoxColumn.HeaderText = "Data zwrotu";
            this.datazwrotuDataGridViewTextBoxColumn.Name = "datazwrotuDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // wypozyczenieBindingSource
            // 
            this.wypozyczenieBindingSource.DataMember = "wypozyczenie";
            this.wypozyczenieBindingSource.DataSource = this.dataSet_baza;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "klient";
            this.klientBindingSource.DataSource = this.dataSet_baza;
            // 
            // wypozyczenieTableAdapter
            // 
            this.wypozyczenieTableAdapter.ClearBeforeFill = true;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // txtDataZakupu
            // 
            this.txtDataZakupu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wypozyczenieBindingSource, "data_zakupu", true));
            this.txtDataZakupu.Location = new System.Drawing.Point(125, 188);
            this.txtDataZakupu.Name = "txtDataZakupu";
            this.txtDataZakupu.Size = new System.Drawing.Size(121, 20);
            this.txtDataZakupu.TabIndex = 34;
            // 
            // txtDataZwrotu
            // 
            this.txtDataZwrotu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wypozyczenieBindingSource, "data_zwrotu", true));
            this.txtDataZwrotu.Location = new System.Drawing.Point(125, 215);
            this.txtDataZwrotu.Name = "txtDataZwrotu";
            this.txtDataZwrotu.Size = new System.Drawing.Size(121, 20);
            this.txtDataZwrotu.TabIndex = 33;
            // 
            // txtCena
            // 
            this.txtCena.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wypozyczenieBindingSource, "cena", true));
            this.txtCena.Location = new System.Drawing.Point(125, 241);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(121, 20);
            this.txtCena.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Data_zwrotu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Data zakupu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Klient";
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(177, 354);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 25;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(96, 354);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 24;
            this.btnDodaj.Text = "Zmień";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbKlient
            // 
            this.cmbKlient.DataSource = this.klientBindingSource1;
            this.cmbKlient.DisplayMember = "nazwisko";
            this.cmbKlient.FormattingEnabled = true;
            this.cmbKlient.Location = new System.Drawing.Point(125, 161);
            this.cmbKlient.Name = "cmbKlient";
            this.cmbKlient.Size = new System.Drawing.Size(121, 21);
            this.cmbKlient.TabIndex = 35;
            this.cmbKlient.ValueMember = "nazwisko";
            // 
            // klientBindingSource1
            // 
            this.klientBindingSource1.DataMember = "klient";
            this.klientBindingSource1.DataSource = this.dataSet_baza;
            // 
            // Wypożyczenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 407);
            this.Controls.Add(this.cmbKlient);
            this.Controls.Add(this.txtDataZakupu);
            this.Controls.Add(this.txtDataZwrotu);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Wypożyczenie";
            this.Text = "Wypożyczenie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Wypożyczenie_FormClosing);
            this.Load += new System.EventHandler(this.Wypożyczenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet_baza dataSet_baza;
        private System.Windows.Forms.BindingSource wypozyczenieBindingSource;
        private DataSet_bazaTableAdapters.wypozyczenieTableAdapter wypozyczenieTableAdapter;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private DataSet_bazaTableAdapters.klientTableAdapter klientTableAdapter;
        private System.Windows.Forms.TextBox txtDataZakupu;
        private System.Windows.Forms.TextBox txtDataZwrotu;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbKlient;
        private System.Windows.Forms.BindingSource klientBindingSource1;
        private System.Windows.Forms.BindingSource klientBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idwypozyczenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idklientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazakupuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazwrotuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
    }
}