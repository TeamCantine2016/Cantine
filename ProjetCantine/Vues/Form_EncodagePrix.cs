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
            // TODO: This line of code loads data into the 'db_cantineDataSet1.tbl_repas' table. You can move, or remove it, as needed.
            this.tbl_repasTableAdapter.Fill(this.db_cantineDataSet1.tbl_repas);
            // TODO: This line of code loads data into the 'db_cantineDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.db_cantineDataSet.DataTable1);

          

        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            string dateFinPrecedent = dateTimePicker_datedebut.Value.AddDays(-1).ToString("yyyy-MM-dd");
            Ctrl_EncodagePrix controle = new Ctrl_EncodagePrix();
            String valInsert = controle.ReqInsertPrix(dateTimePicker_datedebut.Value.ToString("yyyy-MM-dd"), textBox_Prix.Text, comboBox_nomRepas.SelectedValue.ToString(), "2050-12-31");
            //Pour l'insertion du prix, nous renseignons également la date antécédant le prix actuel pour cloturer l'ancien prix (ainsi que le type de repas s'y rapportant)
            controle.InsertPrix("tbl_prix_repas", valInsert, comboBox_nomRepas.SelectedValue.ToString(), dateFinPrecedent);
            this.dataTable1TableAdapter.Fill(this.db_cantineDataSet.DataTable1);
        }
    }
}
