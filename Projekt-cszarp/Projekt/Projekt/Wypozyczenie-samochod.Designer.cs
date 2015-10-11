namespace Projekt
{
    partial class Wypozyczenie_samochod
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
            this.idwypozyczenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wypozyczenieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_baza = new Projekt.DataSet_baza();
            this.idsamochodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.samochodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczeniesamochodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbAdres = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbSamochod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wypozyczenie_samochodTableAdapter = new Projekt.DataSet_bazaTableAdapters.wypozyczenie_samochodTableAdapter();
            this.wypozyczenieTableAdapter = new Projekt.DataSet_bazaTableAdapters.wypozyczenieTableAdapter();
            this.samochodTableAdapter = new Projekt.DataSet_bazaTableAdapters.samochodTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczenieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniesamochodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczenieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idwypozyczenieDataGridViewTextBoxColumn,
            this.idsamochodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wypozyczeniesamochodBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(283, 140);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idwypozyczenieDataGridViewTextBoxColumn
            // 
            this.idwypozyczenieDataGridViewTextBoxColumn.DataPropertyName = "id_wypozyczenie";
            this.idwypozyczenieDataGridViewTextBoxColumn.DataSource = this.wypozyczenieBindingSource1;
            this.idwypozyczenieDataGridViewTextBoxColumn.DisplayMember = "data_zakupu";
            this.idwypozyczenieDataGridViewTextBoxColumn.HeaderText = "Wypożyczenie";
            this.idwypozyczenieDataGridViewTextBoxColumn.Name = "idwypozyczenieDataGridViewTextBoxColumn";
            this.idwypozyczenieDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idwypozyczenieDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idwypozyczenieDataGridViewTextBoxColumn.ValueMember = "id_wypozyczenie";
            // 
            // wypozyczenieBindingSource1
            // 
            this.wypozyczenieBindingSource1.DataMember = "wypozyczenie";
            this.wypozyczenieBindingSource1.DataSource = this.dataSet_baza;
            // 
            // dataSet_baza
            // 
            this.dataSet_baza.DataSetName = "DataSet_baza";
            this.dataSet_baza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idsamochodDataGridViewTextBoxColumn
            // 
            this.idsamochodDataGridViewTextBoxColumn.DataPropertyName = "id_samochod";
            this.idsamochodDataGridViewTextBoxColumn.DataSource = this.samochodBindingSource;
            this.idsamochodDataGridViewTextBoxColumn.DisplayMember = "nazwa";
            this.idsamochodDataGridViewTextBoxColumn.HeaderText = "Samochód";
            this.idsamochodDataGridViewTextBoxColumn.Name = "idsamochodDataGridViewTextBoxColumn";
            this.idsamochodDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idsamochodDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idsamochodDataGridViewTextBoxColumn.ValueMember = "id_samochod";
            // 
            // samochodBindingSource
            // 
            this.samochodBindingSource.DataMember = "samochod";
            this.samochodBindingSource.DataSource = this.dataSet_baza;
            // 
            // wypozyczeniesamochodBindingSource
            // 
            this.wypozyczeniesamochodBindingSource.DataMember = "wypozyczenie_samochod";
            this.wypozyczeniesamochodBindingSource.DataSource = this.dataSet_baza;
            // 
            // wypozyczenieBindingSource
            // 
            this.wypozyczenieBindingSource.DataMember = "wypozyczenie";
            this.wypozyczenieBindingSource.DataSource = this.dataSet_baza;
            // 
            // cmbAdres
            // 
            this.cmbAdres.DataSource = this.wypozyczenieBindingSource;
            this.cmbAdres.DisplayMember = "data_zakupu";
            this.cmbAdres.FormattingEnabled = true;
            this.cmbAdres.Location = new System.Drawing.Point(105, 188);
            this.cmbAdres.Name = "cmbAdres";
            this.cmbAdres.Size = new System.Drawing.Size(121, 21);
            this.cmbAdres.TabIndex = 17;
            this.cmbAdres.ValueMember = "id_wypozyczenie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Wypożyczenie";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(105, 294);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 15;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(24, 294);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Zmień";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbSamochod
            // 
            this.cmbSamochod.DataSource = this.samochodBindingSource;
            this.cmbSamochod.DisplayMember = "nazwa";
            this.cmbSamochod.FormattingEnabled = true;
            this.cmbSamochod.Location = new System.Drawing.Point(105, 215);
            this.cmbSamochod.Name = "cmbSamochod";
            this.cmbSamochod.Size = new System.Drawing.Size(121, 21);
            this.cmbSamochod.TabIndex = 19;
            this.cmbSamochod.ValueMember = "id_samochod";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Samochód";
            // 
            // wypozyczenie_samochodTableAdapter
            // 
            this.wypozyczenie_samochodTableAdapter.ClearBeforeFill = true;
            // 
            // wypozyczenieTableAdapter
            // 
            this.wypozyczenieTableAdapter.ClearBeforeFill = true;
            // 
            // samochodTableAdapter
            // 
            this.samochodTableAdapter.ClearBeforeFill = true;
            // 
            // Wypozyczenie_samochod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 345);
            this.Controls.Add(this.cmbSamochod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Wypozyczenie_samochod";
            this.Text = "Wypozyczenie_samochod";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Wypozyczenie_samochod_FormClosing);
            this.Load += new System.EventHandler(this.Wypozyczenie_samochod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczenieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniesamochodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczenieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet_baza dataSet_baza;
        private System.Windows.Forms.BindingSource wypozyczeniesamochodBindingSource;
        private DataSet_bazaTableAdapters.wypozyczenie_samochodTableAdapter wypozyczenie_samochodTableAdapter;
        private System.Windows.Forms.BindingSource wypozyczenieBindingSource;
        private DataSet_bazaTableAdapters.wypozyczenieTableAdapter wypozyczenieTableAdapter;
        private System.Windows.Forms.BindingSource samochodBindingSource;
        private DataSet_bazaTableAdapters.samochodTableAdapter samochodTableAdapter;
        private System.Windows.Forms.ComboBox cmbAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbSamochod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewComboBoxColumn idwypozyczenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource wypozyczenieBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn idsamochodDataGridViewTextBoxColumn;
    }
}