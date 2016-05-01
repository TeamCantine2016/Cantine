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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Historique)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Historique
            // 
            this.dataGridView_Historique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Historique.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Historique.Name = "dataGridView_Historique";
            this.dataGridView_Historique.Size = new System.Drawing.Size(1060, 637);
            this.dataGridView_Historique.TabIndex = 0;
            // 
            // Form_HistoriqueFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.dataGridView_Historique);
            this.Name = "Form_HistoriqueFacture";
            this.Text = "Historique Facture";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Historique)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Historique;
    }
}