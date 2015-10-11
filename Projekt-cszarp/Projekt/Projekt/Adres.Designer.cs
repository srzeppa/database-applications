namespace Projekt
{
    partial class Adres
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
            this.idadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodpocztowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerdomuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numermieszkaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_baza = new Projekt.DataSet_baza();
            this.adresTableAdapter = new Projekt.DataSet_bazaTableAdapters.adresTableAdapter();
            this.txtKodPocztowy = new System.Windows.Forms.TextBox();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.txtNumerDomu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMiejscowosc = new System.Windows.Forms.TextBox();
            this.txtNumerMieszkania = new System.Windows.Forms.TextBox();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idadresDataGridViewTextBoxColumn,
            this.miejscowoscDataGridViewTextBoxColumn,
            this.kodpocztowyDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.numerdomuDataGridViewTextBoxColumn,
            this.numermieszkaniaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idadresDataGridViewTextBoxColumn
            // 
            this.idadresDataGridViewTextBoxColumn.DataPropertyName = "id_adres";
            this.idadresDataGridViewTextBoxColumn.HeaderText = "id_adres";
            this.idadresDataGridViewTextBoxColumn.Name = "idadresDataGridViewTextBoxColumn";
            this.idadresDataGridViewTextBoxColumn.ReadOnly = true;
            this.idadresDataGridViewTextBoxColumn.Visible = false;
            // 
            // miejscowoscDataGridViewTextBoxColumn
            // 
            this.miejscowoscDataGridViewTextBoxColumn.DataPropertyName = "miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn.HeaderText = "Miejscowość";
            this.miejscowoscDataGridViewTextBoxColumn.Name = "miejscowoscDataGridViewTextBoxColumn";
            // 
            // kodpocztowyDataGridViewTextBoxColumn
            // 
            this.kodpocztowyDataGridViewTextBoxColumn.DataPropertyName = "kod_pocztowy";
            this.kodpocztowyDataGridViewTextBoxColumn.HeaderText = "Kod pocztowy";
            this.kodpocztowyDataGridViewTextBoxColumn.Name = "kodpocztowyDataGridViewTextBoxColumn";
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            // 
            // numerdomuDataGridViewTextBoxColumn
            // 
            this.numerdomuDataGridViewTextBoxColumn.DataPropertyName = "numer_domu";
            this.numerdomuDataGridViewTextBoxColumn.HeaderText = "Numer domu";
            this.numerdomuDataGridViewTextBoxColumn.Name = "numerdomuDataGridViewTextBoxColumn";
            // 
            // numermieszkaniaDataGridViewTextBoxColumn
            // 
            this.numermieszkaniaDataGridViewTextBoxColumn.DataPropertyName = "numer_mieszkania";
            this.numermieszkaniaDataGridViewTextBoxColumn.HeaderText = "Numer mieszkania";
            this.numermieszkaniaDataGridViewTextBoxColumn.Name = "numermieszkaniaDataGridViewTextBoxColumn";
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
            // adresTableAdapter
            // 
            this.adresTableAdapter.ClearBeforeFill = true;
            // 
            // txtKodPocztowy
            // 
            this.txtKodPocztowy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "kod_pocztowy", true));
            this.txtKodPocztowy.Location = new System.Drawing.Point(114, 208);
            this.txtKodPocztowy.Name = "txtKodPocztowy";
            this.txtKodPocztowy.Size = new System.Drawing.Size(121, 20);
            this.txtKodPocztowy.TabIndex = 22;
            // 
            // txtUlica
            // 
            this.txtUlica.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "ulica", true));
            this.txtUlica.Location = new System.Drawing.Point(114, 235);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(121, 20);
            this.txtUlica.TabIndex = 21;
            // 
            // txtNumerDomu
            // 
            this.txtNumerDomu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "numer_domu", true));
            this.txtNumerDomu.Location = new System.Drawing.Point(114, 261);
            this.txtNumerDomu.Name = "txtNumerDomu";
            this.txtNumerDomu.Size = new System.Drawing.Size(121, 20);
            this.txtNumerDomu.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Numer mieszkania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ulica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Numer domu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kod pocztowy";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Miejscowość";
            // 
            // txtMiejscowosc
            // 
            this.txtMiejscowosc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "miejscowosc", true));
            this.txtMiejscowosc.Location = new System.Drawing.Point(114, 181);
            this.txtMiejscowosc.Name = "txtMiejscowosc";
            this.txtMiejscowosc.Size = new System.Drawing.Size(121, 20);
            this.txtMiejscowosc.TabIndex = 14;
            // 
            // txtNumerMieszkania
            // 
            this.txtNumerMieszkania.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "numer_mieszkania", true));
            this.txtNumerMieszkania.Location = new System.Drawing.Point(114, 285);
            this.txtNumerMieszkania.Name = "txtNumerMieszkania";
            this.txtNumerMieszkania.Size = new System.Drawing.Size(121, 20);
            this.txtNumerMieszkania.TabIndex = 23;
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(114, 396);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 25;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(33, 396);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 24;
            this.btnDodaj.Text = "Zmień";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Adres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 449);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtNumerMieszkania);
            this.Controls.Add(this.txtKodPocztowy);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.txtNumerDomu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMiejscowosc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Adres";
            this.Text = "Adres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Adres_FormClosing);
            this.Load += new System.EventHandler(this.Adres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet_baza dataSet_baza;
        private System.Windows.Forms.BindingSource adresBindingSource;
        private DataSet_bazaTableAdapters.adresTableAdapter adresTableAdapter;
        private System.Windows.Forms.TextBox txtKodPocztowy;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.TextBox txtNumerDomu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiejscowosc;
        private System.Windows.Forms.TextBox txtNumerMieszkania;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodpocztowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerdomuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numermieszkaniaDataGridViewTextBoxColumn;
    }
}