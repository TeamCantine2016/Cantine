namespace ProjetCantine.Vues
{
    partial class Form_EncodageFactures
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
            this.label_RechNom = new System.Windows.Forms.Label();
            this.txtBx_RechID = new System.Windows.Forms.TextBox();
            this.txtBx_RechNom = new System.Windows.Forms.TextBox();
            this.label_RechID = new System.Windows.Forms.Label();
            this.dGdVw_DetailFamille = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilleNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_Membres = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tabDetail = new System.Windows.Forms.TabControl();
            this.btApercu = new System.Windows.Forms.Button();
            this.btEnvoi = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.lbPeriode1 = new System.Windows.Forms.Label();
            this.lbEnvoi = new System.Windows.Forms.Label();
            this.lbPeriode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGdVw_DetailFamille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Membres)).BeginInit();
            this.tabDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_RechNom
            // 
            this.label_RechNom.AutoSize = true;
            this.label_RechNom.Location = new System.Drawing.Point(16, 24);
            this.label_RechNom.Name = "label_RechNom";
            this.label_RechNom.Size = new System.Drawing.Size(101, 13);
            this.label_RechNom.TabIndex = 1;
            this.label_RechNom.Text = "Recherche par nom";
            this.label_RechNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBx_RechID
            // 
            this.txtBx_RechID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBx_RechID.Location = new System.Drawing.Point(558, 21);
            this.txtBx_RechID.Name = "txtBx_RechID";
            this.txtBx_RechID.Size = new System.Drawing.Size(226, 20);
            this.txtBx_RechID.TabIndex = 6;
            // 
            // txtBx_RechNom
            // 
            this.txtBx_RechNom.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBx_RechNom.Location = new System.Drawing.Point(134, 21);
            this.txtBx_RechNom.Name = "txtBx_RechNom";
            this.txtBx_RechNom.Size = new System.Drawing.Size(226, 20);
            this.txtBx_RechNom.TabIndex = 5;
            // 
            // label_RechID
            // 
            this.label_RechID.AutoSize = true;
            this.label_RechID.Location = new System.Drawing.Point(447, 24);
            this.label_RechID.Name = "label_RechID";
            this.label_RechID.Size = new System.Drawing.Size(92, 13);
            this.label_RechID.TabIndex = 4;
            this.label_RechID.Text = "Recherche par ID";
            this.label_RechID.Click += new System.EventHandler(this.label_RechID_Click);
            // 
            // dGdVw_DetailFamille
            // 
            this.dGdVw_DetailFamille.AllowUserToAddRows = false;
            this.dGdVw_DetailFamille.AllowUserToDeleteRows = false;
            this.dGdVw_DetailFamille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGdVw_DetailFamille.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FamilleNom,
            this.Adresse});
            this.dGdVw_DetailFamille.Location = new System.Drawing.Point(12, 56);
            this.dGdVw_DetailFamille.Name = "dGdVw_DetailFamille";
            this.dGdVw_DetailFamille.ReadOnly = true;
            this.dGdVw_DetailFamille.Size = new System.Drawing.Size(537, 161);
            this.dGdVw_DetailFamille.TabIndex = 7;
            this.dGdVw_DetailFamille.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGdVw_DetailEleve_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // FamilleNom
            // 
            this.FamilleNom.HeaderText = "Famille(Nom)";
            this.FamilleNom.Name = "FamilleNom";
            this.FamilleNom.ReadOnly = true;
            this.FamilleNom.Width = 150;
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            this.Adresse.Width = 300;
            // 
            // dataGridView_Membres
            // 
            this.dataGridView_Membres.AllowUserToAddRows = false;
            this.dataGridView_Membres.AllowUserToDeleteRows = false;
            this.dataGridView_Membres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Membres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView_Membres.Location = new System.Drawing.Point(559, 56);
            this.dataGridView_Membres.Name = "dataGridView_Membres";
            this.dataGridView_Membres.ReadOnly = true;
            this.dataGridView_Membres.Size = new System.Drawing.Size(245, 161);
            this.dataGridView_Membres.TabIndex = 8;
            this.dataGridView_Membres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Membres";
            this.dataGridViewTextBoxColumn1.HeaderText = "Membres";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(810, 56);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mois",
            "Semaine"});
            this.comboBox1.Location = new System.Drawing.Point(810, 333);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Courrier",
            "Email",
            "Les 2"});
            this.comboBox2.Location = new System.Drawing.Point(810, 409);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(227, 21);
            this.comboBox2.TabIndex = 21;
            // 
            // tab2
            // 
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(764, 189);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Membre2";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // tab1
            // 
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(764, 189);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Membre1";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tabDetail
            // 
            this.tabDetail.Controls.Add(this.tab1);
            this.tabDetail.Controls.Add(this.tab2);
            this.tabDetail.Location = new System.Drawing.Point(12, 284);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.SelectedIndex = 0;
            this.tabDetail.Size = new System.Drawing.Size(772, 215);
            this.tabDetail.TabIndex = 22;
            // 
            // btApercu
            // 
            this.btApercu.Location = new System.Drawing.Point(110, 583);
            this.btApercu.Name = "btApercu";
            this.btApercu.Size = new System.Drawing.Size(200, 35);
            this.btApercu.TabIndex = 23;
            this.btApercu.Text = "Aperçu";
            this.btApercu.UseVisualStyleBackColor = true;
            // 
            // btEnvoi
            // 
            this.btEnvoi.Location = new System.Drawing.Point(445, 583);
            this.btEnvoi.Name = "btEnvoi";
            this.btEnvoi.Size = new System.Drawing.Size(200, 35);
            this.btEnvoi.TabIndex = 23;
            this.btEnvoi.Text = "Envoi";
            this.btEnvoi.UseVisualStyleBackColor = true;
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(770, 583);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(200, 35);
            this.btAnnuler.TabIndex = 23;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // lbPeriode1
            // 
            this.lbPeriode1.AutoSize = true;
            this.lbPeriode1.Location = new System.Drawing.Point(807, 306);
            this.lbPeriode1.Name = "lbPeriode1";
            this.lbPeriode1.Size = new System.Drawing.Size(110, 13);
            this.lbPeriode1.TabIndex = 1;
            this.lbPeriode1.Text = "Générer la facture par";
            this.lbPeriode1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbEnvoi
            // 
            this.lbEnvoi.AutoSize = true;
            this.lbEnvoi.Location = new System.Drawing.Point(807, 384);
            this.lbEnvoi.Name = "lbEnvoi";
            this.lbEnvoi.Size = new System.Drawing.Size(111, 13);
            this.lbEnvoi.TabIndex = 1;
            this.lbEnvoi.Text = "Envoyer la facture par";
            this.lbEnvoi.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbPeriode
            // 
            this.lbPeriode.AutoSize = true;
            this.lbPeriode.Location = new System.Drawing.Point(808, 24);
            this.lbPeriode.Name = "lbPeriode";
            this.lbPeriode.Size = new System.Drawing.Size(115, 13);
            this.lbPeriode.TabIndex = 1;
            this.lbPeriode.Text = "Selectionner la periode";
            this.lbPeriode.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_EncodageFactures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.ControlBox = false;
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btEnvoi);
            this.Controls.Add(this.btApercu);
            this.Controls.Add(this.tabDetail);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView_Membres);
            this.Controls.Add(this.dGdVw_DetailFamille);
            this.Controls.Add(this.txtBx_RechID);
            this.Controls.Add(this.txtBx_RechNom);
            this.Controls.Add(this.label_RechID);
            this.Controls.Add(this.lbEnvoi);
            this.Controls.Add(this.lbPeriode);
            this.Controls.Add(this.lbPeriode1);
            this.Controls.Add(this.label_RechNom);
            this.Name = "Form_EncodageFactures";
            this.Text = "Encodage des factures";
            this.Load += new System.EventHandler(this.Form_EncodageFactures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGdVw_DetailFamille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Membres)).EndInit();
            this.tabDetail.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_RechNom;
        private System.Windows.Forms.TextBox txtBx_RechID;
        private System.Windows.Forms.TextBox txtBx_RechNom;
        private System.Windows.Forms.Label label_RechID;
        private System.Windows.Forms.DataGridView dGdVw_DetailFamille;
        private System.Windows.Forms.DataGridView dataGridView_Membres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabControl tabDetail;
        private System.Windows.Forms.Button btApercu;
        private System.Windows.Forms.Button btEnvoi;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Label lbPeriode1;
        private System.Windows.Forms.Label lbEnvoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilleNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.Label lbPeriode;
    }
}