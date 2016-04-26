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
            this.textBox_NomRech = new System.Windows.Forms.TextBox();
            this.textBox_TéléphoneRech = new System.Windows.Forms.TextBox();
            this.label_NomRech = new System.Windows.Forms.Label();
            this.label_TéléphoneRech = new System.Windows.Forms.Label();
            this.dataGridView_Famille = new System.Windows.Forms.DataGridView();
            this.Téléphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Récap = new System.Windows.Forms.GroupBox();
            this.button_Annuler = new System.Windows.Forms.Button();
            this.button_Valider = new System.Windows.Forms.Button();
            this.dataGridView_Membre = new System.Windows.Forms.DataGridView();
            this.NomMembre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrénomMembre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_EnvoyerFacture = new System.Windows.Forms.Label();
            this.label_GénérerFacture = new System.Windows.Forms.Label();
            this.comboBox_Envoi = new System.Windows.Forms.ComboBox();
            this.comboBox_Génération = new System.Windows.Forms.ComboBox();
            this.textBox_Téléphone = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Adresse = new System.Windows.Forms.TextBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.label_Téléphone = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Adresse = new System.Windows.Forms.Label();
            this.label_Nom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Famille)).BeginInit();
            this.groupBox_Récap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Membre)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_NomRech
            // 
            this.textBox_NomRech.Location = new System.Drawing.Point(244, 33);
            this.textBox_NomRech.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_NomRech.Name = "textBox_NomRech";
            this.textBox_NomRech.Size = new System.Drawing.Size(375, 22);
            this.textBox_NomRech.TabIndex = 0;
            // 
            // textBox_TéléphoneRech
            // 
            this.textBox_TéléphoneRech.Location = new System.Drawing.Point(244, 65);
            this.textBox_TéléphoneRech.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_TéléphoneRech.Name = "textBox_TéléphoneRech";
            this.textBox_TéléphoneRech.Size = new System.Drawing.Size(375, 22);
            this.textBox_TéléphoneRech.TabIndex = 5;
            // 
            // label_NomRech
            // 
            this.label_NomRech.AutoSize = true;
            this.label_NomRech.Location = new System.Drawing.Point(84, 37);
            this.label_NomRech.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NomRech.Name = "label_NomRech";
            this.label_NomRech.Size = new System.Drawing.Size(110, 17);
            this.label_NomRech.TabIndex = 2;
            this.label_NomRech.Text = "Nom Recherche";
            // 
            // label_TéléphoneRech
            // 
            this.label_TéléphoneRech.AutoSize = true;
            this.label_TéléphoneRech.Location = new System.Drawing.Point(84, 69);
            this.label_TéléphoneRech.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TéléphoneRech.Name = "label_TéléphoneRech";
            this.label_TéléphoneRech.Size = new System.Drawing.Size(149, 17);
            this.label_TéléphoneRech.TabIndex = 3;
            this.label_TéléphoneRech.Text = "Téléphone Recherche";
            // 
            // dataGridView_Famille
            // 
            this.dataGridView_Famille.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Famille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Famille.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Téléphone,
            this.Nom,
            this.Adresse});
            this.dataGridView_Famille.Location = new System.Drawing.Point(96, 111);
            this.dataGridView_Famille.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Famille.Name = "dataGridView_Famille";
            this.dataGridView_Famille.Size = new System.Drawing.Size(1251, 185);
            this.dataGridView_Famille.TabIndex = 4;
            this.dataGridView_Famille.TabStop = false;
            // 
            // Téléphone
            // 
            this.Téléphone.HeaderText = "N° Téléphone";
            this.Téléphone.Name = "Téléphone";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            // 
            // groupBox_Récap
            // 
            this.groupBox_Récap.Controls.Add(this.button_Annuler);
            this.groupBox_Récap.Controls.Add(this.button_Valider);
            this.groupBox_Récap.Controls.Add(this.dataGridView_Membre);
            this.groupBox_Récap.Controls.Add(this.label_EnvoyerFacture);
            this.groupBox_Récap.Controls.Add(this.label_GénérerFacture);
            this.groupBox_Récap.Controls.Add(this.comboBox_Envoi);
            this.groupBox_Récap.Controls.Add(this.comboBox_Génération);
            this.groupBox_Récap.Controls.Add(this.textBox_Téléphone);
            this.groupBox_Récap.Controls.Add(this.textBox_Email);
            this.groupBox_Récap.Controls.Add(this.textBox_Adresse);
            this.groupBox_Récap.Controls.Add(this.textBox_Nom);
            this.groupBox_Récap.Controls.Add(this.label_Téléphone);
            this.groupBox_Récap.Controls.Add(this.label_Email);
            this.groupBox_Récap.Controls.Add(this.label_Adresse);
            this.groupBox_Récap.Controls.Add(this.label_Nom);
            this.groupBox_Récap.Location = new System.Drawing.Point(88, 338);
            this.groupBox_Récap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Récap.Name = "groupBox_Récap";
            this.groupBox_Récap.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Récap.Size = new System.Drawing.Size(1267, 437);
            this.groupBox_Récap.TabIndex = 8;
            this.groupBox_Récap.TabStop = false;
            this.groupBox_Récap.Text = "Information Famille";
            // 
            // button_Annuler
            // 
            this.button_Annuler.Location = new System.Drawing.Point(789, 375);
            this.button_Annuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Annuler.Name = "button_Annuler";
            this.button_Annuler.Size = new System.Drawing.Size(267, 43);
            this.button_Annuler.TabIndex = 25;
            this.button_Annuler.Text = "Annuler";
            this.button_Annuler.UseVisualStyleBackColor = true;
            // 
            // button_Valider
            // 
            this.button_Valider.Location = new System.Drawing.Point(212, 375);
            this.button_Valider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(267, 43);
            this.button_Valider.TabIndex = 20;
            this.button_Valider.Text = "Valider";
            this.button_Valider.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Membre
            // 
            this.dataGridView_Membre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Membre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Membre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomMembre,
            this.PrénomMembre,
            this.Age});
            this.dataGridView_Membre.Location = new System.Drawing.Point(8, 172);
            this.dataGridView_Membre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Membre.Name = "dataGridView_Membre";
            this.dataGridView_Membre.Size = new System.Drawing.Size(1251, 185);
            this.dataGridView_Membre.TabIndex = 19;
            this.dataGridView_Membre.TabStop = false;
            // 
            // NomMembre
            // 
            this.NomMembre.HeaderText = "Nom";
            this.NomMembre.Name = "NomMembre";
            // 
            // PrénomMembre
            // 
            this.PrénomMembre.HeaderText = "Prénom";
            this.PrénomMembre.Name = "PrénomMembre";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // label_EnvoyerFacture
            // 
            this.label_EnvoyerFacture.AutoSize = true;
            this.label_EnvoyerFacture.Location = new System.Drawing.Point(941, 39);
            this.label_EnvoyerFacture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_EnvoyerFacture.Name = "label_EnvoyerFacture";
            this.label_EnvoyerFacture.Size = new System.Drawing.Size(116, 17);
            this.label_EnvoyerFacture.TabIndex = 18;
            this.label_EnvoyerFacture.Text = "Envoyer facture :";
            // 
            // label_GénérerFacture
            // 
            this.label_GénérerFacture.AutoSize = true;
            this.label_GénérerFacture.Location = new System.Drawing.Point(629, 39);
            this.label_GénérerFacture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GénérerFacture.Name = "label_GénérerFacture";
            this.label_GénérerFacture.Size = new System.Drawing.Size(150, 17);
            this.label_GénérerFacture.TabIndex = 18;
            this.label_GénérerFacture.Text = "Générer facture pour :";
            // 
            // comboBox_Envoi
            // 
            this.comboBox_Envoi.FormattingEnabled = true;
            this.comboBox_Envoi.Items.AddRange(new object[] {
            "Courrier",
            "Email",
            "Les 2"});
            this.comboBox_Envoi.Location = new System.Drawing.Point(945, 68);
            this.comboBox_Envoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Envoi.Name = "comboBox_Envoi";
            this.comboBox_Envoi.Size = new System.Drawing.Size(265, 24);
            this.comboBox_Envoi.TabIndex = 15;
            // 
            // comboBox_Génération
            // 
            this.comboBox_Génération.FormattingEnabled = true;
            this.comboBox_Génération.Items.AddRange(new object[] {
            "Mois",
            "Semaine"});
            this.comboBox_Génération.Location = new System.Drawing.Point(633, 68);
            this.comboBox_Génération.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Génération.Name = "comboBox_Génération";
            this.comboBox_Génération.Size = new System.Drawing.Size(265, 24);
            this.comboBox_Génération.TabIndex = 10;
            // 
            // textBox_Téléphone
            // 
            this.textBox_Téléphone.Enabled = false;
            this.textBox_Téléphone.Location = new System.Drawing.Point(213, 132);
            this.textBox_Téléphone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Téléphone.Name = "textBox_Téléphone";
            this.textBox_Téléphone.Size = new System.Drawing.Size(317, 22);
            this.textBox_Téléphone.TabIndex = 12;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Enabled = false;
            this.textBox_Email.Location = new System.Drawing.Point(213, 100);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(317, 22);
            this.textBox_Email.TabIndex = 13;
            // 
            // textBox_Adresse
            // 
            this.textBox_Adresse.Enabled = false;
            this.textBox_Adresse.Location = new System.Drawing.Point(213, 68);
            this.textBox_Adresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Adresse.Name = "textBox_Adresse";
            this.textBox_Adresse.Size = new System.Drawing.Size(317, 22);
            this.textBox_Adresse.TabIndex = 14;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Enabled = false;
            this.textBox_Nom.Location = new System.Drawing.Point(213, 36);
            this.textBox_Nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(317, 22);
            this.textBox_Nom.TabIndex = 15;
            // 
            // label_Téléphone
            // 
            this.label_Téléphone.AutoSize = true;
            this.label_Téléphone.Location = new System.Drawing.Point(53, 135);
            this.label_Téléphone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Téléphone.Name = "label_Téléphone";
            this.label_Téléphone.Size = new System.Drawing.Size(76, 17);
            this.label_Téléphone.TabIndex = 8;
            this.label_Téléphone.Text = "Téléphone";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(53, 103);
            this.label_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(42, 17);
            this.label_Email.TabIndex = 9;
            this.label_Email.Text = "Email";
            // 
            // label_Adresse
            // 
            this.label_Adresse.AutoSize = true;
            this.label_Adresse.Location = new System.Drawing.Point(53, 71);
            this.label_Adresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Adresse.Name = "label_Adresse";
            this.label_Adresse.Size = new System.Drawing.Size(60, 17);
            this.label_Adresse.TabIndex = 10;
            this.label_Adresse.Text = "Adresse";
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(53, 39);
            this.label_Nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(37, 17);
            this.label_Nom.TabIndex = 11;
            this.label_Nom.Text = "Nom";
            // 
            // Form_VisualisationFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 815);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox_Récap);
            this.Controls.Add(this.dataGridView_Famille);
            this.Controls.Add(this.label_TéléphoneRech);
            this.Controls.Add(this.label_NomRech);
            this.Controls.Add(this.textBox_TéléphoneRech);
            this.Controls.Add(this.textBox_NomRech);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_VisualisationFamille";
            this.Text = "Visualisation des Familles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Famille)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Téléphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.GroupBox groupBox_Récap;
        private System.Windows.Forms.ComboBox comboBox_Envoi;
        private System.Windows.Forms.ComboBox comboBox_Génération;
        private System.Windows.Forms.TextBox textBox_Téléphone;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Adresse;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.Label label_Téléphone;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Adresse;
        private System.Windows.Forms.Label label_Nom;
        private System.Windows.Forms.Label label_EnvoyerFacture;
        private System.Windows.Forms.Label label_GénérerFacture;
        private System.Windows.Forms.Button button_Annuler;
        private System.Windows.Forms.Button button_Valider;
        private System.Windows.Forms.DataGridView dataGridView_Membre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomMembre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrénomMembre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
    }
}