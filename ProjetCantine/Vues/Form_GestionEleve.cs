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
    public partial class Form_GestionEleve : Form
    {
        public Form_GestionEleve()
        {
            InitializeComponent();
        }
        int flag;

        Form_EncodageElève Form_EncodageEleve;

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            flag = 0;
            Form_EncodageEleve = new Form_EncodageElève(flag);
            Form_EncodageEleve.ShowDialog();
          
        }

        private void button_Editer_Click(object sender, EventArgs e)
        {
            flag = 1;
            Form_EncodageEleve = new Form_EncodageElève(flag);
            Form_EncodageEleve.ShowDialog();
        }

        private void Form_GestionEleve_Load(object sender, EventArgs e)
        {
            // requête du dataset pour remplir le datagridview
            this.tA_Listes_Personnes_query.Fill_Eleves(this.db_cantineDataSet.TA_Listes_Personnes);
            // pour adapter la largeur de colonnes
            dataGridView_Eleve.AutoResizeColumns();
            // pour élargir la dernière colonne horizontalement pour ne pas avoir une zone grise
            dataGridView_Eleve.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
