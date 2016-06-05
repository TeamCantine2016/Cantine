using System;
using System.Windows.Forms;
using ProjetCantine.Controller;
using System.Collections;
using ProjetCantine.Outils;
using System.Data;

namespace ProjetCantine.Vues
{
    public partial class Form_EncodageFactures : Form
    {
        string date_debut = "";
        string date_fin = "";
        //float prix = 0;
        string path_facture = "";
        ArrayList lesEnfants = new ArrayList();

        public Form_EncodageFactures()
        {
            InitializeComponent();
        }
        public Form_EncodageFactures(String labelchaud1, String labelchaud2, String labelfroid, String labelaucun)
        {
            labelchaud1 = label_Total_Chaud1.Text;
            labelchaud2 = label_Total_Chaud2.Text;
            labelfroid = label_Total_Froid.Text;
            labelaucun = label_Total_Aucun.Text; 
            
        }

        private void Form_EncodageFactures_Load(object sender, EventArgs e) // 99% READY - FILL UP DATAGRIDS 
        {
            // requête du dataset pour remplir le datagridview
            this.tA_Remplir_CB_FormatEnvoieTableAdapter.Fill_FormatEnvoi(this.db_cantineDataSet.TA_Remplir_CB_FormatEnvoie);
            // requête du dataset pour remplir le datagridview
            this.tA_Listes_Personnes_query.Fill_Tuteurs(this.db_cantineDataSet.TA_Listes_Personnes);
            // pour adapter la largeur de colonnes
            dGdVw_DetailFamille.AutoResizeColumns();
            // pour élargir la dernière colonne horizontalement pour ne pas avoir une zone grise
            dGdVw_DetailFamille.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGdVw_DetailFamille.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_enfant_facturation.AutoResizeColumns();
            // initialiser recap tuteur
            initialiserRecapTuteur();
            // charge directement la liste des enfants
            dGdVw_DetailFamille_CellClick(null, null);

        }

        public void filtre(object sender, EventArgs e) // 99% READY -  FILTRE TUTEUR / ENFANT POUR DATAGRIDVIEW-MEMBRE 
        {
            // création de l'objet pour filtrer dataGridView
            Ctrl_EncodageFactures controle = new Ctrl_EncodageFactures();
            // appelle la méthode liée à la procédure stockée
            controle.filtreParNomParTel(ref dGdVw_DetailFamille, txtBx_RechNom.Text, txtBx_RechNumTel.Text);
            // charge directement la liste des enfants
            dGdVw_DetailFamille_CellClick(null, null);
        }

        private void dGdVw_DetailFamille_CellClick(object sender, DataGridViewCellEventArgs e) // 99% READY - Remplir DGV-Membre - Gestion date dernière clôture
        {
            // vider le tabcontrol et le recap tuteur
            tabDetail.TabPages.Clear();
            initialiserRecapTuteur();

            // débloquer zone selection periode
            groupBox1_selectperiode.Enabled = true;

            // capturer l'index de la ligne sélectionnée
            int indexLigne = dGdVw_DetailFamille.CurrentRow.Index;
            
            // création objet pour remplir datagridview
            Ctrl_EncodageFactures controle = new Ctrl_EncodageFactures();
            // appelle méthode qui affiche les tuteurs
            controle.afficheListeEnfantSelonSelection(ref dgv_enfant_facturation, ref dGdVw_DetailFamille, indexLigne);
            // pour adapter la largeur de colonnes
            dgv_enfant_facturation.AutoResizeColumns();
            dgv_enfant_facturation.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_enfant_facturation.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // appelle methode qui recherche la date dernière clôture
            label_dateCloture.Text = controle.get_DateCloture(ref dGdVw_DetailFamille, indexLigne);

            // mettre à jour les dateTimePicker du formulaire
            DateTime laDate; // pour y placer la date converti de puis la textbox
            if (DateTime.TryParse(label_dateCloture.Text, out laDate)) // renvoie "true" si la conversion en date est possible et affecte le résultat de la conversion à la variable "laDate"
            {
                //Attention d'abord fixer le min date avec la value! (car si la value est en dessous du min date=> plantage
                //On initialise d'abord pour éviter tout conflit
                dateTimePicker_debut.MinDate = DateTime.Parse("1979/01/01");
                dateTimePicker_fin.MinDate = DateTime.Now.AddDays(-1);
                dateTimePicker_fin.MaxDate = DateTime.Now.AddDays(10);
                if (laDate == DateTime.Now)
                {
                    dateTimePicker_debut.MinDate = laDate;
                }
                else
                {
                    dateTimePicker_debut.MinDate = laDate.AddDays(1);
                }
                dateTimePicker_debut.Value = laDate.AddDays(1); // initialisation à un jour après dernière date de clôture
                dateTimePicker_fin.MinDate = dateTimePicker_debut.Value;
                dateTimePicker_fin.Value = dateTimePicker_debut.Value.AddDays(1); // initialisation sur le lendemain de la cloturation
            }
            else
            {
            /* A MODIFIER SELON COMMENTAIRE */ dateTimePicker_debut.Value = DateTime.Now.AddDays(-5); // <- C'est faux, doit être initialisé au dernier repas déjà consommé s'il existe !!
            }
         }

        private void button_visualiser_Click(object sender, EventArgs e) // 99% READY - Gestion visualisation des détails enfants pour le tuteur
        {
            Ctrl_EncodageFactures controle = new Ctrl_EncodageFactures();
            lesEnfants.Clear();

            // la ligne du tuteur sélectionné
            DataGridViewRow ligneTuteur = dGdVw_DetailFamille.Rows[dGdVw_DetailFamille.CurrentRow.Index];
            // Periode du récapitulatif selon les dateTimePicker
            date_debut = dateTimePicker_debut.Value.ToString("yyyy-MM-dd");
            date_fin = dateTimePicker_fin.Value.ToString("yyyy-MM-dd");
            if (DateTime.Compare(dateTimePicker_debut.Value, dateTimePicker_fin.Value) == 1)
            {
                MessageBox.Show("Date de fin inférieure à la date de début.");
            }
            // afficher dans le titre du groupbox le tuteur concerné
            groupBox_recap.Text = "Récap pour le tuteur : " + ligneTuteur.Cells[1].Value.ToString() + " " + ligneTuteur.Cells[2].Value.ToString() ;
            // reset des pages du tabcontrol
            tabDetail.TabPages.Clear();
            // initialiser recap tuteur
            initialiserRecapTuteur();

            for (int i = 0; i < dgv_enfant_facturation.Rows.Count; i++) // TRAITEMENT INDIVIDUEL PAR ENFANT
            {
                //====Création de datagridView======================================================
                DataGridView dataGridView_historique = new DataGridView();      // Nouveau DataGridView pour afficher l'historique de chaque élève
                dataGridView_historique.ReadOnly = true; // juste la lecture dans le datagrid sans modification
                dataGridView_historique.Size = new System.Drawing.Size(460, 187); // la taille de datagridview          
                dataGridView_historique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;  // pour afficher tout la ligne dans le datagridview
                //==================================================================================

                // capturer l'identifiant de l'enfant
                int id_enfant = 0;
                Int32.TryParse(dgv_enfant_facturation.Rows[i].Cells[0].Value.ToString(), out id_enfant);

                // le nom de l'onglet du tab
                string nomPrenomEnfant = dgv_enfant_facturation.Rows[i].Cells[1].Value.ToString() + " " + dgv_enfant_facturation.Rows[i].Cells[2].Value.ToString();
                // créer le tab par enfant
                TabPage myTabPage = new TabPage(nomPrenomEnfant); // Nouvel onglet et le title pour afficher le nom et le prenom sur l'onglet 
                tabDetail.TabPages.Add(myTabPage); // J'ajoute l'onglet au tabcontrol

                DetailsEnfant unEnfant = new DetailsEnfant(id_enfant, date_debut, date_fin);
                DataTable details = controle.convertList(unEnfant.get_details());
                if (details.Rows.Count > 0)
                {
                    details.Columns[0].ColumnName = "Type de repas";
                    details.Columns[1].ColumnName = "Consomé le";
                    details.Columns[2].ColumnName = "Prix";

                    foreach (DataRow row in details.Rows)
                    {
                        switch (row["Type de repas"].ToString())
                        {
                            case "1": row["Type de repas"] = "repas chaud 1"; break;
                            case "2": row["Type de repas"] = "repas chaud 2"; break;
                            case "3": row["Type de repas"] = "repas froid"; break;
                            default: row["Type de repas"] = "aucun repas"; break;
                        }
                    }

                    // Binding datagirdview with datatable
                    dataGridView_historique.DataSource = details;

                    

                    // ajouter le dgv généré dans le tab
                    myTabPage.Controls.Add(dataGridView_historique); // J'ajoute le DataGridView à mon onglet fraichement crée avec les données chargés 

                    // Affichage du recap tuteur
                    // nombre de repas
                    label_chaud1.Text = (int.Parse(label_chaud1.Text) + unEnfant.get_nbRepas(1)).ToString();
                    label_chaud2.Text = (int.Parse(label_chaud2.Text) + unEnfant.get_nbRepas(2)).ToString();
                    label_froid.Text = (int.Parse(label_froid.Text) + unEnfant.get_nbRepas(3)).ToString();
                    label_aucun.Text = (int.Parse(label_aucun.Text) + unEnfant.get_nbRepas(4)).ToString();
                    // total par type de repas
                    label_Total_Chaud1.Text = (float.Parse(label_Total_Chaud1.Text.ToString().Trim(new char[] { '€' })) + unEnfant.get_totalPriceLunchType(1)).ToString() + " €";
                    label_Total_Chaud2.Text = (float.Parse(label_Total_Chaud2.Text.ToString().Trim(new char[] { '€' })) + unEnfant.get_totalPriceLunchType(2)).ToString() + " €";
                    label_Total_Froid.Text = (float.Parse(label_Total_Froid.Text.ToString().Trim(new char[] { '€' })) + unEnfant.get_totalPriceLunchType(3)).ToString() + " €";
                    label_Total_Aucun.Text = (float.Parse(label_Total_Aucun.Text.ToString().Trim(new char[] { '€' })) + unEnfant.get_totalPriceLunchType(4)).ToString() + " €";
                    // total global
                    label_prix.Text = (float.Parse(label_prix.Text.ToString().Trim(new char[] { '€' })) + unEnfant.get_totalPriceLunch()).ToString() + " €";

                    // Je conserve l'enfant en mémoire pour la création de facture
                    lesEnfants.Add(unEnfant);
                }
            }

            // gestion bouton "aperçu"
            if (label_prix.Text != "0 €")
            {
                btApercu.Enabled = true;
            }
        }

        private void btApercu_Click(object sender, EventArgs e) // 99% Ready - CREATION FACTURE 
        {
            if (dateTimePicker_fin.Value == DateTime.Now)
            {
                MessageBox.Show("Vous ne pouvez pas générer une facture incluant aujourd'hui!", "Au plus tard hier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Ctrl_EncodageFactures controle = new Ctrl_EncodageFactures();

                // capturer la periode de la facture définie
                DateTime debut = dateTimePicker_debut.Value;
                DateTime fin = dateTimePicker_fin.Value;

                // capturer l'index de la ligne cliqué
                int i = dGdVw_DetailFamille.CurrentRow.Index;

                // capturer la ligne cliqué
                DataGridViewRow lineSelected = dGdVw_DetailFamille.Rows[i];

                // initialisation des variables dont source est la ligne cliquée
                string codeClient = lineSelected.Cells[0].Value.ToString();
                string nomClient = lineSelected.Cells[1].Value.ToString();
                string prenomClient = lineSelected.Cells[2].Value.ToString();
                string adresseClient = lineSelected.Cells[4].Value.ToString();
                string villeClient = lineSelected.Cells[5].Value.ToString();
                string paysClient = lineSelected.Cells[6].Value.ToString();

                // initialiser le nouveau numéro de Facture
                int numeroFacture = controle.get_dernierNumeroFactureDisponible();

                // créer objet Facture
                ApercuFacture facture = new ApercuFacture();

                // créer facture avec Apercufacture.cs et récupérer chemin d'accès (path) de la facture créé
                String pathNouvelleFacture = facture.facture(lesEnfants, numeroFacture, debut, fin, codeClient, nomClient, prenomClient, adresseClient, villeClient, paysClient);

                // teste si le fichier a bien été creer           
                if (pathNouvelleFacture.LastIndexOf(".pdf") == -1)
                { // si je ne reçois pas un path, alors message d'erreur
                    MessageBox.Show(pathNouvelleFacture);
                }
                else
                {   // si je reçois un path, c'est ok
                    // MessageBox.Show("La création à bien été éffectué à l'adresse: " + pathNouvelleFacture);
                    // afficher facture avec programme externe
                    if (facture.affichageFacture(pathNouvelleFacture, true))
                    {
                        // sauvegarder facture
                        controle.saveFacture(pathNouvelleFacture, (float.Parse(label_prix.Text.Trim(new char[] { '€' })) * (1 + (controle.get_TVA() / 100))).ToString(), dateTimePicker_debut.Value.ToString("yyyyMMdd"), dateTimePicker_fin.Value.ToString("yyyyMMdd"), numeroFacture, codeClient);

                        path_facture = pathNouvelleFacture;
                        btEnvoi.Enabled = true;
                    }
                }
            }
        }

        private void initialiserRecapTuteur() // 99% - READY pour initialiser le labels de récap tuteur
        {
            label_chaud1.Text = "0";
            label_Total_Chaud1.Text = "0 €";

            label_chaud2.Text = "0";
            label_Total_Chaud2.Text = "0 €";

            label_froid.Text = "0";
            label_Total_Froid.Text = "0 €";

            label_aucun.Text = "0";
            label_Total_Aucun.Text = "0 €";

            label_prix.Text = "0 €";
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            initialiserRecapTuteur();
            tabDetail.TabPages.Clear();
        }

        private void btEnvoi_Click(object sender, EventArgs e)
        {
            ApercuFacture facture = new ApercuFacture();
            facture.affichageFacture(path_facture, false);
        }

    }
}
