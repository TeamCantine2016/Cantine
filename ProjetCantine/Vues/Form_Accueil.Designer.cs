namespace ProjetCantine
{
    partial class Form_Acceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip_Acceuil = new System.Windows.Forms.MenuStrip();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesÉlèvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualisationDesFamillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodageRepasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramétrageDesRepasEtPrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationDuMenuDeLaSemaineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodageDesRepasParÉlèveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.générationDesFacturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueDesFacturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.récapitulatifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repasParFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Acceuil.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Acceuil
            // 
            this.menuStrip_Acceuil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrationToolStripMenuItem,
            this.encodageRepasToolStripMenuItem,
            this.facturationToolStripMenuItem,
            this.récapitulatifToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip_Acceuil.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Acceuil.Name = "menuStrip_Acceuil";
            this.menuStrip_Acceuil.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip_Acceuil.TabIndex = 1;
            this.menuStrip_Acceuil.Text = "menuStrip1";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesUtilisateursToolStripMenuItem,
            this.gestionDesÉlèvesToolStripMenuItem,
            this.visualisationDesFamillesToolStripMenuItem,
            this.déconnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // gestionDesUtilisateursToolStripMenuItem
            // 
            this.gestionDesUtilisateursToolStripMenuItem.Name = "gestionDesUtilisateursToolStripMenuItem";
            this.gestionDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.gestionDesUtilisateursToolStripMenuItem.Text = "Gestion des utilisateurs";
            this.gestionDesUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.gestionDesUtilisateursToolStripMenuItem_Click);
            // 
            // gestionDesÉlèvesToolStripMenuItem
            // 
            this.gestionDesÉlèvesToolStripMenuItem.Name = "gestionDesÉlèvesToolStripMenuItem";
            this.gestionDesÉlèvesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.gestionDesÉlèvesToolStripMenuItem.Text = "Gestion des élèves";
            this.gestionDesÉlèvesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesÉlèvesToolStripMenuItem_Click);
            // 
            // visualisationDesFamillesToolStripMenuItem
            // 
            this.visualisationDesFamillesToolStripMenuItem.Name = "visualisationDesFamillesToolStripMenuItem";
            this.visualisationDesFamillesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.visualisationDesFamillesToolStripMenuItem.Text = "Visualisation des familles";
            this.visualisationDesFamillesToolStripMenuItem.Click += new System.EventHandler(this.visualisationDesFamillesToolStripMenuItem_Click);
            // 
            // déconnecterToolStripMenuItem
            // 
            this.déconnecterToolStripMenuItem.Name = "déconnecterToolStripMenuItem";
            this.déconnecterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.déconnecterToolStripMenuItem.Text = "Déconnecter";
            this.déconnecterToolStripMenuItem.Click += new System.EventHandler(this.déconnecterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // encodageRepasToolStripMenuItem
            // 
            this.encodageRepasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramétrageDesRepasEtPrixToolStripMenuItem,
            this.configurationDuMenuDeLaSemaineToolStripMenuItem,
            this.encodageDesRepasParÉlèveToolStripMenuItem});
            this.encodageRepasToolStripMenuItem.Name = "encodageRepasToolStripMenuItem";
            this.encodageRepasToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.encodageRepasToolStripMenuItem.Text = "Encodage Repas";
            // 
            // paramétrageDesRepasEtPrixToolStripMenuItem
            // 
            this.paramétrageDesRepasEtPrixToolStripMenuItem.Name = "paramétrageDesRepasEtPrixToolStripMenuItem";
            this.paramétrageDesRepasEtPrixToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.paramétrageDesRepasEtPrixToolStripMenuItem.Text = "Paramétrage des repas et prix";
            this.paramétrageDesRepasEtPrixToolStripMenuItem.Click += new System.EventHandler(this.paramétrageDesRepasEtPrixToolStripMenuItem_Click);
            // 
            // configurationDuMenuDeLaSemaineToolStripMenuItem
            // 
            this.configurationDuMenuDeLaSemaineToolStripMenuItem.Name = "configurationDuMenuDeLaSemaineToolStripMenuItem";
            this.configurationDuMenuDeLaSemaineToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.configurationDuMenuDeLaSemaineToolStripMenuItem.Text = "Configuration du menu de la semaine";
            // 
            // encodageDesRepasParÉlèveToolStripMenuItem
            // 
            this.encodageDesRepasParÉlèveToolStripMenuItem.Name = "encodageDesRepasParÉlèveToolStripMenuItem";
            this.encodageDesRepasParÉlèveToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.encodageDesRepasParÉlèveToolStripMenuItem.Text = "Encodage des repas par élève";
            // 
            // facturationToolStripMenuItem
            // 
            this.facturationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.générationDesFacturesToolStripMenuItem,
            this.historiqueDesFacturesToolStripMenuItem});
            this.facturationToolStripMenuItem.Name = "facturationToolStripMenuItem";
            this.facturationToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.facturationToolStripMenuItem.Text = "Facturation";
            // 
            // générationDesFacturesToolStripMenuItem
            // 
            this.générationDesFacturesToolStripMenuItem.Name = "générationDesFacturesToolStripMenuItem";
            this.générationDesFacturesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.générationDesFacturesToolStripMenuItem.Text = "Génération des factures";
            // 
            // historiqueDesFacturesToolStripMenuItem
            // 
            this.historiqueDesFacturesToolStripMenuItem.Name = "historiqueDesFacturesToolStripMenuItem";
            this.historiqueDesFacturesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.historiqueDesFacturesToolStripMenuItem.Text = "Historique des factures";
            // 
            // récapitulatifToolStripMenuItem
            // 
            this.récapitulatifToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repasParFamilleToolStripMenuItem});
            this.récapitulatifToolStripMenuItem.Name = "récapitulatifToolStripMenuItem";
            this.récapitulatifToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.récapitulatifToolStripMenuItem.Text = "Récapitulatif";
            // 
            // repasParFamilleToolStripMenuItem
            // 
            this.repasParFamilleToolStripMenuItem.Name = "repasParFamilleToolStripMenuItem";
            this.repasParFamilleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.repasParFamilleToolStripMenuItem.Text = "Repas par famille ";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(79, 22);
            this.toolStripMenuItem2.Text = "?";
            // 
            // Form_Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 662);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip_Acceuil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip_Acceuil;
            this.MaximizeBox = false;
            this.Name = "Form_Acceuil";
            this.Text = "Menu Acceuil";
            this.menuStrip_Acceuil.ResumeLayout(false);
            this.menuStrip_Acceuil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Acceuil;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesÉlèvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualisationDesFamillesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodageRepasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramétrageDesRepasEtPrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationDuMenuDeLaSemaineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodageDesRepasParÉlèveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem générationDesFacturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueDesFacturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem récapitulatifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repasParFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

