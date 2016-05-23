﻿namespace ProjetCantine.Vues
{
    partial class Form_EncodageFactures
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
            this.txtBx_RechNumTel = new System.Windows.Forms.TextBox();
            this.txtBx_RechNom = new System.Windows.Forms.TextBox();
            this.label_RechNumTel = new System.Windows.Forms.Label();
            this.dGdVw_DetailFamille = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numéroDeTéléphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAListesPersonnesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_cantineDataSet = new ProjetCantine.Models.db_cantineDataSet();
            this.dataGridView_Membres = new System.Windows.Forms.DataGridView();
            this.tblhistoriquefactureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tARemplirCBFormatEnvoieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabDetail = new System.Windows.Forms.TabControl();
            this.btApercu = new System.Windows.Forms.Button();
            this.btEnvoi = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.tA_Listes_Personnes_query = new ProjetCantine.Models.db_cantineDataSetTableAdapters.TA_Listes_Personnes_query();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tA_Remplir_CB_FormatEnvoieTableAdapter = new ProjetCantine.Models.db_cantineDataSetTableAdapters.TA_Remplir_CB_FormatEnvoieTableAdapter();
            this.dateTimePicker_debut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_recap = new System.Windows.Forms.GroupBox();
            this.label_Total_Aucun = new System.Windows.Forms.Label();
            this.label_Total_Froid = new System.Windows.Forms.Label();
            this.label_Total_Chaud2 = new System.Windows.Forms.Label();
            this.label_Total_Chaud1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_prix = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_aucun = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_froid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_chaud2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_chaud1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_dateCloture = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1_selectperiode = new System.Windows.Forms.GroupBox();
            this.button_visualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGdVw_DetailFamille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAListesPersonnesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Membres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblhistoriquefactureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tARemplirCBFormatEnvoieBindingSource)).BeginInit();
            this.groupBox_recap.SuspendLayout();
            this.groupBox1_selectperiode.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_RechNom
            // 
            this.label_RechNom.AutoSize = true;
            this.label_RechNom.Location = new System.Drawing.Point(16, 24);
            this.label_RechNom.Name = "label_RechNom";
            this.label_RechNom.Size = new System.Drawing.Size(101, 13);
            this.label_RechNom.TabIndex = 1;
            this.label_RechNom.Text = "Recherche par nom";
            // 
            // txtBx_RechNumTel
            // 
            this.txtBx_RechNumTel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBx_RechNumTel.Location = new System.Drawing.Point(558, 21);
            this.txtBx_RechNumTel.Name = "txtBx_RechNumTel";
            this.txtBx_RechNumTel.Size = new System.Drawing.Size(226, 20);
            this.txtBx_RechNumTel.TabIndex = 8;
            this.txtBx_RechNumTel.TextChanged += new System.EventHandler(this.filtre);
            // 
            // txtBx_RechNom
            // 
            this.txtBx_RechNom.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBx_RechNom.Location = new System.Drawing.Point(134, 21);
            this.txtBx_RechNom.Name = "txtBx_RechNom";
            this.txtBx_RechNom.Size = new System.Drawing.Size(226, 20);
            this.txtBx_RechNom.TabIndex = 4;
            this.txtBx_RechNom.TextChanged += new System.EventHandler(this.filtre);
            // 
            // label_RechNumTel
            // 
            this.label_RechNumTel.AutoSize = true;
            this.label_RechNumTel.Location = new System.Drawing.Point(380, 24);
            this.label_RechNumTel.Name = "label_RechNumTel";
            this.label_RechNumTel.Size = new System.Drawing.Size(172, 13);
            this.label_RechNumTel.TabIndex = 4;
            this.label_RechNumTel.Text = "Recherche par Numéro Téléphone";
            // 
            // dGdVw_DetailFamille
            // 
            this.dGdVw_DetailFamille.AllowUserToAddRows = false;
            this.dGdVw_DetailFamille.AllowUserToDeleteRows = false;
            this.dGdVw_DetailFamille.AutoGenerateColumns = false;
            this.dGdVw_DetailFamille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGdVw_DetailFamille.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nomDataGridViewTextBoxColumn1,
            this.prénomDataGridViewTextBoxColumn1,
            this.numéroDeTéléphoneDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.paysDataGridViewTextBoxColumn});
            this.dGdVw_DetailFamille.DataSource = this.tAListesPersonnesBindingSource;
            this.dGdVw_DetailFamille.Location = new System.Drawing.Point(12, 56);
            this.dGdVw_DetailFamille.MultiSelect = false;
            this.dGdVw_DetailFamille.Name = "dGdVw_DetailFamille";
            this.dGdVw_DetailFamille.ReadOnly = true;
            this.dGdVw_DetailFamille.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGdVw_DetailFamille.Size = new System.Drawing.Size(537, 161);
            this.dGdVw_DetailFamille.TabIndex = 12;
            this.dGdVw_DetailFamille.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGdVw_DetailFamille_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn1
            // 
            this.nomDataGridViewTextBoxColumn1.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn1.Name = "nomDataGridViewTextBoxColumn1";
            this.nomDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prénomDataGridViewTextBoxColumn1
            // 
            this.prénomDataGridViewTextBoxColumn1.DataPropertyName = "Prénom";
            this.prénomDataGridViewTextBoxColumn1.HeaderText = "Prénom";
            this.prénomDataGridViewTextBoxColumn1.Name = "prénomDataGridViewTextBoxColumn1";
            this.prénomDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numéroDeTéléphoneDataGridViewTextBoxColumn
            // 
            this.numéroDeTéléphoneDataGridViewTextBoxColumn.DataPropertyName = "Numéro de Téléphone";
            this.numéroDeTéléphoneDataGridViewTextBoxColumn.HeaderText = "Numéro de Téléphone";
            this.numéroDeTéléphoneDataGridViewTextBoxColumn.Name = "numéroDeTéléphoneDataGridViewTextBoxColumn";
            this.numéroDeTéléphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dataGridView_Membres
            // 
            this.dataGridView_Membres.AllowUserToAddRows = false;
            this.dataGridView_Membres.AllowUserToDeleteRows = false;
            this.dataGridView_Membres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Membres.Location = new System.Drawing.Point(559, 56);
            this.dataGridView_Membres.MultiSelect = false;
            this.dataGridView_Membres.Name = "dataGridView_Membres";
            this.dataGridView_Membres.ReadOnly = true;
            this.dataGridView_Membres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Membres.Size = new System.Drawing.Size(332, 161);
            this.dataGridView_Membres.TabIndex = 16;
            // 
            // tARemplirCBFormatEnvoieBindingSource
            // 
            this.tARemplirCBFormatEnvoieBindingSource.DataMember = "TA_Remplir_CB_FormatEnvoie";
            this.tARemplirCBFormatEnvoieBindingSource.DataSource = this.db_cantineDataSet;
            // 
            // tabDetail
            // 
            this.tabDetail.Location = new System.Drawing.Point(12, 284);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.SelectedIndex = 0;
            this.tabDetail.Size = new System.Drawing.Size(417, 215);
            this.tabDetail.TabIndex = 22;
            // 
            // btApercu
            // 
            this.btApercu.Enabled = false;
            this.btApercu.Location = new System.Drawing.Point(110, 583);
            this.btApercu.Name = "btApercu";
            this.btApercu.Size = new System.Drawing.Size(200, 35);
            this.btApercu.TabIndex = 23;
            this.btApercu.Text = "Aperçu";
            this.btApercu.UseVisualStyleBackColor = true;
            this.btApercu.Click += new System.EventHandler(this.btApercu_Click);
            // 
            // btEnvoi
            // 
            this.btEnvoi.Enabled = false;
            this.btEnvoi.Location = new System.Drawing.Point(445, 583);
            this.btEnvoi.Name = "btEnvoi";
            this.btEnvoi.Size = new System.Drawing.Size(200, 35);
            this.btEnvoi.TabIndex = 23;
            this.btEnvoi.Text = "Envoi";
            this.btEnvoi.UseVisualStyleBackColor = true;
            this.btEnvoi.Click += new System.EventHandler(this.btEnvoi_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(770, 583);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(200, 35);
            this.btAnnuler.TabIndex = 23;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // tA_Listes_Personnes_query
            // 
            this.tA_Listes_Personnes_query.ClearBeforeFill = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prénomDataGridViewTextBoxColumn
            // 
            this.prénomDataGridViewTextBoxColumn.DataPropertyName = "Prénom";
            this.prénomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prénomDataGridViewTextBoxColumn.Name = "prénomDataGridViewTextBoxColumn";
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prénom
            // 
            this.Prénom.DataPropertyName = "Prénom";
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.Name = "Prénom";
            // 
            // tA_Remplir_CB_FormatEnvoieTableAdapter
            // 
            this.tA_Remplir_CB_FormatEnvoieTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker_debut
            // 
            this.dateTimePicker_debut.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_debut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_debut.Location = new System.Drawing.Point(19, 121);
            this.dateTimePicker_debut.Name = "dateTimePicker_debut";
            this.dateTimePicker_debut.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker_debut.TabIndex = 24;
            this.dateTimePicker_debut.ValueChanged += new System.EventHandler(this.dateTimePicker_debut_ValueChanged);
            // 
            // dateTimePicker_fin
            // 
            this.dateTimePicker_fin.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_fin.Location = new System.Drawing.Point(18, 167);
            this.dateTimePicker_fin.Name = "dateTimePicker_fin";
            this.dateTimePicker_fin.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker_fin.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Du :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Au :";
            // 
            // groupBox_recap
            // 
            this.groupBox_recap.Controls.Add(this.label_Total_Aucun);
            this.groupBox_recap.Controls.Add(this.label_Total_Froid);
            this.groupBox_recap.Controls.Add(this.label_Total_Chaud2);
            this.groupBox_recap.Controls.Add(this.label_Total_Chaud1);
            this.groupBox_recap.Controls.Add(this.label12);
            this.groupBox_recap.Controls.Add(this.label_prix);
            this.groupBox_recap.Controls.Add(this.label10);
            this.groupBox_recap.Controls.Add(this.label_aucun);
            this.groupBox_recap.Controls.Add(this.label8);
            this.groupBox_recap.Controls.Add(this.label_froid);
            this.groupBox_recap.Controls.Add(this.label6);
            this.groupBox_recap.Controls.Add(this.label_chaud2);
            this.groupBox_recap.Controls.Add(this.label4);
            this.groupBox_recap.Controls.Add(this.label_chaud1);
            this.groupBox_recap.Location = new System.Drawing.Point(435, 284);
            this.groupBox_recap.Name = "groupBox_recap";
            this.groupBox_recap.Size = new System.Drawing.Size(349, 215);
            this.groupBox_recap.TabIndex = 27;
            this.groupBox_recap.TabStop = false;
            this.groupBox_recap.Text = "Récap pour : ";
            // 
            // label_Total_Aucun
            // 
            this.label_Total_Aucun.AutoSize = true;
            this.label_Total_Aucun.Location = new System.Drawing.Point(228, 136);
            this.label_Total_Aucun.Name = "label_Total_Aucun";
            this.label_Total_Aucun.Size = new System.Drawing.Size(0, 13);
            this.label_Total_Aucun.TabIndex = 36;
            // 
            // label_Total_Froid
            // 
            this.label_Total_Froid.AutoSize = true;
            this.label_Total_Froid.Location = new System.Drawing.Point(228, 100);
            this.label_Total_Froid.Name = "label_Total_Froid";
            this.label_Total_Froid.Size = new System.Drawing.Size(0, 13);
            this.label_Total_Froid.TabIndex = 36;
            // 
            // label_Total_Chaud2
            // 
            this.label_Total_Chaud2.AutoSize = true;
            this.label_Total_Chaud2.Location = new System.Drawing.Point(228, 63);
            this.label_Total_Chaud2.Name = "label_Total_Chaud2";
            this.label_Total_Chaud2.Size = new System.Drawing.Size(0, 13);
            this.label_Total_Chaud2.TabIndex = 36;
            // 
            // label_Total_Chaud1
            // 
            this.label_Total_Chaud1.AutoSize = true;
            this.label_Total_Chaud1.Location = new System.Drawing.Point(228, 33);
            this.label_Total_Chaud1.Name = "label_Total_Chaud1";
            this.label_Total_Chaud1.Size = new System.Drawing.Size(0, 13);
            this.label_Total_Chaud1.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(146, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "PRIX TOTAL :";
            // 
            // label_prix
            // 
            this.label_prix.AutoSize = true;
            this.label_prix.Location = new System.Drawing.Point(283, 182);
            this.label_prix.Name = "label_prix";
            this.label_prix.Size = new System.Drawing.Size(0, 13);
            this.label_prix.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Aucun";
            // 
            // label_aucun
            // 
            this.label_aucun.AutoSize = true;
            this.label_aucun.Location = new System.Drawing.Point(126, 136);
            this.label_aucun.Name = "label_aucun";
            this.label_aucun.Size = new System.Drawing.Size(0, 13);
            this.label_aucun.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Repas Froid";
            // 
            // label_froid
            // 
            this.label_froid.AutoSize = true;
            this.label_froid.Location = new System.Drawing.Point(126, 100);
            this.label_froid.Name = "label_froid";
            this.label_froid.Size = new System.Drawing.Size(0, 13);
            this.label_froid.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Repas Chaud 2";
            // 
            // label_chaud2
            // 
            this.label_chaud2.AutoSize = true;
            this.label_chaud2.Location = new System.Drawing.Point(124, 63);
            this.label_chaud2.Name = "label_chaud2";
            this.label_chaud2.Size = new System.Drawing.Size(0, 13);
            this.label_chaud2.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Repas Chaud 1";
            // 
            // label_chaud1
            // 
            this.label_chaud1.AutoSize = true;
            this.label_chaud1.Location = new System.Drawing.Point(124, 33);
            this.label_chaud1.Name = "label_chaud1";
            this.label_chaud1.Size = new System.Drawing.Size(0, 13);
            this.label_chaud1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Dernière date de clôturation";
            // 
            // label_dateCloture
            // 
            this.label_dateCloture.AutoSize = true;
            this.label_dateCloture.Location = new System.Drawing.Point(16, 49);
            this.label_dateCloture.Name = "label_dateCloture";
            this.label_dateCloture.Size = new System.Drawing.Size(0, 13);
            this.label_dateCloture.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Générer Détails :";
            // 
            // groupBox1_selectperiode
            // 
            this.groupBox1_selectperiode.Controls.Add(this.button_visualiser);
            this.groupBox1_selectperiode.Controls.Add(this.label3);
            this.groupBox1_selectperiode.Controls.Add(this.dateTimePicker_debut);
            this.groupBox1_selectperiode.Controls.Add(this.label7);
            this.groupBox1_selectperiode.Controls.Add(this.dateTimePicker_fin);
            this.groupBox1_selectperiode.Controls.Add(this.label_dateCloture);
            this.groupBox1_selectperiode.Controls.Add(this.label1);
            this.groupBox1_selectperiode.Controls.Add(this.label2);
            this.groupBox1_selectperiode.Enabled = false;
            this.groupBox1_selectperiode.Location = new System.Drawing.Point(897, 24);
            this.groupBox1_selectperiode.Name = "groupBox1_selectperiode";
            this.groupBox1_selectperiode.Size = new System.Drawing.Size(183, 281);
            this.groupBox1_selectperiode.TabIndex = 32;
            this.groupBox1_selectperiode.TabStop = false;
            this.groupBox1_selectperiode.Text = "Selectionner periode";
            // 
            // button_visualiser
            // 
            this.button_visualiser.Location = new System.Drawing.Point(18, 217);
            this.button_visualiser.Name = "button_visualiser";
            this.button_visualiser.Size = new System.Drawing.Size(150, 32);
            this.button_visualiser.TabIndex = 32;
            this.button_visualiser.Text = "Visualiser détail";
            this.button_visualiser.UseVisualStyleBackColor = true;
            this.button_visualiser.Click += new System.EventHandler(this.button_visualiser_Click);
            // 
            // Form_EncodageFactures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1_selectperiode);
            this.Controls.Add(this.groupBox_recap);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btEnvoi);
            this.Controls.Add(this.btApercu);
            this.Controls.Add(this.tabDetail);
            this.Controls.Add(this.dataGridView_Membres);
            this.Controls.Add(this.dGdVw_DetailFamille);
            this.Controls.Add(this.txtBx_RechNumTel);
            this.Controls.Add(this.txtBx_RechNom);
            this.Controls.Add(this.label_RechNumTel);
            this.Controls.Add(this.label_RechNom);
            this.Name = "Form_EncodageFactures";
            this.Text = "Encodage des factures";
            this.Load += new System.EventHandler(this.Form_EncodageFactures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGdVw_DetailFamille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAListesPersonnesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Membres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblhistoriquefactureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tARemplirCBFormatEnvoieBindingSource)).EndInit();
            this.groupBox_recap.ResumeLayout(false);
            this.groupBox_recap.PerformLayout();
            this.groupBox1_selectperiode.ResumeLayout(false);
            this.groupBox1_selectperiode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_RechNom;
        private System.Windows.Forms.TextBox txtBx_RechNumTel;
        private System.Windows.Forms.TextBox txtBx_RechNom;
        private System.Windows.Forms.Label label_RechNumTel;
        private System.Windows.Forms.DataGridView dGdVw_DetailFamille;
        private System.Windows.Forms.DataGridView dataGridView_Membres;
        private System.Windows.Forms.TabControl tabDetail;
        private System.Windows.Forms.Button btApercu;
        private System.Windows.Forms.Button btEnvoi;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.BindingSource tblhistoriquefactureBindingSource;
        private Models.db_cantineDataSet db_cantineDataSet;
        private System.Windows.Forms.BindingSource tAListesPersonnesBindingSource;
        private Models.db_cantineDataSetTableAdapters.TA_Listes_Personnes_query tA_Listes_Personnes_query;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.BindingSource tARemplirCBFormatEnvoieBindingSource;
        private Models.db_cantineDataSetTableAdapters.TA_Remplir_CB_FormatEnvoieTableAdapter tA_Remplir_CB_FormatEnvoieTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker_debut;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_recap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_prix;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_aucun;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_froid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_chaud2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_chaud1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_dateCloture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numéroDeTéléphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paysDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1_selectperiode;
        private System.Windows.Forms.Button button_visualiser;
        private System.Windows.Forms.Label label_Total_Chaud1;
        private System.Windows.Forms.Label label_Total_Chaud2;
        private System.Windows.Forms.Label label_Total_Aucun;
        private System.Windows.Forms.Label label_Total_Froid;
    }
}