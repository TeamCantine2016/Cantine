namespace ProjetCantine
{
    partial class Form_ParamRepasPrix
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
            this.dataGridView_RepasPrix = new System.Windows.Forms.DataGridView();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.dateTimePicker_datedebut = new System.Windows.Forms.DateTimePicker();
            this.comboBox_nomRepas = new System.Windows.Forms.ComboBox();
            this.textBox_Prix = new System.Windows.Forms.TextBox();
            this.label_Prix = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Nom = new System.Windows.Forms.Label();
            this.nomDuRepasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDuRepasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_cantineDataSet2 = new ProjetCantine.Models.db_cantineDataSet();
            this.tAPrixRepasEncBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tA_PrixRepasEncTableAdapter = new ProjetCantine.Models.db_cantineDataSetTableAdapters.TA_PrixRepasEncTableAdapter();
            this.nomDuRepasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDuRepasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblrepasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_repasTableAdapter = new ProjetCantine.Models.db_cantineDataSetTableAdapters.tbl_repasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RepasPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAPrixRepasEncBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrepasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_RepasPrix
            // 
            this.dataGridView_RepasPrix.AutoGenerateColumns = false;
            this.dataGridView_RepasPrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_RepasPrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RepasPrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDuRepasDataGridViewTextBoxColumn1,
            this.prixDuRepasDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dateFinDataGridViewTextBoxColumn});
            this.dataGridView_RepasPrix.DataSource = this.tAPrixRepasEncBindingSource;
            this.dataGridView_RepasPrix.Location = new System.Drawing.Point(12, 66);
            this.dataGridView_RepasPrix.Name = "dataGridView_RepasPrix";
            this.dataGridView_RepasPrix.Size = new System.Drawing.Size(1060, 513);
            this.dataGridView_RepasPrix.TabIndex = 0;
            this.dataGridView_RepasPrix.TabStop = false;
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Location = new System.Drawing.Point(434, 595);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(150, 23);
            this.button_Ajouter.TabIndex = 20;
            this.button_Ajouter.Text = "Ajouter";
            this.button_Ajouter.UseVisualStyleBackColor = true;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // dateTimePicker_datedebut
            // 
            this.dateTimePicker_datedebut.Location = new System.Drawing.Point(725, 40);
            this.dateTimePicker_datedebut.Name = "dateTimePicker_datedebut";
            this.dateTimePicker_datedebut.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_datedebut.TabIndex = 28;
            // 
            // comboBox_nomRepas
            // 
            this.comboBox_nomRepas.DataSource = this.tblrepasBindingSource;
            this.comboBox_nomRepas.DisplayMember = "type_repas";
            this.comboBox_nomRepas.FormattingEnabled = true;
            this.comboBox_nomRepas.Location = new System.Drawing.Point(162, 39);
            this.comboBox_nomRepas.Name = "comboBox_nomRepas";
            this.comboBox_nomRepas.Size = new System.Drawing.Size(121, 21);
            this.comboBox_nomRepas.TabIndex = 27;
            this.comboBox_nomRepas.ValueMember = "id";
            // 
            // textBox_Prix
            // 
            this.textBox_Prix.Location = new System.Drawing.Point(446, 40);
            this.textBox_Prix.Name = "textBox_Prix";
            this.textBox_Prix.Size = new System.Drawing.Size(100, 20);
            this.textBox_Prix.TabIndex = 26;
            // 
            // label_Prix
            // 
            this.label_Prix.AutoSize = true;
            this.label_Prix.Location = new System.Drawing.Point(443, 9);
            this.label_Prix.Name = "label_Prix";
            this.label_Prix.Size = new System.Drawing.Size(68, 13);
            this.label_Prix.TabIndex = 25;
            this.label_Prix.Text = "Prix du repas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Date de mise en application";
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(159, 9);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(76, 13);
            this.label_Nom.TabIndex = 24;
            this.label_Nom.Text = "Nom du repas ";
            // 
            // nomDuRepasDataGridViewTextBoxColumn
            // 
            this.nomDuRepasDataGridViewTextBoxColumn.DataPropertyName = "Nom du repas";
            this.nomDuRepasDataGridViewTextBoxColumn.HeaderText = "Nom du repas";
            this.nomDuRepasDataGridViewTextBoxColumn.Name = "nomDuRepasDataGridViewTextBoxColumn";
            this.nomDuRepasDataGridViewTextBoxColumn.Width = 339;
            // 
            // prixDuRepasDataGridViewTextBoxColumn
            // 
            this.prixDuRepasDataGridViewTextBoxColumn.DataPropertyName = "Prix du repas";
            this.prixDuRepasDataGridViewTextBoxColumn.HeaderText = "Prix du repas";
            this.prixDuRepasDataGridViewTextBoxColumn.Name = "prixDuRepasDataGridViewTextBoxColumn";
            this.prixDuRepasDataGridViewTextBoxColumn.Width = 339;
            // 
            // db_cantineDataSet2
            // 
            this.db_cantineDataSet2.DataSetName = "db_cantineDataSet";
            this.db_cantineDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAPrixRepasEncBindingSource
            // 
            this.tAPrixRepasEncBindingSource.DataMember = "TA_PrixRepasEnc";
            this.tAPrixRepasEncBindingSource.DataSource = this.db_cantineDataSet2;
            // 
            // tA_PrixRepasEncTableAdapter
            // 
            this.tA_PrixRepasEncTableAdapter.ClearBeforeFill = true;
            // 
            // nomDuRepasDataGridViewTextBoxColumn1
            // 
            this.nomDuRepasDataGridViewTextBoxColumn1.DataPropertyName = "Nom du repas";
            this.nomDuRepasDataGridViewTextBoxColumn1.HeaderText = "Nom du repas";
            this.nomDuRepasDataGridViewTextBoxColumn1.Name = "nomDuRepasDataGridViewTextBoxColumn1";
            // 
            // prixDuRepasDataGridViewTextBoxColumn1
            // 
            this.prixDuRepasDataGridViewTextBoxColumn1.DataPropertyName = "Prix du repas";
            this.prixDuRepasDataGridViewTextBoxColumn1.HeaderText = "Prix du repas";
            this.prixDuRepasDataGridViewTextBoxColumn1.Name = "prixDuRepasDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Date debut";
            this.dataGridViewTextBoxColumn1.HeaderText = "Date debut";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dateFinDataGridViewTextBoxColumn
            // 
            this.dateFinDataGridViewTextBoxColumn.DataPropertyName = "Date fin";
            this.dateFinDataGridViewTextBoxColumn.HeaderText = "Date fin";
            this.dateFinDataGridViewTextBoxColumn.Name = "dateFinDataGridViewTextBoxColumn";
            // 
            // tblrepasBindingSource
            // 
            this.tblrepasBindingSource.DataMember = "tbl_repas";
            this.tblrepasBindingSource.DataSource = this.db_cantineDataSet2;
            // 
            // tbl_repasTableAdapter
            // 
            this.tbl_repasTableAdapter.ClearBeforeFill = true;
            // 
            // Form_ParamRepasPrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 662);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker_datedebut);
            this.Controls.Add(this.comboBox_nomRepas);
            this.Controls.Add(this.textBox_Prix);
            this.Controls.Add(this.label_Prix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Nom);
            this.Controls.Add(this.button_Ajouter);
            this.Controls.Add(this.dataGridView_RepasPrix);
            this.Name = "Form_ParamRepasPrix";
            this.Text = "Paramétrage des repas et des prix";
            this.Load += new System.EventHandler(this.Form_ParamRepasPrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RepasPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAPrixRepasEncBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrepasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_RepasPrix;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datedebut;
        private System.Windows.Forms.ComboBox comboBox_nomRepas;
        private System.Windows.Forms.TextBox textBox_Prix;
        private System.Windows.Forms.Label label_Prix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDuRepasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDuRepasDataGridViewTextBoxColumn;
        private Models.db_cantineDataSet db_cantineDataSet2;
        private System.Windows.Forms.BindingSource tAPrixRepasEncBindingSource;
        private Models.db_cantineDataSetTableAdapters.TA_PrixRepasEncTableAdapter tA_PrixRepasEncTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDuRepasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDuRepasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblrepasBindingSource;
        private Models.db_cantineDataSetTableAdapters.tbl_repasTableAdapter tbl_repasTableAdapter;
    }
}