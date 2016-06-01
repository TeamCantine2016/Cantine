namespace ProjetCantine.Vues
{
    partial class Form_HistoriqueFacture
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
            this.dataGridView_Historique = new System.Windows.Forms.DataGridView();
            this.button_visualisation = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Historique)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Historique
            // 
            this.dataGridView_Historique.AllowUserToAddRows = false;
            this.dataGridView_Historique.AllowUserToDeleteRows = false;
            this.dataGridView_Historique.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Historique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Historique.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Historique.Name = "dataGridView_Historique";
            this.dataGridView_Historique.ReadOnly = true;
            this.dataGridView_Historique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Historique.Size = new System.Drawing.Size(900, 615);
            this.dataGridView_Historique.TabIndex = 0;
            // 
            // button_visualisation
            // 
            this.button_visualisation.Location = new System.Drawing.Point(920, 194);
            this.button_visualisation.Name = "button_visualisation";
            this.button_visualisation.Size = new System.Drawing.Size(154, 23);
            this.button_visualisation.TabIndex = 1;
            this.button_visualisation.Text = "Visualisation";
            this.button_visualisation.UseVisualStyleBackColor = true;
            this.button_visualisation.Click += new System.EventHandler(this.button_visualisation_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(920, 228);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(154, 23);
            this.button_modifier.TabIndex = 2;
            this.button_modifier.Text = "Modifier le chemin du fichier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // Form_HistoriqueFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.ControlBox = false;
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_visualisation);
            this.Controls.Add(this.dataGridView_Historique);
            this.Name = "Form_HistoriqueFacture";
            this.Text = "Historique Facture";
            this.Load += new System.EventHandler(this.Form_HistoriqueFacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Historique)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Historique;
        private System.Windows.Forms.Button button_visualisation;
        private System.Windows.Forms.Button button_modifier;
    }
}