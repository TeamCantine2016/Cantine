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
            this.button_visualisation = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.groupBox_filtre = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_fin = new System.Windows.Forms.DateTimePicker();
            this.checkBox_tout = new System.Windows.Forms.CheckBox();
            this.checkBox_payer = new System.Windows.Forms.CheckBox();
            this.checkBox_envoyer = new System.Windows.Forms.CheckBox();
            this.label_dateGénération = new System.Windows.Forms.Label();
            this.label_début = new System.Windows.Forms.Label();
            this.label_fin = new System.Windows.Forms.Label();
            this.dateTimePicker_debut = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Historique)).BeginInit();
            this.groupBox_filtre.SuspendLayout();
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
            // button_visualisation
            // 
            this.button_visualisation.Location = new System.Drawing.Point(888, 358);
            this.button_visualisation.Name = "button_visualisation";
            this.button_visualisation.Size = new System.Drawing.Size(190, 23);
            this.button_visualisation.TabIndex = 1;
            this.button_visualisation.Text = "Visualisation";
            this.button_visualisation.UseVisualStyleBackColor = true;
            this.button_visualisation.Click += new System.EventHandler(this.button_visualisation_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(888, 329);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(190, 23);
            this.button_modifier.TabIndex = 2;
            this.button_modifier.Text = "Modifier le chemin du fichier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // groupBox_filtre
            // 
            this.groupBox_filtre.Controls.Add(this.dateTimePicker_fin);
            this.groupBox_filtre.Controls.Add(this.checkBox_tout);
            this.groupBox_filtre.Controls.Add(this.checkBox_payer);
            this.groupBox_filtre.Controls.Add(this.checkBox_envoyer);
            this.groupBox_filtre.Controls.Add(this.label_dateGénération);
            this.groupBox_filtre.Controls.Add(this.label_début);
            this.groupBox_filtre.Controls.Add(this.label_fin);
            this.groupBox_filtre.Controls.Add(this.dateTimePicker_debut);
            this.groupBox_filtre.Location = new System.Drawing.Point(888, 70);
            this.groupBox_filtre.Name = "groupBox_filtre";
            this.groupBox_filtre.Size = new System.Drawing.Size(190, 240);
            this.groupBox_filtre.TabIndex = 10;
            this.groupBox_filtre.TabStop = false;
            this.groupBox_filtre.Text = "Filtre";
            // 
            // dateTimePicker_fin
            // 
            this.dateTimePicker_fin.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_fin.Location = new System.Drawing.Point(6, 181);
            this.dateTimePicker_fin.Name = "dateTimePicker_fin";
            this.dateTimePicker_fin.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker_fin.TabIndex = 3;
            this.dateTimePicker_fin.ValueChanged += new System.EventHandler(this.checkBox_envoyer_CheckedChanged);
            // 
            // checkBox_tout
            // 
            this.checkBox_tout.AutoSize = true;
            this.checkBox_tout.Checked = true;
            this.checkBox_tout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_tout.Location = new System.Drawing.Point(9, 212);
            this.checkBox_tout.Name = "checkBox_tout";
            this.checkBox_tout.Size = new System.Drawing.Size(146, 17);
            this.checkBox_tout.TabIndex = 5;
            this.checkBox_tout.Text = "Afficher toute les factures";
            this.checkBox_tout.UseVisualStyleBackColor = true;
            this.checkBox_tout.CheckedChanged += new System.EventHandler(this.checkBox_tout_CheckedChanged);
            // 
            // checkBox_payer
            // 
            this.checkBox_payer.AutoSize = true;
            this.checkBox_payer.Location = new System.Drawing.Point(6, 52);
            this.checkBox_payer.Name = "checkBox_payer";
            this.checkBox_payer.Size = new System.Drawing.Size(94, 17);
            this.checkBox_payer.TabIndex = 5;
            this.checkBox_payer.Text = "Facture payée";
            this.checkBox_payer.UseVisualStyleBackColor = true;
            this.checkBox_payer.CheckedChanged += new System.EventHandler(this.checkBox_envoyer_CheckedChanged);
            // 
            // checkBox_envoyer
            // 
            this.checkBox_envoyer.AutoSize = true;
            this.checkBox_envoyer.Location = new System.Drawing.Point(6, 29);
            this.checkBox_envoyer.Name = "checkBox_envoyer";
            this.checkBox_envoyer.Size = new System.Drawing.Size(106, 17);
            this.checkBox_envoyer.TabIndex = 4;
            this.checkBox_envoyer.Text = "Facture envoyée";
            this.checkBox_envoyer.UseVisualStyleBackColor = true;
            this.checkBox_envoyer.CheckedChanged += new System.EventHandler(this.checkBox_envoyer_CheckedChanged);
            // 
            // label_dateGénération
            // 
            this.label_dateGénération.AutoSize = true;
            this.label_dateGénération.Location = new System.Drawing.Point(3, 91);
            this.label_dateGénération.Name = "label_dateGénération";
            this.label_dateGénération.Size = new System.Drawing.Size(160, 13);
            this.label_dateGénération.TabIndex = 6;
            this.label_dateGénération.Text = "Date de génération de la facture";
            // 
            // label_début
            // 
            this.label_début.AutoSize = true;
            this.label_début.Location = new System.Drawing.Point(3, 113);
            this.label_début.Name = "label_début";
            this.label_début.Size = new System.Drawing.Size(75, 13);
            this.label_début.TabIndex = 7;
            this.label_début.Text = "Date de début";
            // 
            // label_fin
            // 
            this.label_fin.AutoSize = true;
            this.label_fin.Location = new System.Drawing.Point(6, 165);
            this.label_fin.Name = "label_fin";
            this.label_fin.Size = new System.Drawing.Size(59, 13);
            this.label_fin.TabIndex = 8;
            this.label_fin.Text = "Date de fin";
            // 
            // dateTimePicker_debut
            // 
            this.dateTimePicker_debut.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_debut.Location = new System.Drawing.Point(6, 129);
            this.dateTimePicker_debut.Name = "dateTimePicker_debut";
            this.dateTimePicker_debut.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker_debut.TabIndex = 3;
            this.dateTimePicker_debut.Value = new System.DateTime(2012, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_debut.ValueChanged += new System.EventHandler(this.checkBox_envoyer_CheckedChanged);
            // 
            // Form_HistoriqueFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox_filtre);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_visualisation);
            this.Controls.Add(this.dataGridView_Historique);
            this.Name = "Form_HistoriqueFacture";
            this.Text = "Historique Facture";
            this.Load += new System.EventHandler(this.Form_HistoriqueFacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Historique)).EndInit();
            this.groupBox_filtre.ResumeLayout(false);
            this.groupBox_filtre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Historique;
        private System.Windows.Forms.Button button_visualisation;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.GroupBox groupBox_filtre;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fin;
        private System.Windows.Forms.CheckBox checkBox_tout;
        private System.Windows.Forms.CheckBox checkBox_payer;
        private System.Windows.Forms.CheckBox checkBox_envoyer;
        private System.Windows.Forms.Label label_dateGénération;
        private System.Windows.Forms.Label label_début;
        private System.Windows.Forms.Label label_fin;
        private System.Windows.Forms.DateTimePicker dateTimePicker_debut;
    }
}