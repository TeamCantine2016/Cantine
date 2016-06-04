using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetCantine.Models;
using System.Data.SqlClient;
using ProjetCantine.Controller;


namespace ProjetCantine.Vues
{
    public partial class Form_EncodageRepas : Form
    {
        int id_eleve = 0;
        int[] tab_id_repas = new int[5];
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        db_cantineDataSet ds = new db_cantineDataSet();
        SqlConnection con = new SqlConnection(DbConnection.connectionString);
        DateTime startDate;


        public Form_EncodageRepas()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Ctrl_EncodageRepas controle = new Ctrl_EncodageRepas();
            // appelle la méthode liée à la procédure stockée
            controle.filtreEleve(ref dGdVw_DetailEleve, txtBx_RechNom.Text);
        }


        private void Form_EncodageRepas_Load(object sender, EventArgs e)
        {
            // requête du dataset pour remplir le datagridview
            this.tA_Listes_Personnes_query.Fill_Eleves(this.db_cantineDataSet.TA_Listes_Personnes);
            // pour adapter la largeur de colonnes
            dGdVw_DetailEleve.AutoResizeColumns();
            // pour élargir la dernière colonne horizontalement pour ne pas avoir une zone grise
            dGdVw_DetailEleve.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void dGdVw_DetailEleve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dGdVw_DetailEleve.CurrentRow.Index;
            DataGridViewRow ligne = dGdVw_DetailEleve.Rows[i];
            txtBx_Nom.Text = ligne.Cells[1].Value.ToString();
            txtBx_Prenom.Text = ligne.Cells[2].Value.ToString();
            txtBox_Adresse.Text = ligne.Cells[4].Value.ToString();
            txtBx_DateNaissce.Text = ligne.Cells[3].Value.ToString().Substring(0, 10);
            //on transmet l'ID de l'étudiant à la variable globale index
            id_eleve = Convert.ToInt16(ligne.Cells[0].Value);
            if (ligne.Cells[0].Value.ToString() != null)
            {
                string query = "SELECT telephone, courriel FROM tbl_personne ";
                query += "where(id = (SELECT tbl_relation_tuteur_enfant.tuteur_id FROM tbl_relation_tuteur_enfant WHERE(tbl_relation_tuteur_enfant.enfant_id = '" + Convert.ToInt32(ligne.Cells[0].Value.ToString()) + "')))";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtBx_Telephone.Text = dr["telephone"].ToString();
                    txtBx_Email.Text = dr["courriel"].ToString();
                }

                dr.Close();
                dr.Dispose();
                con.Close();
            }
            if (txtBx_Nom.Text.Length > 0)
            {
                monthCalendar.Enabled = true;
            }
            else
            {
                monthCalendar.Enabled = false;
            }
            btConfirmation.Enabled = false;
            //txtBx_Email.Text = ligne.Cells[0].Value.ToString();
        }


        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            startDate = e.Start;
            startDate = startDate.AddDays(1 - (double)startDate.DayOfWeek);
            monthCalendar.SelectionStart = startDate;
            labelDebut.Text = startDate.ToString("d");
            monthCalendar.SelectionEnd = startDate.AddDays(4);
            labelFin.Text = startDate.AddDays(4).ToString("d");
            chargement_Repas(startDate);
            btConfirmation.Enabled = true;
            //Appeler un filtre de blocage si repas compris dans une période facturée cloturée
            verification_Periode();

        }


        private void verification_Periode()
        {
            DateTime dtDebutFactureActuelle = new DateTime();
            DateTime dtFinFactureActuelle = new DateTime();
            DateTime dtFinSemaine = new DateTime();
            DateTime dtFactureSuivanteDebut = new DateTime();
            DateTime dtFactureSuivanteFin = new DateTime();
            Boolean factureMoisSuivant;
            dtFinSemaine = startDate.AddDays(4);
            Ctrl_EncodageRepas controle = new Ctrl_EncodageRepas();
            Ctrl_EncodageRepas controle2 = new Ctrl_EncodageRepas();

            //Récupération de la date de facture de début et de fin en fonction de la semaine
            //Si aucune période n'est comprise dans cette date, alors on prend la date max selon l'id tuteur
            dtDebutFactureActuelle = Convert.ToDateTime(controle.PeriodeDebut(id_eleve, startDate.ToString("yyyyMMdd"),false));
            dtFinFactureActuelle = Convert.ToDateTime(controle.PeriodeFin(id_eleve, startDate.ToString("yyyyMMdd"),false));

            //Test pour voir si la période est à cheval sur 2 factures, si oui, dtFactureSuivanteDebut et dtFactureSuivanteFin auront une valeur correspondant aux dates de début et de cloture de facutre du mois suivant, autrement elles vaudront 2000-01-01 (valeur arbitraire à tester)
            dtFactureSuivanteDebut = Convert.ToDateTime(controle2.PeriodeDebut(id_eleve, dtFinSemaine.ToString("yyyyMMdd"),true));
            dtFactureSuivanteFin = Convert.ToDateTime(controle2.PeriodeFin(id_eleve, dtFinSemaine.ToString("yyyyMMdd"),true));
            //test de la valeur retournée pour créer un flag faactureMoisSuivant
            if (dtFactureSuivanteDebut == Convert.ToDateTime("2000-01-01"))
            {
                factureMoisSuivant = false;
            }else
            {
                factureMoisSuivant = true;
            }

            //On regarde si la date de début de repas est comprise dans une période de facturation
            int debut = DateTime.Compare(startDate, dtDebutFactureActuelle); //si le resultat vaut 0 ou 1, la date est = ou supérieure à la periode de début de facture
            int fin = DateTime.Compare(startDate, dtFinFactureActuelle); //si le résultat vaut 1, on est au delà de la dernière facture, sinon on est dans la période
            if (fin == 1)
            {
                groupBoxLundi.Enabled = true;
                groupBoxMardi.Enabled = true;
                groupBoxMercredi.Enabled = true;
                groupBoxJeudi.Enabled = true;
                groupBoxVendredi.Enabled = true;
            }
            else if (fin <= 0)
            {
                //Procédure pour récupérer la différence de jour entre la fin de période facturée et la fin de semaine
                if (factureMoisSuivant == false) //si il n'y a pas de facture le mois suivant
                {
                    TimeSpan ts = dtFinSemaine - dtFinFactureActuelle;
                    int differenceInDays = ts.Days;
                    affichageDifferenceJour(differenceInDays);
                  
                }else //Si il y a une facture le mois suivant
                {
                    TimeSpan ts = dtFinSemaine - dtFactureSuivanteFin;
                    int differenceInDays = ts.Days;
                    affichageDifferenceJour(differenceInDays);
                }
            }
        }


        private void affichageDifferenceJour(int differenceInDays)
        {
            switch (differenceInDays)
            {
                case 1:
                    groupBoxLundi.Enabled = false;
                    groupBoxMardi.Enabled = false;
                    groupBoxMercredi.Enabled = false;
                    groupBoxJeudi.Enabled = false;
                    groupBoxVendredi.Enabled = true;
                    break;
                case 2:
                    groupBoxLundi.Enabled = false;
                    groupBoxMardi.Enabled = false;
                    groupBoxMercredi.Enabled = false;
                    groupBoxJeudi.Enabled = true;
                    groupBoxVendredi.Enabled = true;
                    break;
                case 3:
                    groupBoxLundi.Enabled = false;
                    groupBoxMardi.Enabled = false;
                    groupBoxMercredi.Enabled = true;
                    groupBoxJeudi.Enabled = true;
                    groupBoxVendredi.Enabled = true;
                    break;
                case 4:
                    groupBoxLundi.Enabled = false;
                    groupBoxMardi.Enabled = true;
                    groupBoxMercredi.Enabled = true;
                    groupBoxJeudi.Enabled = true;
                    groupBoxVendredi.Enabled = true;
                    break;
                default:
                    groupBoxLundi.Enabled = false;
                    groupBoxMardi.Enabled = false;
                    groupBoxMercredi.Enabled = false;
                    groupBoxJeudi.Enabled = false;
                    groupBoxVendredi.Enabled = false;
                    break;
            }


        }

        private void chargement_Repas(DateTime startDate)
        {
            string repas_id;
            for (int i = 0; i < 5; i++)
            {

                string query = "SELECT repas_id FROM[db_cantine].[dbo].[tbl_relation_repas]";
                query += "where date_repas = '" + startDate.AddDays(i).ToString("yyyyMMdd") + "' and personne_id = '" + id_eleve + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Si le dr contient des information, alors on lie les données aux radio buttons
                    labelEtat.Visible = false;
                    btConfirmation.Text = "Modification";
                    while (dr.Read())
                    {
                        repas_id = dr["repas_id"].ToString();
                        switch (i)
                        {
                            case 0:
                                switch (repas_id)
                                {
                                    case "1":
                                        radioButtonRepasChaud1Lundi.Checked = true;
                                        break;
                                    case "2":
                                        radioButtonRepasChaud2Lundi.Checked = true;
                                        break;
                                    case "3":
                                        radioButtonRepasFroidLundi.Checked = true;
                                        break;
                                    default:
                                        radioButtonAucunLundi.Checked = true;
                                        break;
                                }
                                break;
                            case 1:
                                switch (repas_id)
                                {
                                    case "1":
                                        radioButtonRepasChaud1Mardi.Checked = true;
                                        break;
                                    case "2":
                                        radioButtonRepasChaud2Mardi.Checked = true;
                                        break;
                                    case "3":
                                        radioButtonRepasFroidMardi.Checked = true;
                                        break;
                                    default:
                                        radioButtonAucunMardi.Checked = true;
                                        break;
                                }
                                break;


                            case 2:
                                switch (repas_id)
                                {
                                    case "1":
                                        radioButtonRepasChaud1Mercredi.Checked = true;
                                        break;
                                    case "2":
                                        radioButtonRepasChaud2Mercredi.Checked = true;
                                        break;
                                    case "3":
                                        radioButtonRepasFroidMercredi.Checked = true;
                                        break;
                                    default:
                                        radioButtonAucunMercredi.Checked = true;
                                        break;
                                }
                                break;

                            case 3:
                                switch (repas_id)
                                {
                                    case "1":
                                        radioButtonRepasChaud1Jeudi.Checked = true;
                                        break;
                                    case "2":
                                        radioButtonRepasChaud2Jeudi.Checked = true;
                                        break;
                                    case "3":
                                        radioButtonRepasFroidJeudi.Checked = true;
                                        break;
                                    default:
                                        radioButtonAucunJeudi.Checked = true;
                                        break;
                                }
                                break;

                            case 4:
                                switch (repas_id)
                                {
                                    case "1":
                                        radioButtonRepasChaud1Vendredi.Checked = true;
                                        break;
                                    case "2":
                                        radioButtonRepasChaud2Vendredi.Checked = true;
                                        break;
                                    case "3":
                                        radioButtonRepasFroidVendredi.Checked = true;
                                        break;
                                    case "4":
                                        radioButtonAucunVendredi.Checked = true;
                                        break;
                                }
                                break;

                        }
                    }
                }
                else
                {
                    // Si le DR est vide, aucun encodage n'a été effectué
                    labelEtat.Visible = true;
                    btConfirmation.Text = "Confirmation";
                    radioButtonAucunLundi.Checked = true;
                    radioButtonAucunMardi.Checked = true;
                    radioButtonAucunMercredi.Checked = true;
                    radioButtonAucunJeudi.Checked = true;
                    radioButtonAucunVendredi.Checked = true;
                    //mise à zéro du tableau d'ID des repas
                    for (int j = 0; j < 5; j++)
                    {
                        tab_id_repas[j] = 4;
                        // 4 est le ID de aucun repas
                    }
                }
                dr.Close();
                dr.Dispose();
                con.Close();
            }
        }


        private void btConfirmation_Click(object sender, EventArgs e)
        {
            int resultat = 0;
            int modif = 0;
            DateTime startDate = Convert.ToDateTime(labelDebut.Text);
            for (int i = 0; i < 5; i++)
            {
                // On vérifie si la période a déjà été introduite dans la DB, si oui, on fait un update, sinon un insert
                if (labelEtat.Visible)
                {
                    Ctrl_EncodageRepas controle = new Ctrl_EncodageRepas();
                    String valInsert = controle.ReqInsertRepas(startDate.AddDays(i).ToString("yyyyMMdd"), id_eleve.ToString(), tab_id_repas[i].ToString());
                    resultat = controle.insertData("tbl_relation_repas", valInsert);

                }
                else
                {
                    String donnees;
                    int id = 0;
                    //recuperer l'id repas
                    Ctrl_EncodageRepas controle = new Ctrl_EncodageRepas();
                    id = controle.recupIdERepas(startDate.AddDays(i).ToString("yyyyMMdd"), id_eleve.ToString());
                    donnees = controle.ReqUpdateRepas(startDate.AddDays(i).ToString("yyyyMMdd"), id_eleve.ToString(), tab_id_repas[i].ToString());
                    Ctrl_EncodageRepas controle1 = new Ctrl_EncodageRepas();
                    modif = controle1.update(donnees, "tbl_relation_repas", id);

                }
            }
            if (resultat > 0)
            {
                MessageBox.Show("Les repas de l'élève " + txtBx_Nom.Text + " " + txtBx_Prenom.Text + " ont bien été ajouté pour la semaine du " + labelDebut.Text + " au " + labelFin.Text);
            }
            if (modif > 0)
            {
                MessageBox.Show("Les repas de l'élève " + txtBx_Nom.Text + " " + txtBx_Prenom.Text + " ont bien été modifié pour la semaine du " + labelDebut.Text + " au " + labelFin.Text);
            }
            chargement_Repas(startDate);
        }

        private void radioButtonRepasChaud1Lundi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[0] = 1;
        }

        private void radioButtonRepasChaud2Lundi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[0] = 2;
        }

        private void radioButtonRepasFroidLundi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[0] = 3;
        }

        private void radioButtonAucunLundi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[0] = 4;
        }

        private void radioButtonRepasChaud1Mardi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[1] = 1;
        }

        private void radioButtonRepasChaud2Mardi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[1] = 2;
        }

        private void radioButtonRepasFroidMardi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[1] = 3;
        }

        private void radioButtonAucunMardi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[1] = 4;
        }

        private void radioButtonRepasChaud1Mercredi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[2] = 1;
        }

        private void radioButtonRepasChaud2Mercredi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[2] = 2;
        }

        private void radioButtonRepasFroidMercredi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[2] = 3;
        }

        private void radioButtonAucunMercredi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[2] = 4;
        }

        private void radioButtonRepasChaud1Jeudi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[3] = 1;
        }

        private void radioButtonRepasChaud2Jeudi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[3] = 2;

        }

        private void radioButtonRepasFroidJeudi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[3] = 3;

        }

        private void radioButtonAucunJeudi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[3] = 4;

        }

        private void radioButtonRepasChaud1Vendredi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[4] = 1;

        }

        private void radioButtonRepasChaud2Vendredi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[4] = 2;

        }

        private void radioButtonRepasFroidVendredi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[4] = 3;
        }

        private void radioButtonAucunVendredi_CheckedChanged(object sender, EventArgs e)
        {
            tab_id_repas[4] = 4;
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            chargement_Repas(startDate);
        }


    }
}
