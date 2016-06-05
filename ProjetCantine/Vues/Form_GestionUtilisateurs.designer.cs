namespace ProjetCantine
{
    partial class Form_GestionUtilisateurs
    {
        /// <summary>
        /// Required designer variable.
        public Form_EncodageUtilisateur FEU;
        public int flag;
        public string psd;
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
            this.dataGridView_GestionUtilisateur = new System.Windows.Forms.DataGridView();
            this.Pseudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Courriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Droits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button_Nouveau = new System.Windows.Forms.Button();
            this.button_Editer = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GestionUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_GestionUtilisateur
            // 
            this.dataGridView_GestionUtilisateur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_GestionUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GestionUtilisateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pseudo,
            this.Prenom,
            this.Nom,
            this.Courriel,
            this.Droits,
            this.Etat});
            this.dataGridView_GestionUtilisateur.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_GestionUtilisateur.Name = "dataGridView_GestionUtilisateur";
            this.dataGridView_GestionUtilisateur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_GestionUtilisateur.Size = new System.Drawing.Size(1060, 565);
            this.dataGridView_GestionUtilisateur.TabIndex = 0;
            this.dataGridView_GestionUtilisateur.TabStop = false;
            // 
            // Pseudo
            // 
            this.Pseudo.HeaderText = "Pseudo";
            this.Pseudo.Name = "Pseudo";
            this.Pseudo.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Courriel
            // 
            this.Courriel.HeaderText = "Courriel";
            this.Courriel.Name = "Courriel";
            this.Courriel.ReadOnly = true;
            // 
            // Droits
            // 
            this.Droits.HeaderText = "Droits";
            this.Droits.Name = "Droits";
            this.Droits.ReadOnly = true;
            // 
            // Etat
            // 
            this.Etat.HeaderText = "Etat";
            this.Etat.Name = "Etat";
            this.Etat.ReadOnly = true;
            // 
            // button_Nouveau
            // 
            this.button_Nouveau.Location = new System.Drawing.Point(110, 583);
            this.button_Nouveau.Name = "button_Nouveau";
            this.button_Nouveau.Size = new System.Drawing.Size(200, 35);
            this.button_Nouveau.TabIndex = 1;
            this.button_Nouveau.Text = "Nouvel utilisateur";
            this.button_Nouveau.UseVisualStyleBackColor = true;
            this.button_Nouveau.Click += new System.EventHandler(this.button_Nouveau_Click);
            // 
            // button_Editer
            // 
            this.button_Editer.Location = new System.Drawing.Point(445, 583);
            this.button_Editer.Name = "button_Editer";
            this.button_Editer.Size = new System.Drawing.Size(200, 35);
            this.button_Editer.TabIndex = 2;
            this.button_Editer.Text = "Edition de l\'utilisateur";
            this.button_Editer.UseVisualStyleBackColor = true;
            this.button_Editer.Click += new System.EventHandler(this.button_Editer_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(770, 583);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(200, 35);
            this.button_supprimer.TabIndex = 3;
            this.button_supprimer.Text = "Supprimer utilisateur";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // Form_GestionUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 662);
            this.ControlBox = false;
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_Editer);
            this.Controls.Add(this.button_Nouveau);
            this.Controls.Add(this.dataGridView_GestionUtilisateur);
            this.Name = "Form_GestionUtilisateurs";
            this.Text = "Gestion des utilisateurs";
            this.Load += new System.EventHandler(this.Form_GestionUtilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GestionUtilisateur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_GestionUtilisateur;
        private System.Windows.Forms.Button button_Nouveau;
        private System.Windows.Forms.Button button_Editer;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pseudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Courriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Droits;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Etat;
    }
}