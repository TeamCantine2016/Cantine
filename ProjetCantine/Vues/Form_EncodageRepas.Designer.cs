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
            this.txtBx_RechNom = new System.Windows.Forms.TextBox();
            this.dGdVw_DetailEleve = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAListesPersonnesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_cantineDataSet = new ProjetCantine.Models.db_cantineDataSet();
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBoxLundi = new System.Windows.Forms.GroupBox();
            this.radioButtonAucunLundi = new System.Windows.Forms.RadioButton();
            this.radioButtonRepasFroidLundi = new System.Windows.Forms.RadioButton();
            this.radioButtonRepasChaud2Lundi = new System.Windows.Forms.RadioButton();
            this.radioButtonRepasChaud1Lundi = new System.Windows.Forms.RadioButton();
            this.groupBoxMardi = new System.Windows.Forms.GroupBox();
            this.radioButtonAucunMardi = new System.Windows.Forms.RadioButton();
            this.radioButtonRepasFroidMardi = new System.Windows.Forms.RadioButton();
            this.radioButtonRepasChaud2Mardi = new System.Windows.Forms.RadioButton();
            this.radioButtonRepasChaud1Mardi = new System.Windows.Forms.RadioButton();
            this.groupBoxMercredi = new System.Windows.Forms.GroupBox();
            this.radioButtonAucunMercredi = new System.Windows.Forms.RadioButton();
            this.radioButtonRepasFroidMercredi = new System.Windows.Forms.RadioButton();
            this.radioButtonRepasChaud2Mercredi = new System.Windows.Forms.RadioButton();
            this.radioButtonRepasChaud1Mercredi = new System.Windows.Forms.RadioButton();
            this.groupBoxJeudi = new System.Windows.Forms.GroupBox();
            this.radioButtonAucunJeudi = new System.Windows.Forms.RadioButton();
            this.radioButtonRepasFroidJeudi = new System.Windows.Forms.RadioButton();
            this.radioButtonRepasChaud2Jeudi = new System.Windows.Forms.RadioButton();
            this.radioButtonRepasChaud1Jeudi = new System.Windows.Forms.RadioButton();
            this.groupBoxVendredi = new System.Windows.Forms.GroupBox();
            this.radioButtonAucunVendredi = new System.Windows.Forms.RadioButton();
            this.radioButtonRepasFroidVendredi = new System.Windows.Forms.RadioButton();
            this.radioButtonRepasChaud2Vendredi = new System.Windows.Forms.RadioButton();
            this.radioButtonRepasChaud1Vendredi = new System.Windows.Forms.RadioButton();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btConfirmation = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.tA_Listes_Personnes_query = new ProjetCantine.Models.db_cantineDataSetTableAdapters.TA_Listes_Personnes_query();
            this.groupBoxPeriode = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFin = new System.Windows.Forms.Label();
            this.labelDebut = new System.Windows.Forms.Label();
            this.lbDebut = new System.Windows.Forms.Label();
            this.labelEtat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGdVw_DetailEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAListesPersonnesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet)).BeginInit();
            this.groupBoxLundi.SuspendLayout();
            this.groupBoxMardi.SuspendLayout();
            this.groupBoxMercredi.SuspendLayout();
            this.groupBoxJeudi.SuspendLayout();
            this.groupBoxVendredi.SuspendLayout();
            this.groupBoxPeriode.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_RechNom
            // 
            this.label_RechNom.AutoSize = true;
            this.label_RechNom.Location = new System.Drawing.Point(85, 24);
            this.label_RechNom.Name = "label_RechNom";
            this.label_RechNom.Size = new System.Drawing.Size(101, 13);
            this.label_RechNom.TabIndex = 0;
            this.label_RechNom.Text = "Recherche par nom";
            // 
            // txtBx_RechNom
            // 
            this.txtBx_RechNom.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBx_RechNom.Location = new System.Drawing.Point(200, 21);
            this.txtBx_RechNom.Name = "txtBx_RechNom";
            this.txtBx_RechNom.Size = new System.Drawing.Size(226, 20);
            this.txtBx_RechNom.TabIndex = 2;
            this.txtBx_RechNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dGdVw_DetailEleve
            // 
            this.dGdVw_DetailEleve.AllowUserToAddRows = false;
            this.dGdVw_DetailEleve.AllowUserToDeleteRows = false;
            this.dGdVw_DetailEleve.AutoGenerateColumns = false;
            this.dGdVw_DetailEleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGdVw_DetailEleve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nomDataGridViewTextBoxColumn,
            this.prénomDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.adresseDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.paysDataGridViewTextBoxColumn});
            this.dGdVw_DetailEleve.DataSource = this.tAListesPersonnesBindingSource;
            this.dGdVw_DetailEleve.Location = new System.Drawing.Point(200, 59);
            this.dGdVw_DetailEleve.Name = "dGdVw_DetailEleve";
            this.dGdVw_DetailEleve.ReadOnly = true;
            this.dGdVw_DetailEleve.Size = new System.Drawing.Size(686, 161);
            this.dGdVw_DetailEleve.TabIndex = 4;
            this.dGdVw_DetailEleve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGdVw_DetailEleve_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Date de naissance";
            this.dataGridViewTextBoxColumn1.HeaderText = "Date De Naissance";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 8;
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
            // tAListesPersonnesBindingSource
            // 
            this.tAListesPersonnesBindingSource.DataMember = "TA_Listes_Personnes";
            this.tAListesPersonnesBindingSource.DataSource = this.db_cantineDataSet;
            // 
            // db_cantineDataSet
            // 
            this.db_cantineDataSet.DataSetName = "db_cantineDataSet";
            this.db_cantineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(74, 236);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(29, 13);
            this.label_Nom.TabIndex = 5;
            this.label_Nom.Text = "Nom";
            // 
            // label_Prenom
            // 
            this.label_Prenom.AutoSize = true;
            this.label_Prenom.Location = new System.Drawing.Point(74, 262);
            this.label_Prenom.Name = "label_Prenom";
            this.label_Prenom.Size = new System.Drawing.Size(43, 13);
            this.label_Prenom.TabIndex = 6;
            this.label_Prenom.Text = "Prénom";
            // 
            // label_Adresse
            // 
            this.label_Adresse.AutoSize = true;
            this.label_Adresse.Location = new System.Drawing.Point(74, 288);
            this.label_Adresse.Name = "label_Adresse";
            this.label_Adresse.Size = new System.Drawing.Size(45, 13);
            this.label_Adresse.TabIndex = 7;
            this.label_Adresse.Text = "Adresse";
            // 
            // label_DateNaissce
            // 
            this.label_DateNaissce.AutoSize = true;
            this.label_DateNaissce.Location = new System.Drawing.Point(74, 314);
            this.label_DateNaissce.Name = "label_DateNaissce";
            this.label_DateNaissce.Size = new System.Drawing.Size(96, 13);
            this.label_DateNaissce.TabIndex = 8;
            this.label_DateNaissce.Text = "Date de naissance";
            // 
            // label_Telephone
            // 
            this.label_Telephone.AutoSize = true;
            this.label_Telephone.Location = new System.Drawing.Point(74, 340);
            this.label_Telephone.Name = "label_Telephone";
            this.label_Telephone.Size = new System.Drawing.Size(98, 13);
            this.label_Telephone.TabIndex = 9;
            this.label_Telephone.Text = "Téléphone (Tuteur)";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(74, 366);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(72, 13);
            this.label_Email.TabIndex = 10;
            this.label_Email.Text = "Email (Tuteur)";
            // 
            // txtBx_Nom
            // 
            this.txtBx_Nom.Location = new System.Drawing.Point(200, 233);
            this.txtBx_Nom.Name = "txtBx_Nom";
            this.txtBx_Nom.ReadOnly = true;
            this.txtBx_Nom.Size = new System.Drawing.Size(250, 20);
            this.txtBx_Nom.TabIndex = 11;
            // 
            // txtBx_Prenom
            // 
            this.txtBx_Prenom.Location = new System.Drawing.Point(200, 259);
            this.txtBx_Prenom.Name = "txtBx_Prenom";
            this.txtBx_Prenom.ReadOnly = true;
            this.txtBx_Prenom.Size = new System.Drawing.Size(250, 20);
            this.txtBx_Prenom.TabIndex = 12;
            // 
            // txtBox_Adresse
            // 
            this.txtBox_Adresse.Location = new System.Drawing.Point(200, 285);
            this.txtBox_Adresse.Name = "txtBox_Adresse";
            this.txtBox_Adresse.ReadOnly = true;
            this.txtBox_Adresse.Size = new System.Drawing.Size(250, 20);
            this.txtBox_Adresse.TabIndex = 13;
            // 
            // txtBx_DateNaissce
            // 
            this.txtBx_DateNaissce.Location = new System.Drawing.Point(200, 311);
            this.txtBx_DateNaissce.Name = "txtBx_DateNaissce";
            this.txtBx_DateNaissce.ReadOnly = true;
            this.txtBx_DateNaissce.Size = new System.Drawing.Size(250, 20);
            this.txtBx_DateNaissce.TabIndex = 14;
            // 
            // txtBx_Telephone
            // 
            this.txtBx_Telephone.Location = new System.Drawing.Point(200, 337);
            this.txtBx_Telephone.Name = "txtBx_Telephone";
            this.txtBx_Telephone.ReadOnly = true;
            this.txtBx_Telephone.Size = new System.Drawing.Size(250, 20);
            this.txtBx_Telephone.TabIndex = 15;
            // 
            // txtBx_Email
            // 
            this.txtBx_Email.Location = new System.Drawing.Point(200, 363);
            this.txtBx_Email.Name = "txtBx_Email";
            this.txtBx_Email.ReadOnly = true;
            this.txtBx_Email.Size = new System.Drawing.Size(250, 20);
            this.txtBx_Email.TabIndex = 16;
            // 
            // label_Periode
            // 
            this.label_Periode.AutoSize = true;
            this.label_Periode.Location = new System.Drawing.Point(581, 236);
            this.label_Periode.Name = "label_Periode";
            this.label_Periode.Size = new System.Drawing.Size(43, 13);
            this.label_Periode.TabIndex = 17;
            this.label_Periode.Text = "Période";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Enabled = false;
            this.monthCalendar.Location = new System.Drawing.Point(659, 231);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 18;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // groupBoxLundi
            // 
            this.groupBoxLundi.Controls.Add(this.radioButtonAucunLundi);
            this.groupBoxLundi.Controls.Add(this.radioButtonRepasFroidLundi);
            this.groupBoxLundi.Controls.Add(this.radioButtonRepasChaud2Lundi);
            this.groupBoxLundi.Controls.Add(this.radioButtonRepasChaud1Lundi);
            this.groupBoxLundi.Location = new System.Drawing.Point(202, 405);
            this.groupBoxLundi.Name = "groupBoxLundi";
            this.groupBoxLundi.Size = new System.Drawing.Size(127, 139);
            this.groupBoxLundi.TabIndex = 19;
            this.groupBoxLundi.TabStop = false;
            this.groupBoxLundi.Text = "Lundi";
            // 
            // radioButtonAucunLundi
            // 
            this.radioButtonAucunLundi.AutoSize = true;
            this.radioButtonAucunLundi.Checked = true;
            this.radioButtonAucunLundi.Location = new System.Drawing.Point(7, 108);
            this.radioButtonAucunLundi.Name = "radioButtonAucunLundi";
            this.radioButtonAucunLundi.Size = new System.Drawing.Size(56, 17);
            this.radioButtonAucunLundi.TabIndex = 3;
            this.radioButtonAucunLundi.TabStop = true;
            this.radioButtonAucunLundi.Text = "Aucun";
            this.radioButtonAucunLundi.UseVisualStyleBackColor = true;
            this.radioButtonAucunLundi.CheckedChanged += new System.EventHandler(this.radioButtonAucunLundi_CheckedChanged);
            // 
            // radioButtonRepasFroidLundi
            // 
            this.radioButtonRepasFroidLundi.AutoSize = true;
            this.radioButtonRepasFroidLundi.Location = new System.Drawing.Point(7, 85);
            this.radioButtonRepasFroidLundi.Name = "radioButtonRepasFroidLundi";
            this.radioButtonRepasFroidLundi.Size = new System.Drawing.Size(82, 17);
            this.radioButtonRepasFroidLundi.TabIndex = 2;
            this.radioButtonRepasFroidLundi.Text = "Repas Froid";
            this.radioButtonRepasFroidLundi.UseVisualStyleBackColor = true;
            this.radioButtonRepasFroidLundi.CheckedChanged += new System.EventHandler(this.radioButtonRepasFroidLundi_CheckedChanged);
            // 
            // radioButtonRepasChaud2Lundi
            // 
            this.radioButtonRepasChaud2Lundi.AutoSize = true;
            this.radioButtonRepasChaud2Lundi.Location = new System.Drawing.Point(7, 62);
            this.radioButtonRepasChaud2Lundi.Name = "radioButtonRepasChaud2Lundi";
            this.radioButtonRepasChaud2Lundi.Size = new System.Drawing.Size(99, 17);
            this.radioButtonRepasChaud2Lundi.TabIndex = 1;
            this.radioButtonRepasChaud2Lundi.Text = "Repas Chaud 2";
            this.radioButtonRepasChaud2Lundi.UseVisualStyleBackColor = true;
            this.radioButtonRepasChaud2Lundi.CheckedChanged += new System.EventHandler(this.radioButtonRepasChaud2Lundi_CheckedChanged);
            // 
            // radioButtonRepasChaud1Lundi
            // 
            this.radioButtonRepasChaud1Lundi.AutoSize = true;
            this.radioButtonRepasChaud1Lundi.Location = new System.Drawing.Point(7, 39);
            this.radioButtonRepasChaud1Lundi.Name = "radioButtonRepasChaud1Lundi";
            this.radioButtonRepasChaud1Lundi.Size = new System.Drawing.Size(99, 17);
            this.radioButtonRepasChaud1Lundi.TabIndex = 0;
            this.radioButtonRepasChaud1Lundi.Tag = "";
            this.radioButtonRepasChaud1Lundi.Text = "Repas Chaud 1";
            this.radioButtonRepasChaud1Lundi.UseVisualStyleBackColor = true;
            this.radioButtonRepasChaud1Lundi.CheckedChanged += new System.EventHandler(this.radioButtonRepasChaud1Lundi_CheckedChanged);
            // 
            // groupBoxMardi
            // 
            this.groupBoxMardi.Controls.Add(this.radioButtonAucunMardi);
            this.groupBoxMardi.Controls.Add(this.radioButtonRepasFroidMardi);
            this.groupBoxMardi.Controls.Add(this.radioButtonRepasChaud2Mardi);
            this.groupBoxMardi.Controls.Add(this.radioButtonRepasChaud1Mardi);
            this.groupBoxMardi.Location = new System.Drawing.Point(335, 405);
            this.groupBoxMardi.Name = "groupBoxMardi";
            this.groupBoxMardi.Size = new System.Drawing.Size(127, 139);
            this.groupBoxMardi.TabIndex = 19;
            this.groupBoxMardi.TabStop = false;
            this.groupBoxMardi.Text = "Mardi";
            // 
            // radioButtonAucunMardi
            // 
            this.radioButtonAucunMardi.AutoSize = true;
            this.radioButtonAucunMardi.Checked = true;
            this.radioButtonAucunMardi.Location = new System.Drawing.Point(7, 108);
            this.radioButtonAucunMardi.Name = "radioButtonAucunMardi";
            this.radioButtonAucunMardi.Size = new System.Drawing.Size(56, 17);
            this.radioButtonAucunMardi.TabIndex = 3;
            this.radioButtonAucunMardi.TabStop = true;
            this.radioButtonAucunMardi.Text = "Aucun";
            this.radioButtonAucunMardi.UseVisualStyleBackColor = true;
            this.radioButtonAucunMardi.CheckedChanged += new System.EventHandler(this.radioButtonAucunMardi_CheckedChanged);
            // 
            // radioButtonRepasFroidMardi
            // 
            this.radioButtonRepasFroidMardi.AutoSize = true;
            this.radioButtonRepasFroidMardi.Location = new System.Drawing.Point(7, 85);
            this.radioButtonRepasFroidMardi.Name = "radioButtonRepasFroidMardi";
            this.radioButtonRepasFroidMardi.Size = new System.Drawing.Size(82, 17);
            this.radioButtonRepasFroidMardi.TabIndex = 2;
            this.radioButtonRepasFroidMardi.Text = "Repas Froid";
            this.radioButtonRepasFroidMardi.UseVisualStyleBackColor = true;
            this.radioButtonRepasFroidMardi.CheckedChanged += new System.EventHandler(this.radioButtonRepasFroidMardi_CheckedChanged);
            // 
            // radioButtonRepasChaud2Mardi
            // 
            this.radioButtonRepasChaud2Mardi.AutoSize = true;
            this.radioButtonRepasChaud2Mardi.Location = new System.Drawing.Point(7, 62);
            this.radioButtonRepasChaud2Mardi.Name = "radioButtonRepasChaud2Mardi";
            this.radioButtonRepasChaud2Mardi.Size = new System.Drawing.Size(99, 17);
            this.radioButtonRepasChaud2Mardi.TabIndex = 1;
            this.radioButtonRepasChaud2Mardi.Text = "Repas Chaud 2";
            this.radioButtonRepasChaud2Mardi.UseVisualStyleBackColor = true;
            this.radioButtonRepasChaud2Mardi.CheckedChanged += new System.EventHandler(this.radioButtonRepasChaud2Mardi_CheckedChanged);
            // 
            // radioButtonRepasChaud1Mardi
            // 
            this.radioButtonRepasChaud1Mardi.AutoSize = true;
            this.radioButtonRepasChaud1Mardi.Location = new System.Drawing.Point(7, 39);
            this.radioButtonRepasChaud1Mardi.Name = "radioButtonRepasChaud1Mardi";
            this.radioButtonRepasChaud1Mardi.Size = new System.Drawing.Size(99, 17);
            this.radioButtonRepasChaud1Mardi.TabIndex = 0;
            this.radioButtonRepasChaud1Mardi.Text = "Repas Chaud 1";
            this.radioButtonRepasChaud1Mardi.UseVisualStyleBackColor = true;
            this.radioButtonRepasChaud1Mardi.CheckedChanged += new System.EventHandler(this.radioButtonRepasChaud1Mardi_CheckedChanged);
            // 
            // groupBoxMercredi
            // 
            this.groupBoxMercredi.Controls.Add(this.radioButtonAucunMercredi);
            this.groupBoxMercredi.Controls.Add(this.radioButtonRepasFroidMercredi);
            this.groupBoxMercredi.Controls.Add(this.radioButtonRepasChaud2Mercredi);
            this.groupBoxMercredi.Controls.Add(this.radioButtonRepasChaud1Mercredi);
            this.groupBoxMercredi.Location = new System.Drawing.Point(468, 405);
            this.groupBoxMercredi.Name = "groupBoxMercredi";
            this.groupBoxMercredi.Size = new System.Drawing.Size(127, 139);
            this.groupBoxMercredi.TabIndex = 19;
            this.groupBoxMercredi.TabStop = false;
            this.groupBoxMercredi.Text = "Mercredi";
            // 
            // radioButtonAucunMercredi
            // 
            this.radioButtonAucunMercredi.AutoSize = true;
            this.radioButtonAucunMercredi.Checked = true;
            this.radioButtonAucunMercredi.Location = new System.Drawing.Point(7, 108);
            this.radioButtonAucunMercredi.Name = "radioButtonAucunMercredi";
            this.radioButtonAucunMercredi.Size = new System.Drawing.Size(56, 17);
            this.radioButtonAucunMercredi.TabIndex = 3;
            this.radioButtonAucunMercredi.TabStop = true;
            this.radioButtonAucunMercredi.Text = "Aucun";
            this.radioButtonAucunMercredi.UseVisualStyleBackColor = true;
            this.radioButtonAucunMercredi.CheckedChanged += new System.EventHandler(this.radioButtonAucunMercredi_CheckedChanged);
            // 
            // radioButtonRepasFroidMercredi
            // 
            this.radioButtonRepasFroidMercredi.AutoSize = true;
            this.radioButtonRepasFroidMercredi.Location = new System.Drawing.Point(7, 85);
            this.radioButtonRepasFroidMercredi.Name = "radioButtonRepasFroidMercredi";
            this.radioButtonRepasFroidMercredi.Size = new System.Drawing.Size(82, 17);
            this.radioButtonRepasFroidMercredi.TabIndex = 2;
            this.radioButtonRepasFroidMercredi.Text = "Repas Froid";
            this.radioButtonRepasFroidMercredi.UseVisualStyleBackColor = true;
            this.radioButtonRepasFroidMercredi.CheckedChanged += new System.EventHandler(this.radioButtonRepasFroidMercredi_CheckedChanged);
            // 
            // radioButtonRepasChaud2Mercredi
            // 
            this.radioButtonRepasChaud2Mercredi.AutoSize = true;
            this.radioButtonRepasChaud2Mercredi.Location = new System.Drawing.Point(7, 62);
            this.radioButtonRepasChaud2Mercredi.Name = "radioButtonRepasChaud2Mercredi";
            this.radioButtonRepasChaud2Mercredi.Size = new System.Drawing.Size(99, 17);
            this.radioButtonRepasChaud2Mercredi.TabIndex = 1;
            this.radioButtonRepasChaud2Mercredi.Text = "Repas Chaud 2";
            this.radioButtonRepasChaud2Mercredi.UseVisualStyleBackColor = true;
            this.radioButtonRepasChaud2Mercredi.CheckedChanged += new System.EventHandler(this.radioButtonRepasChaud2Mercredi_CheckedChanged);
            // 
            // radioButtonRepasChaud1Mercredi
            // 
            this.radioButtonRepasChaud1Mercredi.AutoSize = true;
            this.radioButtonRepasChaud1Mercredi.Location = new System.Drawing.Point(7, 39);
            this.radioButtonRepasChaud1Mercredi.Name = "radioButtonRepasChaud1Mercredi";
            this.radioButtonRepasChaud1Mercredi.Size = new System.Drawing.Size(99, 17);
            this.radioButtonRepasChaud1Mercredi.TabIndex = 0;
            this.radioButtonRepasChaud1Mercredi.Text = "Repas Chaud 1";
            this.radioButtonRepasChaud1Mercredi.UseVisualStyleBackColor = true;
            this.radioButtonRepasChaud1Mercredi.CheckedChanged += new System.EventHandler(this.radioButtonRepasChaud1Mercredi_CheckedChanged);
            // 
            // groupBoxJeudi
            // 
            this.groupBoxJeudi.Controls.Add(this.radioButtonAucunJeudi);
            this.groupBoxJeudi.Controls.Add(this.radioButtonRepasFroidJeudi);
            this.groupBoxJeudi.Controls.Add(this.radioButtonRepasChaud2Jeudi);
            this.groupBoxJeudi.Controls.Add(this.radioButtonRepasChaud1Jeudi);
            this.groupBoxJeudi.Location = new System.Drawing.Point(601, 405);
            this.groupBoxJeudi.Name = "groupBoxJeudi";
            this.groupBoxJeudi.Size = new System.Drawing.Size(127, 139);
            this.groupBoxJeudi.TabIndex = 19;
            this.groupBoxJeudi.TabStop = false;
            this.groupBoxJeudi.Text = "Jeudi";
            // 
            // radioButtonAucunJeudi
            // 
            this.radioButtonAucunJeudi.AutoSize = true;
            this.radioButtonAucunJeudi.Checked = true;
            this.radioButtonAucunJeudi.Location = new System.Drawing.Point(7, 108);
            this.radioButtonAucunJeudi.Name = "radioButtonAucunJeudi";
            this.radioButtonAucunJeudi.Size = new System.Drawing.Size(56, 17);
            this.radioButtonAucunJeudi.TabIndex = 3;
            this.radioButtonAucunJeudi.TabStop = true;
            this.radioButtonAucunJeudi.Text = "Aucun";
            this.radioButtonAucunJeudi.UseVisualStyleBackColor = true;
            this.radioButtonAucunJeudi.CheckedChanged += new System.EventHandler(this.radioButtonAucunJeudi_CheckedChanged);
            // 
            // radioButtonRepasFroidJeudi
            // 
            this.radioButtonRepasFroidJeudi.AutoSize = true;
            this.radioButtonRepasFroidJeudi.Location = new System.Drawing.Point(7, 85);
            this.radioButtonRepasFroidJeudi.Name = "radioButtonRepasFroidJeudi";
            this.radioButtonRepasFroidJeudi.Size = new System.Drawing.Size(82, 17);
            this.radioButtonRepasFroidJeudi.TabIndex = 2;
            this.radioButtonRepasFroidJeudi.Text = "Repas Froid";
            this.radioButtonRepasFroidJeudi.UseVisualStyleBackColor = true;
            this.radioButtonRepasFroidJeudi.CheckedChanged += new System.EventHandler(this.radioButtonRepasFroidJeudi_CheckedChanged);
            // 
            // radioButtonRepasChaud2Jeudi
            // 
            this.radioButtonRepasChaud2Jeudi.AutoSize = true;
            this.radioButtonRepasChaud2Jeudi.Location = new System.Drawing.Point(7, 62);
            this.radioButtonRepasChaud2Jeudi.Name = "radioButtonRepasChaud2Jeudi";
            this.radioButtonRepasChaud2Jeudi.Size = new System.Drawing.Size(99, 17);
            this.radioButtonRepasChaud2Jeudi.TabIndex = 1;
            this.radioButtonRepasChaud2Jeudi.Text = "Repas Chaud 2";
            this.radioButtonRepasChaud2Jeudi.UseVisualStyleBackColor = true;
            this.radioButtonRepasChaud2Jeudi.CheckedChanged += new System.EventHandler(this.radioButtonRepasChaud2Jeudi_CheckedChanged);
            // 
            // radioButtonRepasChaud1Jeudi
            // 
            this.radioButtonRepasChaud1Jeudi.AutoSize = true;
            this.radioButtonRepasChaud1Jeudi.Location = new System.Drawing.Point(7, 39);
            this.radioButtonRepasChaud1Jeudi.Name = "radioButtonRepasChaud1Jeudi";
            this.radioButtonRepasChaud1Jeudi.Size = new System.Drawing.Size(99, 17);
            this.radioButtonRepasChaud1Jeudi.TabIndex = 0;
            this.radioButtonRepasChaud1Jeudi.Text = "Repas Chaud 1";
            this.radioButtonRepasChaud1Jeudi.UseVisualStyleBackColor = true;
            this.radioButtonRepasChaud1Jeudi.CheckedChanged += new System.EventHandler(this.radioButtonRepasChaud1Jeudi_CheckedChanged);
            // 
            // groupBoxVendredi
            // 
            this.groupBoxVendredi.Controls.Add(this.radioButtonAucunVendredi);
            this.groupBoxVendredi.Controls.Add(this.radioButtonRepasFroidVendredi);
            this.groupBoxVendredi.Controls.Add(this.radioButtonRepasChaud2Vendredi);
            this.groupBoxVendredi.Controls.Add(this.radioButtonRepasChaud1Vendredi);
            this.groupBoxVendredi.Location = new System.Drawing.Point(734, 405);
            this.groupBoxVendredi.Name = "groupBoxVendredi";
            this.groupBoxVendredi.Size = new System.Drawing.Size(127, 139);
            this.groupBoxVendredi.TabIndex = 19;
            this.groupBoxVendredi.TabStop = false;
            this.groupBoxVendredi.Text = "Vendredi";
            // 
            // radioButtonAucunVendredi
            // 
            this.radioButtonAucunVendredi.AutoSize = true;
            this.radioButtonAucunVendredi.Checked = true;
            this.radioButtonAucunVendredi.Location = new System.Drawing.Point(7, 108);
            this.radioButtonAucunVendredi.Name = "radioButtonAucunVendredi";
            this.radioButtonAucunVendredi.Size = new System.Drawing.Size(56, 17);
            this.radioButtonAucunVendredi.TabIndex = 3;
            this.radioButtonAucunVendredi.TabStop = true;
            this.radioButtonAucunVendredi.Text = "Aucun";
            this.radioButtonAucunVendredi.UseVisualStyleBackColor = true;
            this.radioButtonAucunVendredi.CheckedChanged += new System.EventHandler(this.radioButtonAucunVendredi_CheckedChanged);
            // 
            // radioButtonRepasFroidVendredi
            // 
            this.radioButtonRepasFroidVendredi.AutoSize = true;
            this.radioButtonRepasFroidVendredi.Location = new System.Drawing.Point(7, 85);
            this.radioButtonRepasFroidVendredi.Name = "radioButtonRepasFroidVendredi";
            this.radioButtonRepasFroidVendredi.Size = new System.Drawing.Size(82, 17);
            this.radioButtonRepasFroidVendredi.TabIndex = 2;
            this.radioButtonRepasFroidVendredi.Text = "Repas Froid";
            this.radioButtonRepasFroidVendredi.UseVisualStyleBackColor = true;
            this.radioButtonRepasFroidVendredi.CheckedChanged += new System.EventHandler(this.radioButtonRepasFroidVendredi_CheckedChanged);
            // 
            // radioButtonRepasChaud2Vendredi
            // 
            this.radioButtonRepasChaud2Vendredi.AutoSize = true;
            this.radioButtonRepasChaud2Vendredi.Location = new System.Drawing.Point(7, 62);
            this.radioButtonRepasChaud2Vendredi.Name = "radioButtonRepasChaud2Vendredi";
            this.radioButtonRepasChaud2Vendredi.Size = new System.Drawing.Size(99, 17);
            this.radioButtonRepasChaud2Vendredi.TabIndex = 1;
            this.radioButtonRepasChaud2Vendredi.Text = "Repas Chaud 2";
            this.radioButtonRepasChaud2Vendredi.UseVisualStyleBackColor = true;
            this.radioButtonRepasChaud2Vendredi.CheckedChanged += new System.EventHandler(this.radioButtonRepasChaud2Vendredi_CheckedChanged);
            // 
            // radioButtonRepasChaud1Vendredi
            // 
            this.radioButtonRepasChaud1Vendredi.AutoSize = true;
            this.radioButtonRepasChaud1Vendredi.Location = new System.Drawing.Point(7, 39);
            this.radioButtonRepasChaud1Vendredi.Name = "radioButtonRepasChaud1Vendredi";
            this.radioButtonRepasChaud1Vendredi.Size = new System.Drawing.Size(99, 17);
            this.radioButtonRepasChaud1Vendredi.TabIndex = 0;
            this.radioButtonRepasChaud1Vendredi.Text = "Repas Chaud 1";
            this.radioButtonRepasChaud1Vendredi.UseVisualStyleBackColor = true;
            this.radioButtonRepasChaud1Vendredi.CheckedChanged += new System.EventHandler(this.radioButtonRepasChaud1Vendredi_CheckedChanged);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(764, 596);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(200, 35);
            this.btAnnuler.TabIndex = 24;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // btConfirmation
            // 
            this.btConfirmation.Location = new System.Drawing.Point(439, 596);
            this.btConfirmation.Name = "btConfirmation";
            this.btConfirmation.Size = new System.Drawing.Size(200, 35);
            this.btConfirmation.TabIndex = 25;
            this.btConfirmation.Text = "Confirmation/Modification";
            this.btConfirmation.UseVisualStyleBackColor = true;
            this.btConfirmation.Click += new System.EventHandler(this.btConfirmation_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.Location = new System.Drawing.Point(104, 596);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(200, 35);
            this.btSupprimer.TabIndex = 26;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            // 
            // tA_Listes_Personnes_query
            // 
            this.tA_Listes_Personnes_query.ClearBeforeFill = true;
            // 
            // groupBoxPeriode
            // 
            this.groupBoxPeriode.Controls.Add(this.label1);
            this.groupBoxPeriode.Controls.Add(this.labelFin);
            this.groupBoxPeriode.Controls.Add(this.labelDebut);
            this.groupBoxPeriode.Controls.Add(this.lbDebut);
            this.groupBoxPeriode.Location = new System.Drawing.Point(13, 405);
            this.groupBoxPeriode.Name = "groupBoxPeriode";
            this.groupBoxPeriode.Size = new System.Drawing.Size(173, 139);
            this.groupBoxPeriode.TabIndex = 27;
            this.groupBoxPeriode.TabStop = false;
            this.groupBoxPeriode.Text = "Période";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Au Vendredi :";
            // 
            // labelFin
            // 
            this.labelFin.AutoSize = true;
            this.labelFin.Location = new System.Drawing.Point(72, 108);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(0, 13);
            this.labelFin.TabIndex = 0;
            // 
            // labelDebut
            // 
            this.labelDebut.AutoSize = true;
            this.labelDebut.Location = new System.Drawing.Point(72, 62);
            this.labelDebut.Name = "labelDebut";
            this.labelDebut.Size = new System.Drawing.Size(0, 13);
            this.labelDebut.TabIndex = 0;
            // 
            // lbDebut
            // 
            this.lbDebut.AutoSize = true;
            this.lbDebut.Location = new System.Drawing.Point(6, 39);
            this.lbDebut.Name = "lbDebut";
            this.lbDebut.Size = new System.Drawing.Size(56, 13);
            this.lbDebut.TabIndex = 0;
            this.lbDebut.Text = "Du Lundi :";
            // 
            // labelEtat
            // 
            this.labelEtat.AutoSize = true;
            this.labelEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEtat.Location = new System.Drawing.Point(19, 547);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(296, 20);
            this.labelEtat.TabIndex = 28;
            this.labelEtat.Text = "Aucun encodage pour cette période";
            this.labelEtat.Visible = false;
            // 
            // Form_EncodageRepas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.ControlBox = false;
            this.Controls.Add(this.labelEtat);
            this.Controls.Add(this.groupBoxPeriode);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btConfirmation);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.groupBoxVendredi);
            this.Controls.Add(this.groupBoxJeudi);
            this.Controls.Add(this.groupBoxMercredi);
            this.Controls.Add(this.groupBoxMardi);
            this.Controls.Add(this.groupBoxLundi);
            this.Controls.Add(this.monthCalendar);
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
            this.Controls.Add(this.txtBx_RechNom);
            this.Controls.Add(this.label_RechNom);
            this.Name = "Form_EncodageRepas";
            this.Text = "Encodage des repas par l\'élève";
            this.Load += new System.EventHandler(this.Form_EncodageRepas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGdVw_DetailEleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAListesPersonnesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet)).EndInit();
            this.groupBoxLundi.ResumeLayout(false);
            this.groupBoxLundi.PerformLayout();
            this.groupBoxMardi.ResumeLayout(false);
            this.groupBoxMardi.PerformLayout();
            this.groupBoxMercredi.ResumeLayout(false);
            this.groupBoxMercredi.PerformLayout();
            this.groupBoxJeudi.ResumeLayout(false);
            this.groupBoxJeudi.PerformLayout();
            this.groupBoxVendredi.ResumeLayout(false);
            this.groupBoxVendredi.PerformLayout();
            this.groupBoxPeriode.ResumeLayout(false);
            this.groupBoxPeriode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_RechNom;
        private System.Windows.Forms.TextBox txtBx_RechNom;
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
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private Models.db_cantineDataSet db_cantineDataSet;
        private System.Windows.Forms.BindingSource tAListesPersonnesBindingSource;
        private Models.db_cantineDataSetTableAdapters.TA_Listes_Personnes_query tA_Listes_Personnes_query;
        private System.Windows.Forms.GroupBox groupBoxLundi;
        private System.Windows.Forms.RadioButton radioButtonAucunLundi;
        private System.Windows.Forms.RadioButton radioButtonRepasFroidLundi;
        private System.Windows.Forms.RadioButton radioButtonRepasChaud2Lundi;
        private System.Windows.Forms.RadioButton radioButtonRepasChaud1Lundi;
        private System.Windows.Forms.GroupBox groupBoxMardi;
        private System.Windows.Forms.RadioButton radioButtonAucunMardi;
        private System.Windows.Forms.RadioButton radioButtonRepasFroidMardi;
        private System.Windows.Forms.RadioButton radioButtonRepasChaud2Mardi;
        private System.Windows.Forms.RadioButton radioButtonRepasChaud1Mardi;
        private System.Windows.Forms.GroupBox groupBoxMercredi;
        private System.Windows.Forms.RadioButton radioButtonAucunMercredi;
        private System.Windows.Forms.RadioButton radioButtonRepasFroidMercredi;
        private System.Windows.Forms.RadioButton radioButtonRepasChaud2Mercredi;
        private System.Windows.Forms.RadioButton radioButtonRepasChaud1Mercredi;
        private System.Windows.Forms.GroupBox groupBoxJeudi;
        private System.Windows.Forms.RadioButton radioButtonAucunJeudi;
        private System.Windows.Forms.RadioButton radioButtonRepasFroidJeudi;
        private System.Windows.Forms.RadioButton radioButtonRepasChaud2Jeudi;
        private System.Windows.Forms.RadioButton radioButtonRepasChaud1Jeudi;
        private System.Windows.Forms.GroupBox groupBoxVendredi;
        private System.Windows.Forms.RadioButton radioButtonAucunVendredi;
        private System.Windows.Forms.RadioButton radioButtonRepasFroidVendredi;
        private System.Windows.Forms.RadioButton radioButtonRepasChaud2Vendredi;
        private System.Windows.Forms.RadioButton radioButtonRepasChaud1Vendredi;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btConfirmation;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paysDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxPeriode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFin;
        private System.Windows.Forms.Label labelDebut;
        private System.Windows.Forms.Label lbDebut;
        private System.Windows.Forms.Label labelEtat;
    }
}