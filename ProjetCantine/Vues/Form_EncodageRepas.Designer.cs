namespace ProjetCantine.Vues
{
    partial class Form_EncodageRepas
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
            this.label_RechNom = new System.Windows.Forms.Label();
            this.label_RechID = new System.Windows.Forms.Label();
            this.txtBx_RechNom = new System.Windows.Forms.TextBox();
            this.txtBx_RechID = new System.Windows.Forms.TextBox();
            this.dGdVw_DetailEleve = new System.Windows.Forms.DataGridView();
            this.label_Nom = new System.Windows.Forms.Label();
            this.label_Prenom = new System.Windows.Forms.Label();
            this.label_Adresse = new System.Windows.Forms.Label();
            this.label_DateNaissce = new System.Windows.Forms.Label();
            this.label_Telephone = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.txtBx_Nom = new System.Windows.Forms.TextBox();
            this.txtBx_Prenom = new System.Windows.Forms.TextBox();
            this.txtBox_Adresse = new System.Windows.Forms.TextBox();
            this.txtBx_DateNaissce = new System.Windows.Forms.TextBox();
            this.txtBx_Telephone = new System.Windows.Forms.TextBox();
            this.txtBx_Email = new System.Windows.Forms.TextBox();
            this.label_Periode = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tAFEncodageRepasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_cantineDataSet = new ProjetCantine.Models.db_cantineDataSet();
            this.tA_F_EncodageRepas_query = new ProjetCantine.Models.db_cantineDataSetTableAdapters.TA_F_EncodageRepas_query();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGdVw_DetailEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAFEncodageRepasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label_RechNom
            // 
            this.label_RechNom.AutoSize = true;
            this.label_RechNom.Location = new System.Drawing.Point(53, 24);
            this.label_RechNom.Name = "label_RechNom";
            this.label_RechNom.Size = new System.Drawing.Size(101, 13);
            this.label_RechNom.TabIndex = 0;
            this.label_RechNom.Text = "Recherche par nom";
            // 
            // label_RechID
            // 
            this.label_RechID.AutoSize = true;
            this.label_RechID.Location = new System.Drawing.Point(457, 24);
            this.label_RechID.Name = "label_RechID";
            this.label_RechID.Size = new System.Drawing.Size(92, 13);
            this.label_RechID.TabIndex = 1;
            this.label_RechID.Text = "Recherche par ID";
            // 
            // txtBx_RechNom
            // 
            this.txtBx_RechNom.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBx_RechNom.Location = new System.Drawing.Point(168, 21);
            this.txtBx_RechNom.Name = "txtBx_RechNom";
            this.txtBx_RechNom.Size = new System.Drawing.Size(226, 20);
            this.txtBx_RechNom.TabIndex = 2;
            this.txtBx_RechNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBx_RechID
            // 
            this.txtBx_RechID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBx_RechID.Location = new System.Drawing.Point(566, 21);
            this.txtBx_RechID.Name = "txtBx_RechID";
            this.txtBx_RechID.Size = new System.Drawing.Size(226, 20);
            this.txtBx_RechID.TabIndex = 3;
            // 
            // dGdVw_DetailEleve
            // 
            this.dGdVw_DetailEleve.AllowUserToAddRows = false;
            this.dGdVw_DetailEleve.AllowUserToDeleteRows = false;
            this.dGdVw_DetailEleve.AutoGenerateColumns = false;
            this.dGdVw_DetailEleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGdVw_DetailEleve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prénomDataGridViewTextBoxColumn,
            this.dateDeNaissanceDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.paysDataGridViewTextBoxColumn});
            this.dGdVw_DetailEleve.DataSource = this.tAFEncodageRepasBindingSource;
            this.dGdVw_DetailEleve.Location = new System.Drawing.Point(168, 58);
            this.dGdVw_DetailEleve.Name = "dGdVw_DetailEleve";
            this.dGdVw_DetailEleve.ReadOnly = true;
            this.dGdVw_DetailEleve.Size = new System.Drawing.Size(686, 161);
            this.dGdVw_DetailEleve.TabIndex = 4;
            this.dGdVw_DetailEleve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(42, 236);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(29, 13);
            this.label_Nom.TabIndex = 5;
            this.label_Nom.Text = "Nom";
            // 
            // label_Prenom
            // 
            this.label_Prenom.AutoSize = true;
            this.label_Prenom.Location = new System.Drawing.Point(42, 262);
            this.label_Prenom.Name = "label_Prenom";
            this.label_Prenom.Size = new System.Drawing.Size(43, 13);
            this.label_Prenom.TabIndex = 6;
            this.label_Prenom.Text = "Prénom";
            // 
            // label_Adresse
            // 
            this.label_Adresse.AutoSize = true;
            this.label_Adresse.Location = new System.Drawing.Point(42, 288);
            this.label_Adresse.Name = "label_Adresse";
            this.label_Adresse.Size = new System.Drawing.Size(45, 13);
            this.label_Adresse.TabIndex = 7;
            this.label_Adresse.Text = "Adresse";
            this.label_Adresse.Click += new System.EventHandler(this.label_Adresse_Click);
            // 
            // label_DateNaissce
            // 
            this.label_DateNaissce.AutoSize = true;
            this.label_DateNaissce.Location = new System.Drawing.Point(42, 314);
            this.label_DateNaissce.Name = "label_DateNaissce";
            this.label_DateNaissce.Size = new System.Drawing.Size(96, 13);
            this.label_DateNaissce.TabIndex = 8;
            this.label_DateNaissce.Text = "Date de naissance";
            // 
            // label_Telephone
            // 
            this.label_Telephone.AutoSize = true;
            this.label_Telephone.Location = new System.Drawing.Point(42, 340);
            this.label_Telephone.Name = "label_Telephone";
            this.label_Telephone.Size = new System.Drawing.Size(58, 13);
            this.label_Telephone.TabIndex = 9;
            this.label_Telephone.Text = "Téléphone";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(42, 366);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(32, 13);
            this.label_Email.TabIndex = 10;
            this.label_Email.Text = "Email";
            this.label_Email.Click += new System.EventHandler(this.label_Email_Click);
            // 
            // txtBx_Nom
            // 
            this.txtBx_Nom.Location = new System.Drawing.Point(168, 233);
            this.txtBx_Nom.Name = "txtBx_Nom";
            this.txtBx_Nom.Size = new System.Drawing.Size(250, 20);
            this.txtBx_Nom.TabIndex = 11;
            // 
            // txtBx_Prenom
            // 
            this.txtBx_Prenom.Location = new System.Drawing.Point(168, 259);
            this.txtBx_Prenom.Name = "txtBx_Prenom";
            this.txtBx_Prenom.Size = new System.Drawing.Size(250, 20);
            this.txtBx_Prenom.TabIndex = 12;
            // 
            // txtBox_Adresse
            // 
            this.txtBox_Adresse.Location = new System.Drawing.Point(168, 285);
            this.txtBox_Adresse.Name = "txtBox_Adresse";
            this.txtBox_Adresse.Size = new System.Drawing.Size(250, 20);
            this.txtBox_Adresse.TabIndex = 13;
            // 
            // txtBx_DateNaissce
            // 
            this.txtBx_DateNaissce.Location = new System.Drawing.Point(168, 311);
            this.txtBx_DateNaissce.Name = "txtBx_DateNaissce";
            this.txtBx_DateNaissce.Size = new System.Drawing.Size(250, 20);
            this.txtBx_DateNaissce.TabIndex = 14;
            // 
            // txtBx_Telephone
            // 
            this.txtBx_Telephone.Location = new System.Drawing.Point(168, 337);
            this.txtBx_Telephone.Name = "txtBx_Telephone";
            this.txtBx_Telephone.Size = new System.Drawing.Size(250, 20);
            this.txtBx_Telephone.TabIndex = 15;
            // 
            // txtBx_Email
            // 
            this.txtBx_Email.Location = new System.Drawing.Point(168, 363);
            this.txtBx_Email.Name = "txtBx_Email";
            this.txtBx_Email.Size = new System.Drawing.Size(250, 20);
            this.txtBx_Email.TabIndex = 16;
            // 
            // label_Periode
            // 
            this.label_Periode.AutoSize = true;
            this.label_Periode.Location = new System.Drawing.Point(549, 236);
            this.label_Periode.Name = "label_Periode";
            this.label_Periode.Size = new System.Drawing.Size(43, 13);
            this.label_Periode.TabIndex = 17;
            this.label_Periode.Text = "Période";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(627, 231);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 18;
            // 
            // tAFEncodageRepasBindingSource
            // 
            this.tAFEncodageRepasBindingSource.DataMember = "TA_F_EncodageRepas";
            this.tAFEncodageRepasBindingSource.DataSource = this.db_cantineDataSet;
            // 
            // db_cantineDataSet
            // 
            this.db_cantineDataSet.DataSetName = "db_cantineDataSet";
            this.db_cantineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tA_F_EncodageRepas_query
            // 
            this.tA_F_EncodageRepas_query.ClearBeforeFill = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prénomDataGridViewTextBoxColumn
            // 
            this.prénomDataGridViewTextBoxColumn.DataPropertyName = "Prénom";
            this.prénomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prénomDataGridViewTextBoxColumn.Name = "prénomDataGridViewTextBoxColumn";
            this.prénomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDeNaissanceDataGridViewTextBoxColumn
            // 
            this.dateDeNaissanceDataGridViewTextBoxColumn.DataPropertyName = "Date de naissance";
            this.dateDeNaissanceDataGridViewTextBoxColumn.HeaderText = "Date de naissance";
            this.dateDeNaissanceDataGridViewTextBoxColumn.Name = "dateDeNaissanceDataGridViewTextBoxColumn";
            this.dateDeNaissanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresseDataGridViewTextBoxColumn.Width = 70;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "Ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paysDataGridViewTextBoxColumn
            // 
            this.paysDataGridViewTextBoxColumn.DataPropertyName = "Pays";
            this.paysDataGridViewTextBoxColumn.HeaderText = "Pays";
            this.paysDataGridViewTextBoxColumn.Name = "paysDataGridViewTextBoxColumn";
            this.paysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form_EncodageRepas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.ControlBox = false;
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label_Periode);
            this.Controls.Add(this.txtBx_Email);
            this.Controls.Add(this.txtBx_Telephone);
            this.Controls.Add(this.txtBx_DateNaissce);
            this.Controls.Add(this.txtBox_Adresse);
            this.Controls.Add(this.txtBx_Prenom);
            this.Controls.Add(this.txtBx_Nom);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Telephone);
            this.Controls.Add(this.label_DateNaissce);
            this.Controls.Add(this.label_Adresse);
            this.Controls.Add(this.label_Prenom);
            this.Controls.Add(this.label_Nom);
            this.Controls.Add(this.dGdVw_DetailEleve);
            this.Controls.Add(this.txtBx_RechID);
            this.Controls.Add(this.txtBx_RechNom);
            this.Controls.Add(this.label_RechID);
            this.Controls.Add(this.label_RechNom);
            this.Name = "Form_EncodageRepas";
            this.Text = "Encodage des repas par l\'élève";
            this.Load += new System.EventHandler(this.Form_EncodageRepas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGdVw_DetailEleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAFEncodageRepasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_RechNom;
        private System.Windows.Forms.Label label_RechID;
        private System.Windows.Forms.TextBox txtBx_RechNom;
        private System.Windows.Forms.TextBox txtBx_RechID;
        private System.Windows.Forms.DataGridView dGdVw_DetailEleve;
        private System.Windows.Forms.Label label_Nom;
        private System.Windows.Forms.Label label_Prenom;
        private System.Windows.Forms.Label label_Adresse;
        private System.Windows.Forms.Label label_DateNaissce;
        private System.Windows.Forms.Label label_Telephone;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox txtBx_Nom;
        private System.Windows.Forms.TextBox txtBx_Prenom;
        private System.Windows.Forms.TextBox txtBox_Adresse;
        private System.Windows.Forms.TextBox txtBx_DateNaissce;
        private System.Windows.Forms.TextBox txtBx_Telephone;
        private System.Windows.Forms.TextBox txtBx_Email;
        private System.Windows.Forms.Label label_Periode;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Models.db_cantineDataSet db_cantineDataSet;
        private System.Windows.Forms.BindingSource tAFEncodageRepasBindingSource;
        private Models.db_cantineDataSetTableAdapters.TA_F_EncodageRepas_query tA_F_EncodageRepas_query;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paysDataGridViewTextBoxColumn;
    }
}