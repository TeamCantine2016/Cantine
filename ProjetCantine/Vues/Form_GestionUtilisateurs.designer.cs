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
            this.db_cantineDataSet = new ProjetCantine.Models.db_cantineDataSet();
            this.tAListeUtilisateursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tA_Liste_Utilisateurs_query = new ProjetCantine.Models.db_cantineDataSetTableAdapters.TA_Liste_Utilisateurs_query();
            this.pseudonymeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.droitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GestionUtilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAListeUtilisateursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_GestionUtilisateur
            // 
            this.dataGridView_GestionUtilisateur.AutoGenerateColumns = false;
            this.dataGridView_GestionUtilisateur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_GestionUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GestionUtilisateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pseudonymeDataGridViewTextBoxColumn,
            this.prénomDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.adresseMailDataGridViewTextBoxColumn,
            this.droitsDataGridViewTextBoxColumn,
            this.etatDataGridViewCheckBoxColumn});
            this.dataGridView_GestionUtilisateur.DataSource = this.tAListeUtilisateursBindingSource;
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
            // db_cantineDataSet
            // 
            this.db_cantineDataSet.DataSetName = "db_cantineDataSet";
            this.db_cantineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAListeUtilisateursBindingSource
            // 
            this.tAListeUtilisateursBindingSource.DataMember = "TA_Liste_Utilisateurs";
            this.tAListeUtilisateursBindingSource.DataSource = this.db_cantineDataSet;
            // 
            // tA_Liste_Utilisateurs_query
            // 
            this.tA_Liste_Utilisateurs_query.ClearBeforeFill = true;
            // 
            // pseudonymeDataGridViewTextBoxColumn
            // 
            this.pseudonymeDataGridViewTextBoxColumn.DataPropertyName = "Pseudonyme";
            this.pseudonymeDataGridViewTextBoxColumn.HeaderText = "Pseudonyme";
            this.pseudonymeDataGridViewTextBoxColumn.Name = "pseudonymeDataGridViewTextBoxColumn";
            // 
            // prénomDataGridViewTextBoxColumn
            // 
            this.prénomDataGridViewTextBoxColumn.DataPropertyName = "Prénom";
            this.prénomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prénomDataGridViewTextBoxColumn.Name = "prénomDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // adresseMailDataGridViewTextBoxColumn
            // 
            this.adresseMailDataGridViewTextBoxColumn.DataPropertyName = "Adresse mail";
            this.adresseMailDataGridViewTextBoxColumn.HeaderText = "Adresse mail";
            this.adresseMailDataGridViewTextBoxColumn.Name = "adresseMailDataGridViewTextBoxColumn";
            // 
            // droitsDataGridViewTextBoxColumn
            // 
            this.droitsDataGridViewTextBoxColumn.DataPropertyName = "Droits";
            this.droitsDataGridViewTextBoxColumn.HeaderText = "Droits";
            this.droitsDataGridViewTextBoxColumn.Name = "droitsDataGridViewTextBoxColumn";
            // 
            // etatDataGridViewCheckBoxColumn
            // 
            this.etatDataGridViewCheckBoxColumn.DataPropertyName = "Etat";
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
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAListeUtilisateursBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_GestionUtilisateur;
        private System.Windows.Forms.Button button_Nouveau;
        private System.Windows.Forms.Button button_Editer;
        private System.Windows.Forms.Button button_supprimer;
        private Models.db_cantineDataSet db_cantineDataSet;
        private System.Windows.Forms.BindingSource tAListeUtilisateursBindingSource;
        private Models.db_cantineDataSetTableAdapters.TA_Liste_Utilisateurs_query tA_Liste_Utilisateurs_query;
        private System.Windows.Forms.DataGridViewTextBoxColumn pseudonymeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn droitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn etatDataGridViewCheckBoxColumn;
    }
}