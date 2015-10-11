namespace Projekt
{
    partial class Samochody
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
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtMarkaSamochodu = new System.Windows.Forms.TextBox();
            this.txtPrzebieg = new System.Windows.Forms.TextBox();
            this.txtRocznik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazwaSamochodu = new System.Windows.Forms.TextBox();
            this.txtRodzajSilnika = new System.Windows.Forms.TextBox();
            this.samochodFiltruj1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.nazwaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nazwaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.samochodFiltruj1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.samochodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_baza = new Projekt.DataSet_baza();
            this.idsamochodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.przebiegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rocznikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajsilnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samochodTableAdapter = new Projekt.DataSet_bazaTableAdapters.samochodTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.samochodFiltruj1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsamochodDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.przebiegDataGridViewTextBoxColumn,
            this.rocznikDataGridViewTextBoxColumn,
            this.rodzajsilnikaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.samochodBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(154, 378);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 4;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(73, 378);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Zmień";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtMarkaSamochodu
            // 
            this.txtMarkaSamochodu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.samochodBindingSource, "marka", true));
            this.txtMarkaSamochodu.Location = new System.Drawing.Point(102, 212);
            this.txtMarkaSamochodu.Name = "txtMarkaSamochodu";
            this.txtMarkaSamochodu.Size = new System.Drawing.Size(121, 20);
            this.txtMarkaSamochodu.TabIndex = 22;
            // 
            // txtPrzebieg
            // 
            this.txtPrzebieg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.samochodBindingSource, "przebieg", true));
            this.txtPrzebieg.Location = new System.Drawing.Point(102, 239);
            this.txtPrzebieg.Name = "txtPrzebieg";
            this.txtPrzebieg.Size = new System.Drawing.Size(121, 20);
            this.txtPrzebieg.TabIndex = 21;
            // 
            // txtRocznik
            // 
            this.txtRocznik.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.samochodBindingSource, "rocznik", true));
            this.txtRocznik.Location = new System.Drawing.Point(102, 265);
            this.txtRocznik.Name = "txtRocznik";
            this.txtRocznik.Size = new System.Drawing.Size(121, 20);
            this.txtRocznik.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Rodzaj silnika";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Przebieg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Rocznik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Marka samochodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nazwa samochodu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNazwaSamochodu
            // 
            this.txtNazwaSamochodu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.samochodBindingSource, "nazwa", true));
            this.txtNazwaSamochodu.Location = new System.Drawing.Point(102, 185);
            this.txtNazwaSamochodu.Name = "txtNazwaSamochodu";
            this.txtNazwaSamochodu.Size = new System.Drawing.Size(121, 20);
            this.txtNazwaSamochodu.TabIndex = 14;
            // 
            // txtRodzajSilnika
            // 
            this.txtRodzajSilnika.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.samochodBindingSource, "rodzaj_silnika", true));
            this.txtRodzajSilnika.Location = new System.Drawing.Point(102, 289);
            this.txtRodzajSilnika.Name = "txtRodzajSilnika";
            this.txtRodzajSilnika.Size = new System.Drawing.Size(121, 20);
            this.txtRodzajSilnika.TabIndex = 23;
            // 
            // samochodFiltruj1ToolStrip
            // 
            this.samochodFiltruj1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazwaToolStripLabel,
            this.nazwaToolStripTextBox,
            this.samochodFiltruj1ToolStripButton});
            this.samochodFiltruj1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.samochodFiltruj1ToolStrip.Name = "samochodFiltruj1ToolStrip";
            this.samochodFiltruj1ToolStrip.Size = new System.Drawing.Size(663, 25);
            this.samochodFiltruj1ToolStrip.TabIndex = 24;
            this.samochodFiltruj1ToolStrip.Text = "samochodFiltruj1ToolStrip";
            // 
            // nazwaToolStripLabel
            // 
            this.nazwaToolStripLabel.Name = "nazwaToolStripLabel";
            this.nazwaToolStripLabel.Size = new System.Drawing.Size(111, 22);
            this.nazwaToolStripLabel.Text = "Nazwa samochodu:";
            // 
            // nazwaToolStripTextBox
            // 
            this.nazwaToolStripTextBox.Name = "nazwaToolStripTextBox";
            this.nazwaToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // samochodFiltruj1ToolStripButton
            // 
            this.samochodFiltruj1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.samochodFiltruj1ToolStripButton.Name = "samochodFiltruj1ToolStripButton";
            this.samochodFiltruj1ToolStripButton.Size = new System.Drawing.Size(41, 22);
            this.samochodFiltruj1ToolStripButton.Text = "Filtruj";
            this.samochodFiltruj1ToolStripButton.Click += new System.EventHandler(this.samochodFiltruj1ToolStripButton_Click);
            // 
            // samochodBindingSource
            // 
            this.samochodBindingSource.DataMember = "samochod";
            this.samochodBindingSource.DataSource = this.dataSet_baza;
            // 
            // dataSet_baza
            // 
            this.dataSet_baza.DataSetName = "DataSet_baza";
            this.dataSet_baza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idsamochodDataGridViewTextBoxColumn
            // 
            this.idsamochodDataGridViewTextBoxColumn.DataPropertyName = "id_samochod";
            this.idsamochodDataGridViewTextBoxColumn.HeaderText = "id_samochod";
            this.idsamochodDataGridViewTextBoxColumn.Name = "idsamochodDataGridViewTextBoxColumn";
            this.idsamochodDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsamochodDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa samochodu";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka samochodu";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // przebiegDataGridViewTextBoxColumn
            // 
            this.przebiegDataGridViewTextBoxColumn.DataPropertyName = "przebieg";
            this.przebiegDataGridViewTextBoxColumn.HeaderText = "Przebieg";
            this.przebiegDataGridViewTextBoxColumn.Name = "przebiegDataGridViewTextBoxColumn";
            // 
            // rocznikDataGridViewTextBoxColumn
            // 
            this.rocznikDataGridViewTextBoxColumn.DataPropertyName = "rocznik";
            this.rocznikDataGridViewTextBoxColumn.HeaderText = "Rocznik";
            this.rocznikDataGridViewTextBoxColumn.Name = "rocznikDataGridViewTextBoxColumn";
            // 
            // rodzajsilnikaDataGridViewTextBoxColumn
            // 
            this.rodzajsilnikaDataGridViewTextBoxColumn.DataPropertyName = "rodzaj_silnika";
            this.rodzajsilnikaDataGridViewTextBoxColumn.HeaderText = "Rodzaj silnika";
            this.rodzajsilnikaDataGridViewTextBoxColumn.Name = "rodzajsilnikaDataGridViewTextBoxColumn";
            // 
            // samochodTableAdapter
            // 
            this.samochodTableAdapter.ClearBeforeFill = true;
            // 
            // Samochody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 421);
            this.Controls.Add(this.samochodFiltruj1ToolStrip);
            this.Controls.Add(this.txtRodzajSilnika);
            this.Controls.Add(this.txtMarkaSamochodu);
            this.Controls.Add(this.txtPrzebieg);
            this.Controls.Add(this.txtRocznik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazwaSamochodu);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Samochody";
            this.Text = "Samochody";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Samochody_FormClosing);
            this.Load += new System.EventHandler(this.Samochody_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.samochodFiltruj1ToolStrip.ResumeLayout(false);
            this.samochodFiltruj1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_baza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet_baza dataSet_baza;
        private System.Windows.Forms.BindingSource samochodBindingSource;
        private DataSet_bazaTableAdapters.samochodTableAdapter samochodTableAdapter;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtMarkaSamochodu;
        private System.Windows.Forms.TextBox txtPrzebieg;
        private System.Windows.Forms.TextBox txtRocznik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazwaSamochodu;
        private System.Windows.Forms.TextBox txtRodzajSilnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsamochodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn przebiegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rocznikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajsilnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip samochodFiltruj1ToolStrip;
        private System.Windows.Forms.ToolStripLabel nazwaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nazwaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton samochodFiltruj1ToolStripButton;
    }
}