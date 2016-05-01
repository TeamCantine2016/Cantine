namespace ProjetCantine.Vues
{
    partial class Form_RecapRepasFamilleMois
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.dataGridView_Membres = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGdVw_DetailFamille = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilleNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBx_RechID = new System.Windows.Forms.TextBox();
            this.txtBx_RechNom = new System.Windows.Forms.TextBox();
            this.label_RechID = new System.Windows.Forms.Label();
            this.lbPeriode = new System.Windows.Forms.Label();
            this.label_RechNom = new System.Windows.Forms.Label();
            this.richTextBox_Recap = new System.Windows.Forms.RichTextBox();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btApercu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Membres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGdVw_DetailFamille)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(825, 55);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 27;
            // 
            // dataGridView_Membres
            // 
            this.dataGridView_Membres.AllowUserToAddRows = false;
            this.dataGridView_Membres.AllowUserToDeleteRows = false;
            this.dataGridView_Membres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Membres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView_Membres.Location = new System.Drawing.Point(574, 55);
            this.dataGridView_Membres.Name = "dataGridView_Membres";
            this.dataGridView_Membres.ReadOnly = true;
            this.dataGridView_Membres.Size = new System.Drawing.Size(245, 161);
            this.dataGridView_Membres.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Membres";
            this.dataGridViewTextBoxColumn1.HeaderText = "Membres";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dGdVw_DetailFamille
            // 
            this.dGdVw_DetailFamille.AllowUserToAddRows = false;
            this.dGdVw_DetailFamille.AllowUserToDeleteRows = false;
            this.dGdVw_DetailFamille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGdVw_DetailFamille.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FamilleNom,
            this.Adresse});
            this.dGdVw_DetailFamille.Location = new System.Drawing.Point(27, 55);
            this.dGdVw_DetailFamille.Name = "dGdVw_DetailFamille";
            this.dGdVw_DetailFamille.ReadOnly = true;
            this.dGdVw_DetailFamille.Size = new System.Drawing.Size(537, 161);
            this.dGdVw_DetailFamille.TabIndex = 25;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // FamilleNom
            // 
            this.FamilleNom.HeaderText = "Famille(Nom)";
            this.FamilleNom.Name = "FamilleNom";
            this.FamilleNom.ReadOnly = true;
            this.FamilleNom.Width = 150;
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            this.Adresse.Width = 300;
            // 
            // txtBx_RechID
            // 
            this.txtBx_RechID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBx_RechID.Location = new System.Drawing.Point(573, 20);
            this.txtBx_RechID.Name = "txtBx_RechID";
            this.txtBx_RechID.Size = new System.Drawing.Size(226, 20);
            this.txtBx_RechID.TabIndex = 24;
            // 
            // txtBx_RechNom
            // 
            this.txtBx_RechNom.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBx_RechNom.Location = new System.Drawing.Point(149, 20);
            this.txtBx_RechNom.Name = "txtBx_RechNom";
            this.txtBx_RechNom.Size = new System.Drawing.Size(226, 20);
            this.txtBx_RechNom.TabIndex = 23;
            // 
            // label_RechID
            // 
            this.label_RechID.AutoSize = true;
            this.label_RechID.Location = new System.Drawing.Point(462, 23);
            this.label_RechID.Name = "label_RechID";
            this.label_RechID.Size = new System.Drawing.Size(92, 13);
            this.label_RechID.TabIndex = 22;
            this.label_RechID.Text = "Recherche par ID";
            // 
            // lbPeriode
            // 
            this.lbPeriode.AutoSize = true;
            this.lbPeriode.Location = new System.Drawing.Point(823, 23);
            this.lbPeriode.Name = "lbPeriode";
            this.lbPeriode.Size = new System.Drawing.Size(115, 13);
            this.lbPeriode.TabIndex = 20;
            this.lbPeriode.Text = "Selectionner la periode";
            // 
            // label_RechNom
            // 
            this.label_RechNom.AutoSize = true;
            this.label_RechNom.Location = new System.Drawing.Point(31, 23);
            this.label_RechNom.Name = "label_RechNom";
            this.label_RechNom.Size = new System.Drawing.Size(101, 13);
            this.label_RechNom.TabIndex = 21;
            this.label_RechNom.Text = "Recherche par nom";
            // 
            // richTextBox_Recap
            // 
            this.richTextBox_Recap.Location = new System.Drawing.Point(27, 244);
            this.richTextBox_Recap.Name = "richTextBox_Recap";
            this.richTextBox_Recap.Size = new System.Drawing.Size(1025, 326);
            this.richTextBox_Recap.TabIndex = 28;
            this.richTextBox_Recap.Text = "";
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(766, 595);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(200, 35);
            this.btAnnuler.TabIndex = 29;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // btApercu
            // 
            this.btApercu.Location = new System.Drawing.Point(106, 595);
            this.btApercu.Name = "btApercu";
            this.btApercu.Size = new System.Drawing.Size(200, 35);
            this.btApercu.TabIndex = 30;
            this.btApercu.Text = "Aperçu";
            this.btApercu.UseVisualStyleBackColor = true;
            // 
            // Form_RecapRepasFamilleMois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.ControlBox = false;
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btApercu);
            this.Controls.Add(this.richTextBox_Recap);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.dataGridView_Membres);
            this.Controls.Add(this.dGdVw_DetailFamille);
            this.Controls.Add(this.txtBx_RechID);
            this.Controls.Add(this.txtBx_RechNom);
            this.Controls.Add(this.label_RechID);
            this.Controls.Add(this.lbPeriode);
            this.Controls.Add(this.label_RechNom);
            this.Name = "Form_RecapRepasFamilleMois";
            this.Text = "Récapitulatif des repas pris par famille sur le mois";
            this.Load += new System.EventHandler(this.Form_RecapRepasFamilleMois_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Membres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGdVw_DetailFamille)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.DataGridView dataGridView_Membres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dGdVw_DetailFamille;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilleNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.TextBox txtBx_RechID;
        private System.Windows.Forms.TextBox txtBx_RechNom;
        private System.Windows.Forms.Label label_RechID;
        private System.Windows.Forms.Label lbPeriode;
        private System.Windows.Forms.Label label_RechNom;
        private System.Windows.Forms.RichTextBox richTextBox_Recap;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btApercu;
    }
}