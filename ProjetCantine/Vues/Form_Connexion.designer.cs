namespace ProjetCantine
{
    partial class Form_Connexion
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
            this.label_Identifiant = new System.Windows.Forms.Label();
            this.label_MotDePasse = new System.Windows.Forms.Label();
            this.textBox_identifiant = new System.Windows.Forms.TextBox();
            this.textBox_MotDePasse = new System.Windows.Forms.TextBox();
            this.button_Connexion = new System.Windows.Forms.Button();
            this.label_Erreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Identifiant
            // 
            this.label_Identifiant.AutoSize = true;
            this.label_Identifiant.Location = new System.Drawing.Point(25, 28);
            this.label_Identifiant.Name = "label_Identifiant";
            this.label_Identifiant.Size = new System.Drawing.Size(53, 13);
            this.label_Identifiant.TabIndex = 0;
            this.label_Identifiant.Text = "Identifiant";
            // 
            // label_MotDePasse
            // 
            this.label_MotDePasse.AutoSize = true;
            this.label_MotDePasse.Location = new System.Drawing.Point(25, 60);
            this.label_MotDePasse.Name = "label_MotDePasse";
            this.label_MotDePasse.Size = new System.Drawing.Size(71, 13);
            this.label_MotDePasse.TabIndex = 1;
            this.label_MotDePasse.Text = "Mot de passe";
            // 
            // textBox_identifiant
            // 
            this.textBox_identifiant.Location = new System.Drawing.Point(110, 25);
            this.textBox_identifiant.Name = "textBox_identifiant";
            this.textBox_identifiant.Size = new System.Drawing.Size(137, 20);
            this.textBox_identifiant.TabIndex = 5;
            this.textBox_identifiant.Text = "lareine";
            // 
            // textBox_MotDePasse
            // 
            this.textBox_MotDePasse.Location = new System.Drawing.Point(110, 57);
            this.textBox_MotDePasse.Name = "textBox_MotDePasse";
            this.textBox_MotDePasse.Size = new System.Drawing.Size(137, 20);
            this.textBox_MotDePasse.TabIndex = 10;
            this.textBox_MotDePasse.Text = "royale";
            // 
            // button_Connexion
            // 
            this.button_Connexion.Location = new System.Drawing.Point(286, 23);
            this.button_Connexion.Name = "button_Connexion";
            this.button_Connexion.Size = new System.Drawing.Size(120, 23);
            this.button_Connexion.TabIndex = 15;
            this.button_Connexion.Text = "Connexion";
            this.button_Connexion.UseVisualStyleBackColor = true;
            this.button_Connexion.Click += new System.EventHandler(this.button_Connexion_Click);
            // 
            // label_Erreur
            // 
            this.label_Erreur.AutoSize = true;
            this.label_Erreur.ForeColor = System.Drawing.Color.Red;
            this.label_Erreur.Location = new System.Drawing.Point(151, 82);
            this.label_Erreur.Name = "label_Erreur";
            this.label_Erreur.Size = new System.Drawing.Size(63, 13);
            this.label_Erreur.TabIndex = 16;
            this.label_Erreur.Text = "label_Erreur";
            this.label_Erreur.Visible = false;
            // 
            // Form_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 104);
            this.Controls.Add(this.label_Erreur);
            this.Controls.Add(this.button_Connexion);
            this.Controls.Add(this.textBox_MotDePasse);
            this.Controls.Add(this.textBox_identifiant);
            this.Controls.Add(this.label_MotDePasse);
            this.Controls.Add(this.label_Identifiant);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 142);
            this.MinimumSize = new System.Drawing.Size(460, 142);
            this.Name = "Form_Connexion";
            this.Text = "Connexion utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Identifiant;
        private System.Windows.Forms.Label label_MotDePasse;
        private System.Windows.Forms.TextBox textBox_identifiant;
        private System.Windows.Forms.TextBox textBox_MotDePasse;
        private System.Windows.Forms.Button button_Connexion;
        private System.Windows.Forms.Label label_Erreur;
    }
}