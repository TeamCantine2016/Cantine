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
            this.Id_Elève = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Nouveau = new System.Windows.Forms.Button();
            this.button_Editer = new System.Windows.Forms.Button();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.dataSet_Cantine = new ProjetCantine.Models.DataSet_Cantine();
            this.tblpersonneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_personneTableAdapter = new ProjetCantine.Models.DataSet_CantineTableAdapters.tbl_personneTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Eleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Cantine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Eleve
            // 
            this.dataGridView_Eleve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Eleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Eleve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Elève,
            this.Nom,
            this.Prénom,
            this.Adresse});
            this.dataGridView_Eleve.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tblpersonneBindingSource, "id", true));
            this.dataGridView_Eleve.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Eleve.Name = "dataGridView_Eleve";
            this.dataGridView_Eleve.Size = new System.Drawing.Size(1060, 565);
            this.dataGridView_Eleve.TabIndex = 0;
            this.dataGridView_Eleve.TabStop = false;
            // 
            // Id_Elève
            // 
            this.Id_Elève.HeaderText = "Id_Elève";
            this.Id_Elève.Name = "Id_Elève";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prénom
            // 
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.Name = "Prénom";
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
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
            // dataSet_Cantine
            // 
            this.dataSet_Cantine.DataSetName = "DataSet_Cantine";
            this.dataSet_Cantine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblpersonneBindingSource
            // 
            this.tblpersonneBindingSource.DataMember = "tbl_personne";
            this.tblpersonneBindingSource.DataSource = this.dataSet_Cantine;
            // 
            // tbl_personneTableAdapter
            // 
            this.tbl_personneTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Cantine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Eleve;
        private System.Windows.Forms.Button button_Nouveau;
        private System.Windows.Forms.Button button_Editer;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Elève;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private Models.DataSet_Cantine dataSet_Cantine;
        private System.Windows.Forms.BindingSource tblpersonneBindingSource;
        private Models.DataSet_CantineTableAdapters.tbl_personneTableAdapter tbl_personneTableAdapter;
    }
}