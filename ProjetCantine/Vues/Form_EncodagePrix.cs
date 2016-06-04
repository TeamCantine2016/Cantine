using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetCantine.Controller;

namespace ProjetCantine
{
    public partial class Form_ParamRepasPrix : Form
    {
        public Form_ParamRepasPrix()
        {
            InitializeComponent();
        }

        private void Form_ParamRepasPrix_Load(object sender, EventArgs e)
        {
            // Remplissage de combobox par des type de repas
            this.tbl_repasTableAdapter.Fill(this.db_cantineDataSet2.tbl_repas);
            // Remplissage de datagridview 
            this.tA_PrixRepasEncTableAdapter.Fill_PrixRepasEnc(this.db_cantineDataSet2.TA_PrixRepasEnc);
           
              
      

          

        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            //Pour donner à la date fin d'un type de repas : date d'insertion de nouveau prix - 1
            string dateFinPrecedent = dateTimePicker_datedebut.Value.AddDays(-1).ToString("yyyyMMdd");
            Ctrl_EncodagePrix controle = new Ctrl_EncodagePrix();
            //Recherche les données à inserer du controleur 
            String valInsert = controle.ReqInsertPrix(dateTimePicker_datedebut.Value.ToString("yyyyMMdd"), textBox_Prix.Text, comboBox_nomRepas.SelectedValue.ToString(), "2050-12-31");
            //Pour l'insertion du prix, nous renseignons également la date antécédant le prix actuel pour cloturer l'ancien prix (ainsi que le type de repas s'y rapportant)
            controle.InsertPrix("tbl_prix_repas", valInsert, comboBox_nomRepas.SelectedValue.ToString(), dateFinPrecedent);
            this.tA_PrixRepasEncTableAdapter.Fill_PrixRepasEnc(this.db_cantineDataSet2.TA_PrixRepasEnc);
        }
    }
}
