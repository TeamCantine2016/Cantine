﻿namespace ProjetCantine.Vues
{
    partial class Form_View_Facture
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
            this.wb_view_pdf = new System.Windows.Forms.WebBrowser();
            this.bt_enregistrer = new System.Windows.Forms.Button();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.lb_Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wb_view_pdf
            // 
            this.wb_view_pdf.Location = new System.Drawing.Point(12, 12);
            this.wb_view_pdf.MaximumSize = new System.Drawing.Size(760, 511);
            this.wb_view_pdf.MinimumSize = new System.Drawing.Size(760, 511);
            this.wb_view_pdf.Name = "wb_view_pdf";
            this.wb_view_pdf.Size = new System.Drawing.Size(760, 511);
            this.wb_view_pdf.TabIndex = 0;
            // 
            // bt_enregistrer
            // 
            this.bt_enregistrer.Location = new System.Drawing.Point(616, 529);
            this.bt_enregistrer.Name = "bt_enregistrer";
            this.bt_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.bt_enregistrer.TabIndex = 1;
            this.bt_enregistrer.Text = "enregistrer";
            this.bt_enregistrer.UseVisualStyleBackColor = true;
            this.bt_enregistrer.Click += new System.EventHandler(this.bt_enregistrer_Click_1);
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(697, 529);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(75, 23);
            this.bt_annuler.TabIndex = 2;
            this.bt_annuler.Text = "annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click_1);
            // 
            // lb_Message
            // 
            this.lb_Message.AutoSize = true;
            this.lb_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Message.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_Message.Location = new System.Drawing.Point(9, 532);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(608, 30);
            this.lb_Message.TabIndex = 3;
            this.lb_Message.Text = "Pour l\'impression ou la sauvegarde, veuillez passer le curseur au-dessus de la pa" +
    "rtie inférieure de l\'affichage...\r\n.";
            // 
            // Form_View_Facture
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lb_Message);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.bt_enregistrer);
            this.Controls.Add(this.wb_view_pdf);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form_View_Facture";
            this.Load += new System.EventHandler(this.Form_View_Facture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser wb_view_pdf;
        private System.Windows.Forms.Button bt_enregistrer;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Label lb_Message;
    }
}