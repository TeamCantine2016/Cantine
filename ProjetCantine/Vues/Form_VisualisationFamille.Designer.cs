namespace ProjetCantine
{
    partial class Form_VisualisationFamille
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
            this.textBox_NomRech = new System.Windows.Forms.TextBox();
            this.textBox_TéléphoneRech = new System.Windows.Forms.TextBox();
            this.label_NomRech = new System.Windows.Forms.Label();
            this.label_TéléphoneRech = new System.Windows.Forms.Label();
            this.dataGridView_Famille = new System.Windows.Forms.DataGridView();
            this.tAListeFamillesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_cantineDataSet = new ProjetCantine.Models.db_cantineDataSet();
            this.groupBox_Récap = new System.Windows.Forms.GroupBox();
            this.dataGridView_Membre = new System.Windows.Forms.DataGridView();
            this.textBox_Téléphone = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Adresse = new System.Windows.Forms.TextBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.label_Téléphone = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Adresse = new System.Windows.Forms.Label();
            this.label_Nom = new System.Windows.Forms.Label();
            this.tA_Liste_FamillesTableAdapter = new ProjetCantine.Models.db_cantineDataSetTableAdapters.TA_Liste_FamillesTableAdapter();
            this.button_NomReset = new System.Windows.Forms.Button();
            this.button_TelReset = new System.Windows.Forms.Button();
            this.textBox_nbEnfant = new System.Windows.Forms.TextBox();
            this.label_nbEnfants = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Famille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAListeFamillesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet)).BeginInit();
            this.groupBox_Récap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Membre)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_NomRech
            // 
            this.textBox_NomRech.Location = new System.Drawing.Point(189, 37);
            this.textBox_NomRech.Name = "textBox_NomRech";
            this.textBox_NomRech.Size = new System.Drawing.Size(282, 20);
            this.textBox_NomRech.TabIndex = 0;
            this.textBox_NomRech.TextChanged += new System.EventHandler(this.Form_VisualisationFamille_Load);
            // 
            // textBox_TéléphoneRech
            // 
            this.textBox_TéléphoneRech.Location = new System.Drawing.Point(189, 63);
            this.textBox_TéléphoneRech.Name = "textBox_TéléphoneRech";
            this.textBox_TéléphoneRech.Size = new System.Drawing.Size(282, 20);
            this.textBox_TéléphoneRech.TabIndex = 5;
            this.textBox_TéléphoneRech.TextChanged += new System.EventHandler(this.Form_VisualisationFamille_Load);
            // 
            // label_NomRech
            // 
            this.label_NomRech.AutoSize = true;
            this.label_NomRech.Location = new System.Drawing.Point(69, 40);
            this.label_NomRech.Name = "label_NomRech";
            this.label_NomRech.Size = new System.Drawing.Size(85, 13);
            this.label_NomRech.TabIndex = 2;
            this.label_NomRech.Text = "Nom Recherche";
            // 
            // label_TéléphoneRech
            // 
            this.label_TéléphoneRech.AutoSize = true;
            this.label_TéléphoneRech.Location = new System.Drawing.Point(69, 66);
            this.label_TéléphoneRech.Name = "label_TéléphoneRech";
            this.label_TéléphoneRech.Size = new System.Drawing.Size(114, 13);
            this.label_TéléphoneRech.TabIndex = 3;
            this.label_TéléphoneRech.Text = "Téléphone Recherche";
            // 
            // dataGridView_Famille
            // 
            this.dataGridView_Famille.AllowUserToAddRows = false;
            this.dataGridView_Famille.AllowUserToDeleteRows = false;
            this.dataGridView_Famille.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Famille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Famille.Location = new System.Drawing.Point(72, 107);
            this.dataGridView_Famille.Name = "dataGridView_Famille";
            this.dataGridView_Famille.ReadOnly = true;
            this.dataGridView_Famille.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Famille.Size = new System.Drawing.Size(938, 185);
            this.dataGridView_Famille.TabIndex = 4;
            this.dataGridView_Famille.TabStop = false;
            this.dataGridView_Famille.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Famille_CellEnter);
            // 
            // tAListeFamillesBindingSource
            // 
            this.tAListeFamillesBindingSource.DataMember = "TA_Liste_Familles";
            this.tAListeFamillesBindingSource.DataSource = this.db_cantineDataSet;
            // 
            // db_cantineDataSet
            // 
            this.db_cantineDataSet.DataSetName = "db_cantineDataSet";
            this.db_cantineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox_Récap
            // 
            this.groupBox_Récap.Controls.Add(this.textBox_nbEnfant);
            this.groupBox_Récap.Controls.Add(this.label_nbEnfants);
            this.groupBox_Récap.Controls.Add(this.dataGridView_Membre);
            this.groupBox_Récap.Controls.Add(this.textBox_Téléphone);
            this.groupBox_Récap.Controls.Add(this.textBox_Email);
            this.groupBox_Récap.Controls.Add(this.textBox_Adresse);
            this.groupBox_Récap.Controls.Add(this.textBox_Nom);
            this.groupBox_Récap.Controls.Add(this.label_Téléphone);
            this.groupBox_Récap.Controls.Add(this.label_Email);
            this.groupBox_Récap.Controls.Add(this.label_Adresse);
            this.groupBox_Récap.Controls.Add(this.label_Nom);
            this.groupBox_Récap.Location = new System.Drawing.Point(66, 326);
            this.groupBox_Récap.Name = "groupBox_Récap";
            this.groupBox_Récap.Size = new System.Drawing.Size(950, 304);
            this.groupBox_Récap.TabIndex = 8;
            this.groupBox_Récap.TabStop = false;
            this.groupBox_Récap.Text = "Information Famille";
            // 
            // dataGridView_Membre
            // 
            this.dataGridView_Membre.AllowUserToAddRows = false;
            this.dataGridView_Membre.AllowUserToDeleteRows = false;
            this.dataGridView_Membre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Membre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Membre.Location = new System.Drawing.Point(6, 140);
            this.dataGridView_Membre.Name = "dataGridView_Membre";
            this.dataGridView_Membre.ReadOnly = true;
            this.dataGridView_Membre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Membre.Size = new System.Drawing.Size(938, 150);
            this.dataGridView_Membre.TabIndex = 19;
            this.dataGridView_Membre.TabStop = false;
            // 
            // textBox_Téléphone
            // 
            this.textBox_Téléphone.Enabled = false;
            this.textBox_Téléphone.Location = new System.Drawing.Point(160, 107);
            this.textBox_Téléphone.Name = "textBox_Téléphone";
            this.textBox_Téléphone.Size = new System.Drawing.Size(239, 20);
            this.textBox_Téléphone.TabIndex = 12;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Enabled = false;
            this.textBox_Email.Location = new System.Drawing.Point(160, 81);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(239, 20);
            this.textBox_Email.TabIndex = 13;
            // 
            // textBox_Adresse
            // 
            this.textBox_Adresse.Enabled = false;
            this.textBox_Adresse.Location = new System.Drawing.Point(160, 55);
            this.textBox_Adresse.Name = "textBox_Adresse";
            this.textBox_Adresse.Size = new System.Drawing.Size(239, 20);
            this.textBox_Adresse.TabIndex = 14;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Enabled = false;
            this.textBox_Nom.Location = new System.Drawing.Point(160, 29);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(239, 20);
            this.textBox_Nom.TabIndex = 15;
            // 
            // label_Téléphone
            // 
            this.label_Téléphone.AutoSize = true;
            this.label_Téléphone.Location = new System.Drawing.Point(40, 110);
            this.label_Téléphone.Name = "label_Téléphone";
            this.label_Téléphone.Size = new System.Drawing.Size(58, 13);
            this.label_Téléphone.TabIndex = 8;
            this.label_Téléphone.Text = "Téléphone";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(40, 84);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(32, 13);
            this.label_Email.TabIndex = 9;
            this.label_Email.Text = "Email";
            // 
            // label_Adresse
            // 
            this.label_Adresse.AutoSize = true;
            this.label_Adresse.Location = new System.Drawing.Point(40, 58);
            this.label_Adresse.Name = "label_Adresse";
            this.label_Adresse.Size = new System.Drawing.Size(45, 13);
            this.label_Adresse.TabIndex = 10;
            this.label_Adresse.Text = "Adresse";
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(40, 32);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(39, 13);
            this.label_Nom.TabIndex = 11;
            this.label_Nom.Text = "Famille";
            // 
            // tA_Liste_FamillesTableAdapter
            // 
            this.tA_Liste_FamillesTableAdapter.ClearBeforeFill = true;
            // 
            // button_NomReset
            // 
            this.button_NomReset.Location = new System.Drawing.Point(477, 35);
            this.button_NomReset.Name = "button_NomReset";
            this.button_NomReset.Size = new System.Drawing.Size(50, 23);
            this.button_NomReset.TabIndex = 9;
            this.button_NomReset.Text = "Reset";
            this.button_NomReset.UseVisualStyleBackColor = true;
            this.button_NomReset.Click += new System.EventHandler(this.button_NomReset_Click);
            // 
            // button_TelReset
            // 
            this.button_TelReset.Location = new System.Drawing.Point(477, 61);
            this.button_TelReset.Name = "button_TelReset";
            this.button_TelReset.Size = new System.Drawing.Size(50, 23);
            this.button_TelReset.TabIndex = 10;
            this.button_TelReset.Text = "Reset";
            this.button_TelReset.UseVisualStyleBackColor = true;
            this.button_TelReset.Click += new System.EventHandler(this.button_TelReset_Click);
            // 
            // textBox_nbEnfant
            // 
            this.textBox_nbEnfant.Enabled = false;
            this.textBox_nbEnfant.Location = new System.Drawing.Point(591, 29);
            this.textBox_nbEnfant.Name = "textBox_nbEnfant";
            this.textBox_nbEnfant.Size = new System.Drawing.Size(62, 20);
            this.textBox_nbEnfant.TabIndex = 21;
            // 
            // label_nbEnfants
            // 
            this.label_nbEnfants.AutoSize = true;
            this.label_nbEnfants.Location = new System.Drawing.Point(455, 32);
            this.label_nbEnfants.Name = "label_nbEnfants";
            this.label_nbEnfants.Size = new System.Drawing.Size(130, 13);
            this.label_nbEnfants.TabIndex = 20;
            this.label_nbEnfants.Text = "Nombre d\'enfant à charge";
            // 
            // Form_VisualisationFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 662);
            this.ControlBox = false;
            this.Controls.Add(this.button_TelReset);
            this.Controls.Add(this.button_NomReset);
            this.Controls.Add(this.groupBox_Récap);
            this.Controls.Add(this.dataGridView_Famille);
            this.Controls.Add(this.label_TéléphoneRech);
            this.Controls.Add(this.label_NomRech);
            this.Controls.Add(this.textBox_TéléphoneRech);
            this.Controls.Add(this.textBox_NomRech);
            this.Name = "Form_VisualisationFamille";
            this.Text = "Visualisation des Familles";
            this.Load += new System.EventHandler(this.Form_VisualisationFamille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Famille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAListeFamillesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet)).EndInit();
            this.groupBox_Récap.ResumeLayout(false);
            this.groupBox_Récap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Membre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_NomRech;
        private System.Windows.Forms.TextBox textBox_TéléphoneRech;
        private System.Windows.Forms.Label label_NomRech;
        private System.Windows.Forms.Label label_TéléphoneRech;
        private System.Windows.Forms.DataGridView dataGridView_Famille;
        private System.Windows.Forms.GroupBox groupBox_Récap;
        private System.Windows.Forms.TextBox textBox_Téléphone;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Adresse;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.Label label_Téléphone;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Adresse;
        private System.Windows.Forms.Label label_Nom;
        private System.Windows.Forms.DataGridView dataGridView_Membre;
        private Models.db_cantineDataSet db_cantineDataSet;
        private System.Windows.Forms.BindingSource tAListeFamillesBindingSource;
        private Models.db_cantineDataSetTableAdapters.TA_Liste_FamillesTableAdapter tA_Liste_FamillesTableAdapter;
        private System.Windows.Forms.Button button_NomReset;
        private System.Windows.Forms.Button button_TelReset;
        private System.Windows.Forms.TextBox textBox_nbEnfant;
        private System.Windows.Forms.Label label_nbEnfants;
    }
}