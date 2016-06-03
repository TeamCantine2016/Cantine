namespace ProjetCantine.Vues
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
            this.dgv_enfant_facturation = new System.Windows.Forms.DataGridView();
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
            this.lb_prixTotal = new System.Windows.Forms.Label();
            this.label_prix = new System.Windows.Forms.Label();
            this.lb_repasAucun = new System.Windows.Forms.Label();
            this.label_aucun = new System.Windows.Forms.Label();
            this.lb_repasFroid = new System.Windows.Forms.Label();
            this.label_froid = new System.Windows.Forms.Label();
            this.lb_repasChaud2 = new System.Windows.Forms.Label();
            this.label_chaud2 = new System.Windows.Forms.Label();
            this.lb_repasChaud1 = new System.Windows.Forms.Label();
            this.label_chaud1 = new System.Windows.Forms.Label();
            this.lb_dateCloture = new System.Windows.Forms.Label();
            this.label_dateCloture = new System.Windows.Forms.Label();
            this.lb_genererDetails = new System.Windows.Forms.Label();
            this.groupBox1_selectperiode = new System.Windows.Forms.GroupBox();
            this.button_visualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGdVw_DetailFamille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAListesPersonnesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_enfant_facturation)).BeginInit();
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
            this.label_RechNom.Size = new System.Drawing.Size(107, 13);
            this.label_RechNom.TabIndex = 1;
            this.label_RechNom.Text = "Recherche par nom :";
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
            this.label_RechNumTel.Text = "Recherche par numéro téléphone :";
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
            // dgv_enfant_facturation
            // 
            this.dgv_enfant_facturation.AllowUserToAddRows = false;
            this.dgv_enfant_facturation.AllowUserToDeleteRows = false;
            this.dgv_enfant_facturation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_enfant_facturation.Location = new System.Drawing.Point(559, 56);
            this.dgv_enfant_facturation.MultiSelect = false;
            this.dgv_enfant_facturation.Name = "dgv_enfant_facturation";
            this.dgv_enfant_facturation.ReadOnly = true;
            this.dgv_enfant_facturation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_enfant_facturation.Size = new System.Drawing.Size(332, 161);
            this.dgv_enfant_facturation.TabIndex = 16;
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
            this.btApercu.Text = "Générer facture";
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
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(770, 583);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(200, 35);
            this.btAnnuler.TabIndex = 23;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
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
            this.groupBox_recap.Controls.Add(this.lb_prixTotal);
            this.groupBox_recap.Controls.Add(this.label_prix);
            this.groupBox_recap.Controls.Add(this.lb_repasAucun);
            this.groupBox_recap.Controls.Add(this.label_aucun);
            this.groupBox_recap.Controls.Add(this.lb_repasFroid);
            this.groupBox_recap.Controls.Add(this.label_froid);
            this.groupBox_recap.Controls.Add(this.lb_repasChaud2);
            this.groupBox_recap.Controls.Add(this.label_chaud2);
            this.groupBox_recap.Controls.Add(this.lb_repasChaud1);
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
            // lb_prixTotal
            // 
            this.lb_prixTotal.AutoSize = true;
            this.lb_prixTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prixTotal.Location = new System.Drawing.Point(140, 177);
            this.lb_prixTotal.Name = "lb_prixTotal";
            this.lb_prixTotal.Size = new System.Drawing.Size(149, 20);
            this.lb_prixTotal.TabIndex = 28;
            this.lb_prixTotal.Text = "PRIX TOTAL HT :";
            // 
            // label_prix
            // 
            this.label_prix.AutoSize = true;
            this.label_prix.Location = new System.Drawing.Point(295, 182);
            this.label_prix.Name = "label_prix";
            this.label_prix.Size = new System.Drawing.Size(0, 13);
            this.label_prix.TabIndex = 29;
            // 
            // lb_repasAucun
            // 
            this.lb_repasAucun.AutoSize = true;
            this.lb_repasAucun.Location = new System.Drawing.Point(21, 136);
            this.lb_repasAucun.Name = "lb_repasAucun";
            this.lb_repasAucun.Size = new System.Drawing.Size(38, 13);
            this.lb_repasAucun.TabIndex = 28;
            this.lb_repasAucun.Text = "Aucun";
            // 
            // label_aucun
            // 
            this.label_aucun.AutoSize = true;
            this.label_aucun.Location = new System.Drawing.Point(126, 136);
            this.label_aucun.Name = "label_aucun";
            this.label_aucun.Size = new System.Drawing.Size(0, 13);
            this.label_aucun.TabIndex = 29;
            // 
            // lb_repasFroid
            // 
            this.lb_repasFroid.AutoSize = true;
            this.lb_repasFroid.Location = new System.Drawing.Point(18, 100);
            this.lb_repasFroid.Name = "lb_repasFroid";
            this.lb_repasFroid.Size = new System.Drawing.Size(61, 13);
            this.lb_repasFroid.TabIndex = 30;
            this.lb_repasFroid.Text = "Repas froid";
            // 
            // label_froid
            // 
            this.label_froid.AutoSize = true;
            this.label_froid.Location = new System.Drawing.Point(126, 100);
            this.label_froid.Name = "label_froid";
            this.label_froid.Size = new System.Drawing.Size(0, 13);
            this.label_froid.TabIndex = 31;
            // 
            // lb_repasChaud2
            // 
            this.lb_repasChaud2.AutoSize = true;
            this.lb_repasChaud2.Location = new System.Drawing.Point(18, 63);
            this.lb_repasChaud2.Name = "lb_repasChaud2";
            this.lb_repasChaud2.Size = new System.Drawing.Size(80, 13);
            this.lb_repasChaud2.TabIndex = 32;
            this.lb_repasChaud2.Text = "Repas chaud 2";
            // 
            // label_chaud2
            // 
            this.label_chaud2.AutoSize = true;
            this.label_chaud2.Location = new System.Drawing.Point(124, 63);
            this.label_chaud2.Name = "label_chaud2";
            this.label_chaud2.Size = new System.Drawing.Size(0, 13);
            this.label_chaud2.TabIndex = 33;
            // 
            // lb_repasChaud1
            // 
            this.lb_repasChaud1.AutoSize = true;
            this.lb_repasChaud1.Location = new System.Drawing.Point(18, 33);
            this.lb_repasChaud1.Name = "lb_repasChaud1";
            this.lb_repasChaud1.Size = new System.Drawing.Size(80, 13);
            this.lb_repasChaud1.TabIndex = 34;
            this.lb_repasChaud1.Text = "Repas chaud 1";
            // 
            // label_chaud1
            // 
            this.label_chaud1.AutoSize = true;
            this.label_chaud1.Location = new System.Drawing.Point(124, 33);
            this.label_chaud1.Name = "label_chaud1";
            this.label_chaud1.Size = new System.Drawing.Size(0, 13);
            this.label_chaud1.TabIndex = 35;
            // 
            // lb_dateCloture
            // 
            this.lb_dateCloture.AutoSize = true;
            this.lb_dateCloture.Location = new System.Drawing.Point(16, 26);
            this.lb_dateCloture.Name = "lb_dateCloture";
            this.lb_dateCloture.Size = new System.Drawing.Size(138, 13);
            this.lb_dateCloture.TabIndex = 28;
            this.lb_dateCloture.Text = "Dernière date de clôturation";
            // 
            // label_dateCloture
            // 
            this.label_dateCloture.AutoSize = true;
            this.label_dateCloture.Location = new System.Drawing.Point(16, 49);
            this.label_dateCloture.Name = "label_dateCloture";
            this.label_dateCloture.Size = new System.Drawing.Size(0, 13);
            this.label_dateCloture.TabIndex = 29;
            // 
            // lb_genererDetails
            // 
            this.lb_genererDetails.AutoSize = true;
            this.lb_genererDetails.Location = new System.Drawing.Point(16, 80);
            this.lb_genererDetails.Name = "lb_genererDetails";
            this.lb_genererDetails.Size = new System.Drawing.Size(84, 13);
            this.lb_genererDetails.TabIndex = 30;
            this.lb_genererDetails.Text = "Générer détails :";
            // 
            // groupBox1_selectperiode
            // 
            this.groupBox1_selectperiode.Controls.Add(this.button_visualiser);
            this.groupBox1_selectperiode.Controls.Add(this.lb_dateCloture);
            this.groupBox1_selectperiode.Controls.Add(this.dateTimePicker_debut);
            this.groupBox1_selectperiode.Controls.Add(this.lb_genererDetails);
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
            this.Controls.Add(this.dgv_enfant_facturation);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_enfant_facturation)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_enfant_facturation;
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
        private System.Windows.Forms.Label lb_prixTotal;
        private System.Windows.Forms.Label label_prix;
        private System.Windows.Forms.Label lb_repasAucun;
        private System.Windows.Forms.Label label_aucun;
        private System.Windows.Forms.Label lb_repasFroid;
        private System.Windows.Forms.Label label_froid;
        private System.Windows.Forms.Label lb_repasChaud2;
        private System.Windows.Forms.Label label_chaud2;
        private System.Windows.Forms.Label lb_repasChaud1;
        private System.Windows.Forms.Label label_chaud1;
        private System.Windows.Forms.Label lb_dateCloture;
        private System.Windows.Forms.Label label_dateCloture;
        private System.Windows.Forms.Label lb_genererDetails;
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