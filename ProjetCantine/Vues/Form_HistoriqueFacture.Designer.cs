namespace ProjetCantine.Vues
{
    partial class Form_HistoriqueFacture
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
            this.dataGridView_Historique = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_fin = new System.Windows.Forms.DateTimePicker();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.label_recherche = new System.Windows.Forms.Label();
            this.groupBox_envoyer = new System.Windows.Forms.GroupBox();
            this.radioButto_Envoyer = new System.Windows.Forms.RadioButton();
            this.radioButton_PasEnvoyer = new System.Windows.Forms.RadioButton();
            this.radioButton_TousEnvoie = new System.Windows.Forms.RadioButton();
            this.groupBox_Payement = new System.Windows.Forms.GroupBox();
            this.radioButton_payer = new System.Windows.Forms.RadioButton();
            this.radioButton_PasPayer = new System.Windows.Forms.RadioButton();
            this.radioButton_tousPayer = new System.Windows.Forms.RadioButton();
            this.groupBox_filtreDte = new System.Windows.Forms.GroupBox();
            this.label_dateDeFin = new System.Windows.Forms.Label();
            this.checkBox_AfficherDate = new System.Windows.Forms.CheckBox();
            this.label_dateGénération = new System.Windows.Forms.Label();
            this.label_début = new System.Windows.Forms.Label();
            this.label_fin = new System.Windows.Forms.Label();
            this.dateTimePicker_debut = new System.Windows.Forms.DateTimePicker();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_visualisation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Historique)).BeginInit();
            this.groupBox_envoyer.SuspendLayout();
            this.groupBox_Payement.SuspendLayout();
            this.groupBox_filtreDte.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Historique
            // 
            this.dataGridView_Historique.AllowUserToAddRows = false;
            this.dataGridView_Historique.AllowUserToDeleteRows = false;
            this.dataGridView_Historique.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Historique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Historique.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Historique.Name = "dataGridView_Historique";
            this.dataGridView_Historique.ReadOnly = true;
            this.dataGridView_Historique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Historique.Size = new System.Drawing.Size(870, 615);
            this.dataGridView_Historique.TabIndex = 0;
            // 
            // dateTimePicker_fin
            // 
            this.dateTimePicker_fin.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_fin.Location = new System.Drawing.Point(7, 153);
            this.dateTimePicker_fin.Name = "dateTimePicker_fin";
            this.dateTimePicker_fin.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker_fin.TabIndex = 3;
            this.dateTimePicker_fin.ValueChanged += new System.EventHandler(this.dateTimePicker_debut_ValueChanged);
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(888, 64);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(190, 20);
            this.textBox_Nom.TabIndex = 22;
            this.textBox_Nom.TextChanged += new System.EventHandler(this.textBox_Nom_TextChanged);
            // 
            // label_recherche
            // 
            this.label_recherche.AutoSize = true;
            this.label_recherche.Location = new System.Drawing.Point(888, 48);
            this.label_recherche.Name = "label_recherche";
            this.label_recherche.Size = new System.Drawing.Size(101, 13);
            this.label_recherche.TabIndex = 21;
            this.label_recherche.Text = "Recherche par nom";
            // 
            // groupBox_envoyer
            // 
            this.groupBox_envoyer.Controls.Add(this.radioButto_Envoyer);
            this.groupBox_envoyer.Controls.Add(this.radioButton_PasEnvoyer);
            this.groupBox_envoyer.Controls.Add(this.radioButton_TousEnvoie);
            this.groupBox_envoyer.Location = new System.Drawing.Point(888, 120);
            this.groupBox_envoyer.Name = "groupBox_envoyer";
            this.groupBox_envoyer.Size = new System.Drawing.Size(190, 110);
            this.groupBox_envoyer.TabIndex = 19;
            this.groupBox_envoyer.TabStop = false;
            this.groupBox_envoyer.Text = "Filtre des envoies";
            // 
            // radioButto_Envoyer
            // 
            this.radioButto_Envoyer.AutoSize = true;
            this.radioButto_Envoyer.Location = new System.Drawing.Point(6, 26);
            this.radioButto_Envoyer.Name = "radioButto_Envoyer";
            this.radioButto_Envoyer.Size = new System.Drawing.Size(64, 17);
            this.radioButto_Envoyer.TabIndex = 9;
            this.radioButto_Envoyer.Tag = "Envoyer";
            this.radioButto_Envoyer.Text = "Envoyer";
            this.radioButto_Envoyer.UseVisualStyleBackColor = true;
            this.radioButto_Envoyer.CheckedChanged += new System.EventHandler(this.radioButto_Envoyer_CheckedChanged);
            // 
            // radioButton_PasEnvoyer
            // 
            this.radioButton_PasEnvoyer.AutoSize = true;
            this.radioButton_PasEnvoyer.Location = new System.Drawing.Point(6, 49);
            this.radioButton_PasEnvoyer.Name = "radioButton_PasEnvoyer";
            this.radioButton_PasEnvoyer.Size = new System.Drawing.Size(84, 17);
            this.radioButton_PasEnvoyer.TabIndex = 10;
            this.radioButton_PasEnvoyer.Tag = "PasEnvoyer";
            this.radioButton_PasEnvoyer.Text = "Pas envoyer";
            this.radioButton_PasEnvoyer.UseVisualStyleBackColor = true;
            this.radioButton_PasEnvoyer.CheckedChanged += new System.EventHandler(this.radioButto_Envoyer_CheckedChanged);
            // 
            // radioButton_TousEnvoie
            // 
            this.radioButton_TousEnvoie.AutoSize = true;
            this.radioButton_TousEnvoie.Checked = true;
            this.radioButton_TousEnvoie.Location = new System.Drawing.Point(6, 72);
            this.radioButton_TousEnvoie.Name = "radioButton_TousEnvoie";
            this.radioButton_TousEnvoie.Size = new System.Drawing.Size(49, 17);
            this.radioButton_TousEnvoie.TabIndex = 11;
            this.radioButton_TousEnvoie.TabStop = true;
            this.radioButton_TousEnvoie.Tag = "Tous";
            this.radioButton_TousEnvoie.Text = "Tous";
            this.radioButton_TousEnvoie.UseVisualStyleBackColor = true;
            this.radioButton_TousEnvoie.CheckedChanged += new System.EventHandler(this.radioButto_Envoyer_CheckedChanged);
            // 
            // groupBox_Payement
            // 
            this.groupBox_Payement.Controls.Add(this.radioButton_payer);
            this.groupBox_Payement.Controls.Add(this.radioButton_PasPayer);
            this.groupBox_Payement.Controls.Add(this.radioButton_tousPayer);
            this.groupBox_Payement.Location = new System.Drawing.Point(888, 234);
            this.groupBox_Payement.Name = "groupBox_Payement";
            this.groupBox_Payement.Size = new System.Drawing.Size(190, 110);
            this.groupBox_Payement.TabIndex = 20;
            this.groupBox_Payement.TabStop = false;
            this.groupBox_Payement.Text = "Filtre des payement";
            // 
            // radioButton_payer
            // 
            this.radioButton_payer.AutoSize = true;
            this.radioButton_payer.Location = new System.Drawing.Point(6, 29);
            this.radioButton_payer.Name = "radioButton_payer";
            this.radioButton_payer.Size = new System.Drawing.Size(52, 17);
            this.radioButton_payer.TabIndex = 9;
            this.radioButton_payer.Tag = "Payer";
            this.radioButton_payer.Text = "Payer";
            this.radioButton_payer.UseVisualStyleBackColor = true;
            this.radioButton_payer.CheckedChanged += new System.EventHandler(this.radioButton_payer_CheckedChanged);
            // 
            // radioButton_PasPayer
            // 
            this.radioButton_PasPayer.AutoSize = true;
            this.radioButton_PasPayer.Location = new System.Drawing.Point(6, 52);
            this.radioButton_PasPayer.Name = "radioButton_PasPayer";
            this.radioButton_PasPayer.Size = new System.Drawing.Size(72, 17);
            this.radioButton_PasPayer.TabIndex = 10;
            this.radioButton_PasPayer.Tag = "PasPayer";
            this.radioButton_PasPayer.Text = "Pas payer";
            this.radioButton_PasPayer.UseVisualStyleBackColor = true;
            this.radioButton_PasPayer.CheckedChanged += new System.EventHandler(this.radioButton_payer_CheckedChanged);
            // 
            // radioButton_tousPayer
            // 
            this.radioButton_tousPayer.AutoSize = true;
            this.radioButton_tousPayer.Checked = true;
            this.radioButton_tousPayer.Location = new System.Drawing.Point(6, 75);
            this.radioButton_tousPayer.Name = "radioButton_tousPayer";
            this.radioButton_tousPayer.Size = new System.Drawing.Size(49, 17);
            this.radioButton_tousPayer.TabIndex = 11;
            this.radioButton_tousPayer.TabStop = true;
            this.radioButton_tousPayer.Tag = "Tous";
            this.radioButton_tousPayer.Text = "Tous";
            this.radioButton_tousPayer.UseVisualStyleBackColor = true;
            this.radioButton_tousPayer.CheckedChanged += new System.EventHandler(this.radioButton_payer_CheckedChanged);
            // 
            // groupBox_filtreDte
            // 
            this.groupBox_filtreDte.Controls.Add(this.label_dateDeFin);
            this.groupBox_filtreDte.Controls.Add(this.dateTimePicker_fin);
            this.groupBox_filtreDte.Controls.Add(this.checkBox_AfficherDate);
            this.groupBox_filtreDte.Controls.Add(this.label_dateGénération);
            this.groupBox_filtreDte.Controls.Add(this.label_début);
            this.groupBox_filtreDte.Controls.Add(this.label_fin);
            this.groupBox_filtreDte.Controls.Add(this.dateTimePicker_debut);
            this.groupBox_filtreDte.Location = new System.Drawing.Point(888, 348);
            this.groupBox_filtreDte.Name = "groupBox_filtreDte";
            this.groupBox_filtreDte.Size = new System.Drawing.Size(190, 184);
            this.groupBox_filtreDte.TabIndex = 18;
            this.groupBox_filtreDte.TabStop = false;
            this.groupBox_filtreDte.Text = "Filtre avec des dates";
            // 
            // label_dateDeFin
            // 
            this.label_dateDeFin.AutoSize = true;
            this.label_dateDeFin.ForeColor = System.Drawing.Color.Maroon;
            this.label_dateDeFin.Location = new System.Drawing.Point(5, 60);
            this.label_dateDeFin.Name = "label_dateDeFin";
            this.label_dateDeFin.Size = new System.Drawing.Size(65, 13);
            this.label_dateDeFin.TabIndex = 11;
            this.label_dateDeFin.Text = "(Date de fin)";
            // 
            // checkBox_AfficherDate
            // 
            this.checkBox_AfficherDate.AutoSize = true;
            this.checkBox_AfficherDate.Location = new System.Drawing.Point(0, 26);
            this.checkBox_AfficherDate.Name = "checkBox_AfficherDate";
            this.checkBox_AfficherDate.Size = new System.Drawing.Size(125, 17);
            this.checkBox_AfficherDate.TabIndex = 5;
            this.checkBox_AfficherDate.Text = "Fitrer avec des dates";
            this.checkBox_AfficherDate.UseVisualStyleBackColor = true;
            this.checkBox_AfficherDate.CheckedChanged += new System.EventHandler(this.checkBox_AfficherDate_CheckedChanged);
            // 
            // label_dateGénération
            // 
            this.label_dateGénération.AutoSize = true;
            this.label_dateGénération.ForeColor = System.Drawing.Color.Black;
            this.label_dateGénération.Location = new System.Drawing.Point(4, 47);
            this.label_dateGénération.Name = "label_dateGénération";
            this.label_dateGénération.Size = new System.Drawing.Size(160, 13);
            this.label_dateGénération.TabIndex = 6;
            this.label_dateGénération.Text = "Date de génération de la facture\r\n";
            // 
            // label_début
            // 
            this.label_début.AutoSize = true;
            this.label_début.Location = new System.Drawing.Point(4, 85);
            this.label_début.Name = "label_début";
            this.label_début.Size = new System.Drawing.Size(75, 13);
            this.label_début.TabIndex = 7;
            this.label_début.Text = "Date de début";
            // 
            // label_fin
            // 
            this.label_fin.AutoSize = true;
            this.label_fin.Location = new System.Drawing.Point(7, 137);
            this.label_fin.Name = "label_fin";
            this.label_fin.Size = new System.Drawing.Size(59, 13);
            this.label_fin.TabIndex = 8;
            this.label_fin.Text = "Date de fin";
            // 
            // dateTimePicker_debut
            // 
            this.dateTimePicker_debut.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_debut.Location = new System.Drawing.Point(7, 101);
            this.dateTimePicker_debut.Name = "dateTimePicker_debut";
            this.dateTimePicker_debut.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker_debut.TabIndex = 3;
            this.dateTimePicker_debut.Value = new System.DateTime(2012, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_debut.ValueChanged += new System.EventHandler(this.dateTimePicker_debut_ValueChanged);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(888, 542);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(190, 23);
            this.button_modifier.TabIndex = 17;
            this.button_modifier.Text = "Modifier le chemin du fichier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_visualisation
            // 
            this.button_visualisation.Location = new System.Drawing.Point(888, 571);
            this.button_visualisation.Name = "button_visualisation";
            this.button_visualisation.Size = new System.Drawing.Size(190, 23);
            this.button_visualisation.TabIndex = 16;
            this.button_visualisation.Text = "Visualisation";
            this.button_visualisation.UseVisualStyleBackColor = true;
            this.button_visualisation.Click += new System.EventHandler(this.button_visualisation_Click);
            // 
            // Form_HistoriqueFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_Nom);
            this.Controls.Add(this.label_recherche);
            this.Controls.Add(this.groupBox_envoyer);
            this.Controls.Add(this.groupBox_Payement);
            this.Controls.Add(this.groupBox_filtreDte);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_visualisation);
            this.Controls.Add(this.dataGridView_Historique);
            this.Name = "Form_HistoriqueFacture";
            this.Text = "Historique Facture";
            this.Load += new System.EventHandler(this.Form_HistoriqueFacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Historique)).EndInit();
            this.groupBox_envoyer.ResumeLayout(false);
            this.groupBox_envoyer.PerformLayout();
            this.groupBox_Payement.ResumeLayout(false);
            this.groupBox_Payement.PerformLayout();
            this.groupBox_filtreDte.ResumeLayout(false);
            this.groupBox_filtreDte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Historique;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fin;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.Label label_recherche;
        private System.Windows.Forms.GroupBox groupBox_envoyer;
        private System.Windows.Forms.RadioButton radioButto_Envoyer;
        private System.Windows.Forms.RadioButton radioButton_PasEnvoyer;
        private System.Windows.Forms.RadioButton radioButton_TousEnvoie;
        private System.Windows.Forms.GroupBox groupBox_Payement;
        private System.Windows.Forms.RadioButton radioButton_payer;
        private System.Windows.Forms.RadioButton radioButton_PasPayer;
        private System.Windows.Forms.RadioButton radioButton_tousPayer;
        private System.Windows.Forms.GroupBox groupBox_filtreDte;
        private System.Windows.Forms.Label label_dateDeFin;
        private System.Windows.Forms.CheckBox checkBox_AfficherDate;
        private System.Windows.Forms.Label label_dateGénération;
        private System.Windows.Forms.Label label_début;
        private System.Windows.Forms.Label label_fin;
        private System.Windows.Forms.DateTimePicker dateTimePicker_debut;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_visualisation;
    }
}