namespace ProjetCantine
{
    partial class Form_EncodageElève
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
            this.label_Nom = new System.Windows.Forms.Label();
            this.label_Prénom = new System.Windows.Forms.Label();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.label_DateNaissance = new System.Windows.Forms.Label();
            this.textBox_Famille = new System.Windows.Forms.TextBox();
            this.checkBox_Cantine = new System.Windows.Forms.CheckBox();
            this.checkBox_Natation = new System.Windows.Forms.CheckBox();
            this.checkBox_Bibliothèque = new System.Windows.Forms.CheckBox();
            this.button_Valider = new System.Windows.Forms.Button();
            this.button_Annuler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker_DateNaissance = new System.Windows.Forms.DateTimePicker();
            this.textBox_Prénom = new System.Windows.Forms.TextBox();
            this.groupBox_Activite = new System.Windows.Forms.GroupBox();
            this.dataGridView_Tuteur = new System.Windows.Forms.DataGridView();
            this.groupBox_Activite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tuteur)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(13, 15);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(29, 13);
            this.label_Nom.TabIndex = 3;
            this.label_Nom.Text = "Nom";
            // 
            // label_Prénom
            // 
            this.label_Prénom.AutoSize = true;
            this.label_Prénom.Location = new System.Drawing.Point(13, 41);
            this.label_Prénom.Name = "label_Prénom";
            this.label_Prénom.Size = new System.Drawing.Size(43, 13);
            this.label_Prénom.TabIndex = 3;
            this.label_Prénom.Text = "Prénom";
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(114, 12);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(348, 20);
            this.textBox_Nom.TabIndex = 0;
            // 
            // label_DateNaissance
            // 
            this.label_DateNaissance.AutoSize = true;
            this.label_DateNaissance.Location = new System.Drawing.Point(13, 68);
            this.label_DateNaissance.Name = "label_DateNaissance";
            this.label_DateNaissance.Size = new System.Drawing.Size(96, 13);
            this.label_DateNaissance.TabIndex = 3;
            this.label_DateNaissance.Text = "Date de naissance";
            // 
            // textBox_Famille
            // 
            this.textBox_Famille.Enabled = false;
            this.textBox_Famille.Location = new System.Drawing.Point(114, 91);
            this.textBox_Famille.Name = "textBox_Famille";
            this.textBox_Famille.Size = new System.Drawing.Size(218, 20);
            this.textBox_Famille.TabIndex = 55;
            this.textBox_Famille.TabStop = false;
            this.textBox_Famille.Text = "Id_Famille / Nom";
            // 
            // checkBox_Cantine
            // 
            this.checkBox_Cantine.AutoSize = true;
            this.checkBox_Cantine.Location = new System.Drawing.Point(6, 29);
            this.checkBox_Cantine.Name = "checkBox_Cantine";
            this.checkBox_Cantine.Size = new System.Drawing.Size(62, 17);
            this.checkBox_Cantine.TabIndex = 60;
            this.checkBox_Cantine.Text = "Cantine";
            this.checkBox_Cantine.UseVisualStyleBackColor = true;
            // 
            // checkBox_Natation
            // 
            this.checkBox_Natation.AutoSize = true;
            this.checkBox_Natation.Location = new System.Drawing.Point(6, 51);
            this.checkBox_Natation.Name = "checkBox_Natation";
            this.checkBox_Natation.Size = new System.Drawing.Size(66, 17);
            this.checkBox_Natation.TabIndex = 65;
            this.checkBox_Natation.Text = "Natation";
            this.checkBox_Natation.UseVisualStyleBackColor = true;
            // 
            // checkBox_Bibliothèque
            // 
            this.checkBox_Bibliothèque.AutoSize = true;
            this.checkBox_Bibliothèque.Location = new System.Drawing.Point(6, 74);
            this.checkBox_Bibliothèque.Name = "checkBox_Bibliothèque";
            this.checkBox_Bibliothèque.Size = new System.Drawing.Size(84, 17);
            this.checkBox_Bibliothèque.TabIndex = 70;
            this.checkBox_Bibliothèque.Text = "Bibliothèque";
            this.checkBox_Bibliothèque.UseVisualStyleBackColor = true;
            // 
            // button_Valider
            // 
            this.button_Valider.Location = new System.Drawing.Point(51, 429);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(160, 23);
            this.button_Valider.TabIndex = 90;
            this.button_Valider.Text = "Confirmation / Modification";
            this.button_Valider.UseVisualStyleBackColor = true;
            this.button_Valider.Click += new System.EventHandler(this.button_Valider_Click);
            // 
            // button_Annuler
            // 
            this.button_Annuler.Location = new System.Drawing.Point(261, 429);
            this.button_Annuler.Name = "button_Annuler";
            this.button_Annuler.Size = new System.Drawing.Size(160, 23);
            this.button_Annuler.TabIndex = 95;
            this.button_Annuler.Text = "Annuler";
            this.button_Annuler.UseVisualStyleBackColor = true;
            this.button_Annuler.Click += new System.EventHandler(this.button_Annuler_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_DateNaissance
            // 
            this.dateTimePicker_DateNaissance.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_DateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DateNaissance.Location = new System.Drawing.Point(114, 65);
            this.dateTimePicker_DateNaissance.Name = "dateTimePicker_DateNaissance";
            this.dateTimePicker_DateNaissance.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker_DateNaissance.TabIndex = 35;
            // 
            // textBox_Prénom
            // 
            this.textBox_Prénom.Location = new System.Drawing.Point(114, 39);
            this.textBox_Prénom.Name = "textBox_Prénom";
            this.textBox_Prénom.Size = new System.Drawing.Size(348, 20);
            this.textBox_Prénom.TabIndex = 5;
            // 
            // groupBox_Activite
            // 
            this.groupBox_Activite.Controls.Add(this.checkBox_Natation);
            this.groupBox_Activite.Controls.Add(this.checkBox_Cantine);
            this.groupBox_Activite.Controls.Add(this.checkBox_Bibliothèque);
            this.groupBox_Activite.Location = new System.Drawing.Point(16, 117);
            this.groupBox_Activite.Name = "groupBox_Activite";
            this.groupBox_Activite.Size = new System.Drawing.Size(141, 97);
            this.groupBox_Activite.TabIndex = 96;
            this.groupBox_Activite.TabStop = false;
            this.groupBox_Activite.Text = "Activité";
            // 
            // dataGridView_Tuteur
            // 
            this.dataGridView_Tuteur.AllowUserToAddRows = false;
            this.dataGridView_Tuteur.AllowUserToDeleteRows = false;
            this.dataGridView_Tuteur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Tuteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tuteur.Location = new System.Drawing.Point(16, 229);
            this.dataGridView_Tuteur.MultiSelect = false;
            this.dataGridView_Tuteur.Name = "dataGridView_Tuteur";
            this.dataGridView_Tuteur.ReadOnly = true;
            this.dataGridView_Tuteur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Tuteur.Size = new System.Drawing.Size(446, 194);
            this.dataGridView_Tuteur.TabIndex = 97;
            this.dataGridView_Tuteur.TabStop = false;
            // 
            // Form_EncodageElève
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 464);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView_Tuteur);
            this.Controls.Add(this.groupBox_Activite);
            this.Controls.Add(this.textBox_Prénom);
            this.Controls.Add(this.dateTimePicker_DateNaissance);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Annuler);
            this.Controls.Add(this.button_Valider);
            this.Controls.Add(this.textBox_Famille);
            this.Controls.Add(this.textBox_Nom);
            this.Controls.Add(this.label_DateNaissance);
            this.Controls.Add(this.label_Prénom);
            this.Controls.Add(this.label_Nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_EncodageElève";
            this.Text = "Encodage élève";
            this.Load += new System.EventHandler(this.Form_EncodageElève_Load);
            this.groupBox_Activite.ResumeLayout(false);
            this.groupBox_Activite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tuteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Nom;
        private System.Windows.Forms.Label label_Prénom;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.Label label_DateNaissance;
        private System.Windows.Forms.TextBox textBox_Famille;
        private System.Windows.Forms.CheckBox checkBox_Cantine;
        private System.Windows.Forms.CheckBox checkBox_Natation;
        private System.Windows.Forms.CheckBox checkBox_Bibliothèque;
        private System.Windows.Forms.Button button_Valider;
        private System.Windows.Forms.Button button_Annuler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateNaissance;
        private System.Windows.Forms.TextBox textBox_Prénom;
        private System.Windows.Forms.GroupBox groupBox_Activite;
        private System.Windows.Forms.DataGridView dataGridView_Tuteur;
    }
}