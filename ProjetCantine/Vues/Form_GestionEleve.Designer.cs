namespace ProjetCantine
{
    partial class Form_GestionEleve
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
            this.dataGridView_Eleve = new System.Windows.Forms.DataGridView();
            this.button_Nouveau = new System.Windows.Forms.Button();
            this.button_Editer = new System.Windows.Forms.Button();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.db_cantineDataSet = new ProjetCantine.Models.db_cantineDataSet();
            this.tAListesPersonnesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tA_Listes_Personnes_query = new ProjetCantine.Models.db_cantineDataSetTableAdapters.TA_Listes_Personnes_query();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Eleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAListesPersonnesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Eleve
            // 
            this.dataGridView_Eleve.AllowUserToAddRows = false;
            this.dataGridView_Eleve.AllowUserToDeleteRows = false;
            this.dataGridView_Eleve.AutoGenerateColumns = false;
            this.dataGridView_Eleve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Eleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Eleve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prénomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.paysDataGridViewTextBoxColumn});
            this.dataGridView_Eleve.DataSource = this.tAListesPersonnesBindingSource;
            this.dataGridView_Eleve.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Eleve.Name = "dataGridView_Eleve";
            this.dataGridView_Eleve.ReadOnly = true;
            this.dataGridView_Eleve.Size = new System.Drawing.Size(1060, 565);
            this.dataGridView_Eleve.TabIndex = 0;
            this.dataGridView_Eleve.TabStop = false;
            // 
            // button_Nouveau
            // 
            this.button_Nouveau.Location = new System.Drawing.Point(110, 583);
            this.button_Nouveau.Name = "button_Nouveau";
            this.button_Nouveau.Size = new System.Drawing.Size(200, 35);
            this.button_Nouveau.TabIndex = 0;
            this.button_Nouveau.Text = "Nouvel élève";
            this.button_Nouveau.UseVisualStyleBackColor = true;
            this.button_Nouveau.Click += new System.EventHandler(this.button_Nouveau_Click);
            // 
            // button_Editer
            // 
            this.button_Editer.Location = new System.Drawing.Point(445, 583);
            this.button_Editer.Name = "button_Editer";
            this.button_Editer.Size = new System.Drawing.Size(200, 35);
            this.button_Editer.TabIndex = 5;
            this.button_Editer.Text = "Edition de l\'élève";
            this.button_Editer.UseVisualStyleBackColor = true;
            this.button_Editer.Click += new System.EventHandler(this.button_Editer_Click);
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Location = new System.Drawing.Point(770, 583);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(200, 35);
            this.button_Supprimer.TabIndex = 10;
            this.button_Supprimer.Text = "Supprimer l\'élève";
            this.button_Supprimer.UseVisualStyleBackColor = true;
            // 
            // db_cantineDataSet
            // 
            this.db_cantineDataSet.DataSetName = "db_cantineDataSet";
            this.db_cantineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAListesPersonnesBindingSource
            // 
            this.tAListesPersonnesBindingSource.DataMember = "TA_Listes_Personnes";
            this.tAListesPersonnesBindingSource.DataSource = this.db_cantineDataSet;
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
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prénomDataGridViewTextBoxColumn
            // 
            this.prénomDataGridViewTextBoxColumn.DataPropertyName = "Prénom";
            this.prénomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prénomDataGridViewTextBoxColumn.Name = "prénomDataGridViewTextBoxColumn";
            this.prénomDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Form_GestionEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.ControlBox = false;
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.button_Editer);
            this.Controls.Add(this.button_Nouveau);
            this.Controls.Add(this.dataGridView_Eleve);
            this.Name = "Form_GestionEleve";
            this.Text = "Gestion des élèves";
            this.Load += new System.EventHandler(this.Form_GestionEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Eleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAListesPersonnesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Eleve;
        private System.Windows.Forms.Button button_Nouveau;
        private System.Windows.Forms.Button button_Editer;
        private System.Windows.Forms.Button button_Supprimer;
        private Models.db_cantineDataSet db_cantineDataSet;
        private System.Windows.Forms.BindingSource tAListesPersonnesBindingSource;
        private Models.db_cantineDataSetTableAdapters.TA_Listes_Personnes_query tA_Listes_Personnes_query;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paysDataGridViewTextBoxColumn;
    }
}