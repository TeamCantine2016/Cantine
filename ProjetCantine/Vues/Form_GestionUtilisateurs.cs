using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetCantine;

namespace ProjetCantine
{
    public partial class Form_GestionUtilisateurs : Form
    {
        public Form_GestionUtilisateurs()
        {
            InitializeComponent();
        }

        

        private void button_Nouveau_Click(object sender, EventArgs e)
        {

            flag = 0;
            Form_EncodageUtilisateur FEU = new Form_EncodageUtilisateur(this, flag);
            FEU.ShowDialog();
        }

        private void button_Editer_Click(object sender, EventArgs e)
        {
            flag = 1;
            //psd garde en mémoire la sélection de l'identifiant dans la datagridview
            psd = dataGridView_GestionUtilisateur.CurrentRow.Cells[0].Value.ToString();
            Form_EncodageUtilisateur FEU = new Form_EncodageUtilisateur(this, flag);
            FEU.ShowDialog();
        }

        public void Form_GestionUtilisateurs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_cantineDataSet.DataTable1' table. You can move, or remove it, as needed.
            // this.dataTable1TableAdapter.Fill(this.db_cantineDataSet.DataTable1);
            // requête du dataset pour remplir le datagridview
            // this.tA_Liste_Utilisateurs_query.Fill_Utilisateurs(this.db_cantineDataSet.TA_Liste_Utilisateurs);
            // pour adapter la largeur de colonnes
            //  dataGridView_GestionUtilisateur.AutoResizeColumns();
            // pour élargir la dernière colonne horizontalement pour ne pas avoir une zone grise
            //  dataGridView_GestionUtilisateur.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //
            dataGridView_GestionUtilisateur.Rows.Clear();

            // 
            SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=db_cantine;Integrated Security=True");
            SqlCommand command;
            string sql = "select dbo.tbl_utilisateur.pseudo, dbo.tbl_personne.prenom, dbo.tbl_personne.nom, dbo.tbl_personne.courriel, dbo.tbl_utilisateur.droits, dbo.tbl_utilisateur.etat from tbl_utilisateur inner join tbl_personne on dbo.tbl_personne.id = dbo.tbl_utilisateur.personne_id;";
            SqlDataReader dataReader;
            ProjetCantine.utilisateur uti = null;
            ProjetCantine.personne pers = null;

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                uti = new ProjetCantine.utilisateur();
                pers = new ProjetCantine.personne();
                while (dataReader.Read())
                {
                    uti.set_pseudo(dataReader.GetString(0));
                    pers.set_prenom(dataReader.GetString(1));
                    pers.set_nom(dataReader.GetString(2));
                    pers.set_courriel(dataReader.GetString(3));
                    uti.set_droits(dataReader.GetString(4));
                    uti.set_etat(dataReader.GetBoolean(5));
                    dataGridView_GestionUtilisateur.Rows.Add(uti.get_pseudo(), pers.get_prenom(), pers.get_nom(), pers.get_courriel(), uti.get_droits(), uti.get_etat());

                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            bool supprAdr = false;
            bool supprPers = false;
            int[] tab_ID = new int[2];
            psd = dataGridView_GestionUtilisateur.CurrentRow.Cells[0].Value.ToString();
            if (psd == "")
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur\nen cliquant sur la ligne correspondante.", "Données insuffisantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Etes-vous sûr de vouloir supprimer cet utilisateur définitivement?\n\t" + psd + " (" + dataGridView_GestionUtilisateur.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView_GestionUtilisateur.CurrentRow.Cells[2].Value.ToString() + ")", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Souhaitez-vous supprimer la personne correspondant à l'utilisateur?", "Suppression de la personne dans la base de données", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) supprPers = true;
                    if (supprPers == true)
                    {
                        if (MessageBox.Show("Souhaitez-vous supprimer l'adresse de l'utilisateur?", "Suppression de l'adresse dans la base de données", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) supprAdr = true;
                    }
                    SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=db_cantine;Integrated Security=True");
                    SqlCommand command;
                    string sql = "select dbo.tbl_utilisateur.personne_id, tbl_personne.adresse_id from tbl_utilisateur inner join tbl_personne on  tbl_personne.id =  tbl_utilisateur.personne_id where pseudo like '" + psd + "';";
                    SqlDataReader dataReader;
                    string msg;
                    try
                    {
                        cnn.Open();
                        command = new SqlCommand(sql, cnn);
                        dataReader = command.ExecuteReader();

                        if (dataReader.Read() == true)
                        {
                            tab_ID[0] = dataReader.GetInt32(0);
                            tab_ID[1] = dataReader.GetInt32(1);
                        }
                        dataReader.Close();
                        command.Dispose();

                        // Vérifier que l'adresse et la personne ne sont pas utilisées par un autre utilisateur

                        int nb_enreg;
                        if (supprAdr == true)
                        {
                            sql = "select count(*) from tbl_utilisateur inner join tbl_personne on tbl_utilisateur.personne_id = tbl_personne.id where adresse_id =" + tab_ID[1] + ";";
                            command = new SqlCommand(sql, cnn);
                            nb_enreg = (int)command.ExecuteScalar();
                            if (nb_enreg > 1)
                            {
                                supprAdr = false;
                                MessageBox.Show("L'adresse ne sera pas supprimée car d'autres utilisateurs y ont défini leur lieu de résidence.", "Suppression adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            command.Dispose();
                        }

                        if (supprPers == true)
                        {
                            sql = "select count(*) from tbl_utilisateur where personne_id =" + tab_ID[0] + ";";
                            command = new SqlCommand(sql, cnn);
                            nb_enreg = (int)command.ExecuteScalar();
                            if (nb_enreg > 1)
                            {
                                supprPers = false;
                                MessageBox.Show("La personne ne sera pas supprimée car elle correspond à d'autres utilisateurs.", "Suppression personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            command.Dispose();
                        }

                        sql = "delete from dbo.tbl_utilisateur where pseudo like '" + psd + "';";
                        msg = "\t\n- l'utilisateur";
                        if (supprPers == true)
                        {
                            sql += "delete from dbo.tbl_personne where id = " + tab_ID[0] + ";";
                            msg += "\t\n- la personne";

                            if (supprAdr == true)
                            {
                                sql += "delete from dbo.tbl_adresse where id = " + tab_ID[1] + ";";
                                msg += "\t\n- l'adresse";
                            }
                        }
                        
                        command = new SqlCommand(sql, cnn);
                        command.ExecuteNonQuery();
                        command.Dispose();

                        cnn.Close();

                        MessageBox.Show("Suppression de " + msg + "\neffectuée avec succès.", "Suppression d'éléments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Form_GestionUtilisateurs_Load(this, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }

        }

       
    }
}
