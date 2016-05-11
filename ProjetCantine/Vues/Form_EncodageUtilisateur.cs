using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
//using ProjetCantine.Models;

namespace ProjetCantine
{
    public partial class Form_EncodageUtilisateur : Form
    {

        //cantineEntities ce = new cantineEntities();   
        public Form_EncodageUtilisateur(int flag)
        {
            InitializeComponent();
          // comboBox_Type.SelectedIndex = 0;
            if (flag == 0)
            {
                button_Valider.Text = "Valider";
            }
            else button_Valider.Text = "Modifier";
        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            this.Dispose();          // A vérifier son utilité
            this.Close();
        }

        private void Form_EncodageUtilisateur_Load(object sender, EventArgs e)
        {
            //charger la table utilisateur
           // ce.utilisateur.Load();

            //chercher les données dans la combobox de droits et Distinct pour ne pas avoir des doublants
          // tblutilisateurBindingSource.DataSource = ce.utilisateur.Local.Select(var => var.droits).Distinct();
        }
    }
}
