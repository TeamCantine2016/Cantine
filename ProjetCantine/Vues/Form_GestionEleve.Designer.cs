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
            this.tAListesPersonnesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_cantineDataSet = new ProjetCantine.Models.db_cantineDataSet();
            this.button_Nouveau = new System.Windows.Forms.Button();
            this.button_Editer = new System.Windows.Forms.Button();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.tA_Listes_Personnes_query = new ProjetCantine.Models.db_cantineDataSetTableAdapters.TA_Listes_Personnes_query();
            this.groupBox_eleve = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Tuteur = new System.Windows.Forms.DataGridView();
            this.button_SupprimerTuteur = new System.Windows.Forms.Button();
            this.button_EditionTuteur = new System.Windows.Forms.Button();
            this.button_NouveauTuteur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Eleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAListesPersonnesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet)).BeginInit();
            this.groupBox_eleve.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tuteur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Eleve
            // 
            this.dataGridView_Eleve.AllowUserToAddRows = false;
            this.dataGridView_Eleve.AllowUserToDeleteRows = false;
            this.dataGridView_Eleve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Eleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Eleve.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Eleve.Name = "dataGridView_Eleve";
            this.dataGridView_Eleve.ReadOnly = true;
            this.dataGridView_Eleve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Eleve.Size = new System.Drawing.Size(1048, 211);
            this.dataGridView_Eleve.TabIndex = 0;
            this.dataGridView_Eleve.TabStop = false;
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
            // button_Nouveau
            // 
            this.button_Nouveau.Location = new System.Drawing.Point(96, 236);
            this.button_Nouveau.Name = "button_Nouveau";
            this.button_Nouveau.Size = new System.Drawing.Size(200, 35);
            this.button_Nouveau.TabIndex = 0;
            this.button_Nouveau.Text = "Nouvel élève";
            this.button_Nouveau.UseVisualStyleBackColor = true;
            this.button_Nouveau.Click += new System.EventHandler(this.button_Nouveau_Click);
            // 
            // button_Editer
            // 
            this.button_Editer.Location = new System.Drawing.Point(431, 236);
            this.button_Editer.Name = "button_Editer";
            this.button_Editer.Size = new System.Drawing.Size(200, 35);
            this.button_Editer.TabIndex = 5;
            this.button_Editer.Text = "Edition de l\'élève";
            this.button_Editer.UseVisualStyleBackColor = true;
            this.button_Editer.Click += new System.EventHandler(this.button_Editer_Click);
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Location = new System.Drawing.Point(756, 236);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(200, 35);
            this.button_Supprimer.TabIndex = 10;
            this.button_Supprimer.Text = "Supprimer l\'élève";
            this.button_Supprimer.UseVisualStyleBackColor = true;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // tA_Listes_Personnes_query
            // 
            this.tA_Listes_Personnes_query.ClearBeforeFill = true;
            // 
            // groupBox_eleve
            // 
            this.groupBox_eleve.Controls.Add(this.dataGridView_Eleve);
            this.groupBox_eleve.Controls.Add(this.button_Supprimer);
            this.groupBox_eleve.Controls.Add(this.button_Editer);
            this.groupBox_eleve.Controls.Add(this.button_Nouveau);
            this.groupBox_eleve.Location = new System.Drawing.Point(12, 12);
            this.groupBox_eleve.Name = "groupBox_eleve";
            this.groupBox_eleve.Size = new System.Drawing.Size(1060, 279);
            this.groupBox_eleve.TabIndex = 11;
            this.groupBox_eleve.TabStop = false;
            this.groupBox_eleve.Text = "Gestion élèves";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_Tuteur);
            this.groupBox1.Controls.Add(this.button_SupprimerTuteur);
            this.groupBox1.Controls.Add(this.button_EditionTuteur);
            this.groupBox1.Controls.Add(this.button_NouveauTuteur);
            this.groupBox1.Location = new System.Drawing.Point(12, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 284);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion tuteurs";
            // 
            // dataGridView_Tuteur
            // 
            this.dataGridView_Tuteur.AllowUserToAddRows = false;
            this.dataGridView_Tuteur.AllowUserToDeleteRows = false;
            this.dataGridView_Tuteur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Tuteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tuteur.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Tuteur.Name = "dataGridView_Tuteur";
            this.dataGridView_Tuteur.ReadOnly = true;
            this.dataGridView_Tuteur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Tuteur.Size = new System.Drawing.Size(1048, 211);
            this.dataGridView_Tuteur.TabIndex = 0;
            this.dataGridView_Tuteur.TabStop = false;
            // 
            // button_SupprimerTuteur
            // 
            this.button_SupprimerTuteur.Location = new System.Drawing.Point(756, 236);
            this.button_SupprimerTuteur.Name = "button_SupprimerTuteur";
            this.button_SupprimerTuteur.Size = new System.Drawing.Size(200, 35);
            this.button_SupprimerTuteur.TabIndex = 25;
            this.button_SupprimerTuteur.Text = "Supprimer tuteur";
            this.button_SupprimerTuteur.UseVisualStyleBackColor = true;
            this.button_SupprimerTuteur.Click += new System.EventHandler(this.button_SupprimerTuteur_Click);
            // 
            // button_EditionTuteur
            // 
            this.button_EditionTuteur.Location = new System.Drawing.Point(431, 236);
            this.button_EditionTuteur.Name = "button_EditionTuteur";
            this.button_EditionTuteur.Size = new System.Drawing.Size(200, 35);
            this.button_EditionTuteur.TabIndex = 20;
            this.button_EditionTuteur.Text = "Edition du tuteur";
            this.button_EditionTuteur.UseVisualStyleBackColor = true;
            this.button_EditionTuteur.Click += new System.EventHandler(this.button_EditionTuteur_Click);
            // 
            // button_NouveauTuteur
            // 
            this.button_NouveauTuteur.Location = new System.Drawing.Point(96, 236);
            this.button_NouveauTuteur.Name = "button_NouveauTuteur";
            this.button_NouveauTuteur.Size = new System.Drawing.Size(200, 35);
            this.button_NouveauTuteur.TabIndex = 15;
            this.button_NouveauTuteur.Text = "Nouveau tuteur";
            this.button_NouveauTuteur.UseVisualStyleBackColor = true;
            this.button_NouveauTuteur.Click += new System.EventHandler(this.button_NouveauTuteur_Click);
            // 
            // Form_GestionEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_eleve);
            this.Name = "Form_GestionEleve";
            this.Text = "Gestion des élèves et des tuteurs";
            this.Load += new System.EventHandler(this.Form_GestionEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Eleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAListesPersonnesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_cantineDataSet)).EndInit();
            this.groupBox_eleve.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tuteur)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox_eleve;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_Tuteur;
        private System.Windows.Forms.Button button_SupprimerTuteur;
        private System.Windows.Forms.Button button_EditionTuteur;
        private System.Windows.Forms.Button button_NouveauTuteur;
    }
}