using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCantine
{
    public partial class Form_GestionUtilisateur : Form
    {
        public Form_GestionUtilisateur()
        {
            InitializeComponent();
        }

        Form_EncodageUtilisateur form_EncodageUtilisateur;
        int flag;
        

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            flag = 0;
            form_EncodageUtilisateur = new Form_EncodageUtilisateur(flag);
            form_EncodageUtilisateur.ShowDialog();
        }

        private void button_Editer_Click(object sender, EventArgs e)
        {
            flag = 1;
            form_EncodageUtilisateur = new Form_EncodageUtilisateur(flag);
            form_EncodageUtilisateur.ShowDialog();
        }

        private void Form_GestionUtilisateur_Load(object sender, EventArgs e)
        {
            // requête du dataset pour remplir le datagridview
            this.tA_Liste_Utilisateurs_query.Fill_Utilisateurs(this.db_cantineDataSet.TA_Liste_Utilisateurs);
            // pour adapter la largeur de colonnes
            dataGridView_GestionUtilisateur.AutoResizeColumns();
            // pour élargir la dernière colonne horizontalement pour ne pas avoir une zone grise
            dataGridView_GestionUtilisateur.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
