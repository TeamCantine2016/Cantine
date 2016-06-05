namespace ProjetCantine
{
    partial class Form_EncodageTuteur
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
            this.textBox_Pays = new System.Windows.Forms.TextBox();
            this.textBox_Prénom = new System.Windows.Forms.TextBox();
            this.dateTimePicker_DateNaissance = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Annuler = new System.Windows.Forms.Button();
            this.button_Valider = new System.Windows.Forms.Button();
            this.textBox_Famille = new System.Windows.Forms.TextBox();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.textBox_Téléphone = new System.Windows.Forms.TextBox();
            this.textBox_Ville = new System.Windows.Forms.TextBox();
            this.textBox_CP = new System.Windows.Forms.TextBox();
            this.textBox_Numéro = new System.Windows.Forms.TextBox();
            this.textBox_Rue = new System.Windows.Forms.TextBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Numéro = new System.Windows.Forms.Label();
            this.label_Mail = new System.Windows.Forms.Label();
            this.label_Téléphone = new System.Windows.Forms.Label();
            this.label_DateNaissance = new System.Windows.Forms.Label();
            this.label_Pays = new System.Windows.Forms.Label();
            this.label_Ville = new System.Windows.Forms.Label();
            this.label_Rue = new System.Windows.Forms.Label();
            this.label_Prénom = new System.Windows.Forms.Label();
            this.label_Nom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Pays
            // 
            this.textBox_Pays.Location = new System.Drawing.Point(119, 117);
            this.textBox_Pays.Name = "textBox_Pays";
            this.textBox_Pays.Size = new System.Drawing.Size(125, 20);
            this.textBox_Pays.TabIndex = 40;
            // 
            // textBox_Prénom
            // 
            this.textBox_Prénom.Location = new System.Drawing.Point(119, 40);
            this.textBox_Prénom.Name = "textBox_Prénom";
            this.textBox_Prénom.Size = new System.Drawing.Size(348, 20);
            this.textBox_Prénom.TabIndex = 15;
            // 
            // dateTimePicker_DateNaissance
            // 
            this.dateTimePicker_DateNaissance.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_DateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DateNaissance.Location = new System.Drawing.Point(119, 143);
            this.dateTimePicker_DateNaissance.Name = "dateTimePicker_DateNaissance";
            this.dateTimePicker_DateNaissance.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker_DateNaissance.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 109;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_Annuler
            // 
            this.button_Annuler.Location = new System.Drawing.Point(267, 257);
            this.button_Annuler.Name = "button_Annuler";
            this.button_Annuler.Size = new System.Drawing.Size(160, 23);
            this.button_Annuler.TabIndex = 65;
            this.button_Annuler.Text = "Annuler";
            this.button_Annuler.UseVisualStyleBackColor = true;
            this.button_Annuler.Click += new System.EventHandler(this.button_Annuler_Click);
            // 
            // button_Valider
            // 
            this.button_Valider.Location = new System.Drawing.Point(57, 257);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(160, 23);
            this.button_Valider.TabIndex = 60;
            this.button_Valider.Text = "Confirmation / Modification";
            this.button_Valider.UseVisualStyleBackColor = true;
            this.button_Valider.Click += new System.EventHandler(this.button_Valider_Click);
            // 
            // textBox_Famille
            // 
            this.textBox_Famille.Enabled = false;
            this.textBox_Famille.Location = new System.Drawing.Point(119, 221);
            this.textBox_Famille.Name = "textBox_Famille";
            this.textBox_Famille.Size = new System.Drawing.Size(218, 20);
            this.textBox_Famille.TabIndex = 118;
            this.textBox_Famille.TabStop = false;
            this.textBox_Famille.Text = "Id_Famille / Nom";
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(119, 195);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(218, 20);
            this.textBox_Mail.TabIndex = 55;
            // 
            // textBox_Téléphone
            // 
            this.textBox_Téléphone.Location = new System.Drawing.Point(119, 169);
            this.textBox_Téléphone.Name = "textBox_Téléphone";
            this.textBox_Téléphone.Size = new System.Drawing.Size(218, 20);
            this.textBox_Téléphone.TabIndex = 50;
            // 
            // textBox_Ville
            // 
            this.textBox_Ville.Location = new System.Drawing.Point(119, 91);
            this.textBox_Ville.Name = "textBox_Ville";
            this.textBox_Ville.Size = new System.Drawing.Size(125, 20);
            this.textBox_Ville.TabIndex = 30;
            // 
            // textBox_CP
            // 
            this.textBox_CP.Location = new System.Drawing.Point(400, 91);
            this.textBox_CP.Name = "textBox_CP";
            this.textBox_CP.Size = new System.Drawing.Size(67, 20);
            this.textBox_CP.TabIndex = 35;
            // 
            // textBox_Numéro
            // 
            this.textBox_Numéro.Location = new System.Drawing.Point(400, 65);
            this.textBox_Numéro.Name = "textBox_Numéro";
            this.textBox_Numéro.Size = new System.Drawing.Size(67, 20);
            this.textBox_Numéro.TabIndex = 25;
            // 
            // textBox_Rue
            // 
            this.textBox_Rue.Location = new System.Drawing.Point(119, 65);
            this.textBox_Rue.Name = "textBox_Rue";
            this.textBox_Rue.Size = new System.Drawing.Size(218, 20);
            this.textBox_Rue.TabIndex = 20;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(119, 13);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(348, 20);
            this.textBox_Nom.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 107;
            this.label1.Text = "C.P.";
            // 
            // label_Numéro
            // 
            this.label_Numéro.AutoSize = true;
            this.label_Numéro.Location = new System.Drawing.Point(348, 68);
            this.label_Numéro.Name = "label_Numéro";
            this.label_Numéro.Size = new System.Drawing.Size(44, 13);
            this.label_Numéro.TabIndex = 106;
            this.label_Numéro.Text = "Numéro";
            // 
            // label_Mail
            // 
            this.label_Mail.AutoSize = true;
            this.label_Mail.Location = new System.Drawing.Point(18, 198);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(67, 13);
            this.label_Mail.TabIndex = 104;
            this.label_Mail.Text = "Mail (Famille)";
            // 
            // label_Téléphone
            // 
            this.label_Téléphone.AutoSize = true;
            this.label_Téléphone.Location = new System.Drawing.Point(18, 172);
            this.label_Téléphone.Name = "label_Téléphone";
            this.label_Téléphone.Size = new System.Drawing.Size(99, 13);
            this.label_Téléphone.TabIndex = 103;
            this.label_Téléphone.Text = "Téléphone (Famille)";
            // 
            // label_DateNaissance
            // 
            this.label_DateNaissance.AutoSize = true;
            this.label_DateNaissance.Location = new System.Drawing.Point(18, 146);
            this.label_DateNaissance.Name = "label_DateNaissance";
            this.label_DateNaissance.Size = new System.Drawing.Size(96, 13);
            this.label_DateNaissance.TabIndex = 102;
            this.label_DateNaissance.Text = "Date de naissance";
            // 
            // label_Pays
            // 
            this.label_Pays.AutoSize = true;
            this.label_Pays.Location = new System.Drawing.Point(18, 120);
            this.label_Pays.Name = "label_Pays";
            this.label_Pays.Size = new System.Drawing.Size(30, 13);
            this.label_Pays.TabIndex = 101;
            this.label_Pays.Text = "Pays";
            // 
            // label_Ville
            // 
            this.label_Ville.AutoSize = true;
            this.label_Ville.Location = new System.Drawing.Point(18, 94);
            this.label_Ville.Name = "label_Ville";
            this.label_Ville.Size = new System.Drawing.Size(26, 13);
            this.label_Ville.TabIndex = 100;
            this.label_Ville.Text = "Ville";
            // 
            // label_Rue
            // 
            this.label_Rue.AutoSize = true;
            this.label_Rue.Location = new System.Drawing.Point(18, 68);
            this.label_Rue.Name = "label_Rue";
            this.label_Rue.Size = new System.Drawing.Size(27, 13);
            this.label_Rue.TabIndex = 99;
            this.label_Rue.Text = "Rue";
            // 
            // label_Prénom
            // 
            this.label_Prénom.AutoSize = true;
            this.label_Prénom.Location = new System.Drawing.Point(18, 42);
            this.label_Prénom.Name = "label_Prénom";
            this.label_Prénom.Size = new System.Drawing.Size(43, 13);
            this.label_Prénom.TabIndex = 105;
            this.label_Prénom.Text = "Prénom";
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(18, 16);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(29, 13);
            this.label_Nom.TabIndex = 98;
            this.label_Nom.Text = "Nom";
            // 
            // Form_EncodageTuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 293);
            this.Controls.Add(this.textBox_Pays);
            this.Controls.Add(this.textBox_Prénom);
            this.Controls.Add(this.dateTimePicker_DateNaissance);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Annuler);
            this.Controls.Add(this.button_Valider);
            this.Controls.Add(this.textBox_Famille);
            this.Controls.Add(this.textBox_Mail);
            this.Controls.Add(this.textBox_Téléphone);
            this.Controls.Add(this.textBox_Ville);
            this.Controls.Add(this.textBox_CP);
            this.Controls.Add(this.textBox_Numéro);
            this.Controls.Add(this.textBox_Rue);
            this.Controls.Add(this.textBox_Nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Numéro);
            this.Controls.Add(this.label_Mail);
            this.Controls.Add(this.label_Téléphone);
            this.Controls.Add(this.label_DateNaissance);
            this.Controls.Add(this.label_Pays);
            this.Controls.Add(this.label_Ville);
            this.Controls.Add(this.label_Rue);
            this.Controls.Add(this.label_Prénom);
            this.Controls.Add(this.label_Nom);
            this.Name = "Form_EncodageTuteur";
            this.Text = "Encodage tuteur";
            this.Load += new System.EventHandler(this.Form_EncodageTuteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Pays;
        private System.Windows.Forms.TextBox textBox_Prénom;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateNaissance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Annuler;
        private System.Windows.Forms.Button button_Valider;
        private System.Windows.Forms.TextBox textBox_Famille;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_Téléphone;
        private System.Windows.Forms.TextBox textBox_Ville;
        private System.Windows.Forms.TextBox textBox_CP;
        private System.Windows.Forms.TextBox textBox_Numéro;
        private System.Windows.Forms.TextBox textBox_Rue;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Numéro;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.Label label_Téléphone;
        private System.Windows.Forms.Label label_DateNaissance;
        private System.Windows.Forms.Label label_Pays;
        private System.Windows.Forms.Label label_Ville;
        private System.Windows.Forms.Label label_Rue;
        private System.Windows.Forms.Label label_Prénom;
        private System.Windows.Forms.Label label_Nom;
    }
}