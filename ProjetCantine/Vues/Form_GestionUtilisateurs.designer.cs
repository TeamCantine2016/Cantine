namespace ProjetCantine
{
    partial class Form_GestionUtilisateur
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
            this.dataGridView_GestionUtilisateur = new System.Windows.Forms.DataGridView();
            this.button_Nouveau = new System.Windows.Forms.Button();
            this.button_Editer = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.dataSet_Cantine = new ProjetCantine.Models.DataSet_Cantine();
            this.utilisateursdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tA_utilisateurs_details = new ProjetCantine.Models.DataSet_CantineTableAdapters.TA_utilisateurs_details();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pseudoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.droitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GestionUtilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Cantine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateursdetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_GestionUtilisateur
            // 
            this.dataGridView_GestionUtilisateur.AutoGenerateColumns = false;
            this.dataGridView_GestionUtilisateur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_GestionUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GestionUtilisateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prenomDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.pseudoDataGridViewTextBoxColumn,
            this.droitsDataGridViewTextBoxColumn,
            this.etatDataGridViewCheckBoxColumn});
            this.dataGridView_GestionUtilisateur.DataSource = this.utilisateursdetailsBindingSource;
            this.dataGridView_GestionUtilisateur.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_GestionUtilisateur.Name = "dataGridView_GestionUtilisateur";
            this.dataGridView_GestionUtilisateur.Size = new System.Drawing.Size(1060, 565);
            this.dataGridView_GestionUtilisateur.TabIndex = 0;
            this.dataGridView_GestionUtilisateur.TabStop = false;
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
            // 
            // dataSet_Cantine
            // 
            this.dataSet_Cantine.DataSetName = "DataSet_Cantine";
            this.dataSet_Cantine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateursdetailsBindingSource
            // 
            this.utilisateursdetailsBindingSource.DataMember = "utilisateurs_details";
            this.utilisateursdetailsBindingSource.DataSource = this.dataSet_Cantine;
            // 
            // tA_utilisateurs_details
            // 
            this.tA_utilisateurs_details.ClearBeforeFill = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // pseudoDataGridViewTextBoxColumn
            // 
            this.pseudoDataGridViewTextBoxColumn.DataPropertyName = "pseudo";
            this.pseudoDataGridViewTextBoxColumn.HeaderText = "Pseudonyme";
            this.pseudoDataGridViewTextBoxColumn.Name = "pseudoDataGridViewTextBoxColumn";
            // 
            // droitsDataGridViewTextBoxColumn
            // 
            this.droitsDataGridViewTextBoxColumn.DataPropertyName = "droits";
            this.droitsDataGridViewTextBoxColumn.HeaderText = "Droits";
            this.droitsDataGridViewTextBoxColumn.Name = "droitsDataGridViewTextBoxColumn";
            // 
            // etatDataGridViewCheckBoxColumn
            // 
            this.etatDataGridViewCheckBoxColumn.DataPropertyName = "etat";
            this.etatDataGridViewCheckBoxColumn.HeaderText = "Etat";
            this.etatDataGridViewCheckBoxColumn.Name = "etatDataGridViewCheckBoxColumn";
            // 
            // Form_GestionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 662);
            this.ControlBox = false;
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_Editer);
            this.Controls.Add(this.button_Nouveau);
            this.Controls.Add(this.dataGridView_GestionUtilisateur);
            this.Name = "Form_GestionUtilisateur";
            this.Text = "Gestion des utilisateurs";
            this.Load += new System.EventHandler(this.Form_GestionUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GestionUtilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Cantine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateursdetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_GestionUtilisateur;
        private System.Windows.Forms.Button button_Nouveau;
        private System.Windows.Forms.Button button_Editer;
        private System.Windows.Forms.Button button_supprimer;
        private Models.DataSet_Cantine dataSet_Cantine;
        private System.Windows.Forms.BindingSource utilisateursdetailsBindingSource;
        private Models.DataSet_CantineTableAdapters.TA_utilisateurs_details tA_utilisateurs_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pseudoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn droitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn etatDataGridViewCheckBoxColumn;
    }
}