using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using ProjetCantine.Models;
using System.Collections;
using ProjetCantine.Outils;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetCantine
{
    class ApercuFacture
    {

        public String facture( ArrayList lesEnfants, int facture_id, DateTime debut, DateTime fin
                            , string codeClient, string nomClient, string prenomClient
                            , string adresseClient, string villeClient, string paysClient)

        {

            try
            {
                // Création de l'objet de communication avec la db
                DbConnection dbTalk = new DbConnection();

                // Création de l'objet etablissement avec ses détails
                DetailsEtablissement etablissement = new DetailsEtablissement();

                // Récupération de la valeur de la TVA dans une variable
                String query = dbTalk.getQuery("tva");
                float tva = float.Parse(dbTalk.recupDataScalar(query));

                // Ouverture d'excel en mode caché et y intégrer le brouillon facture
                Excel.Application xlApp = new Excel.Application();
                xlApp.Visible = false;
                object misValue = System.Reflection.Missing.Value;

                // Initialisation du path vers le répertoire courant de l'exécutable
                string path = System.IO.Directory.GetCurrentDirectory();

                // Brouillon Facture.xlsx dans les Ressources du projet
                string pathFacture = path + @"\Resources\Facture.xlsx";

                // Chemin d'accès pour l'enregistrement des factures
                string pathSortie = @"C:\Factures";

                // Création de la facture
                // Ouvrir un workbook avec le brouillon
                Excel.Workbook wbk = xlApp.Workbooks.Open(pathFacture);
                Excel.Worksheet ws = new Excel.Worksheet();
                ws = (Excel.Worksheet)wbk.Worksheets[1];

                //Encodage établissement
                if (etablissement.get_nom().Length > 0) // Si l'objet contient au moins le nom, des données ont été insérées dans la db
                {
                    ws.Cells[7, "A"] = etablissement.get_nom();
                    ws.Cells[8, "A"] = etablissement.get_numEtRue();
                    ws.Cells[9, "A"] = etablissement.get_cpEtVille() + " (" + etablissement.get_pays() + ")";
                    ws.Cells[15, "A"] = "Mail : " + etablissement.get_courriel();
                    ws.Cells[11, "A"] = "Téléphone : " + etablissement.get_tel();
                    ws.Cells[13, "A"] = "Fax : " + etablissement.get_fax();
                    ws.Cells[48, "B"] = stringSplit(etablissement.get_banque_BE());
                    ws.Cells[49, "B"] = stringSplit(etablissement.get_bic_BE());
                    ws.Cells[48, "E"] = stringSplit(etablissement.get_banque_LU());
                    ws.Cells[49, "E"] = stringSplit(etablissement.get_bic_LU());
                }
                else // si non pas d'infos d'établissement (on peu refaire une nouvelle facture, mais celle-ci restera répertioré dans la db)
                {
                    ws.Cells[7, "A"] = "Aucun établissement est enregistré!";
                }

                // Insertion informations générales dans la facture
                ws.Cells[7, "D"] = facture_id; //N° facture
                ws.Cells[7, "E"] = DateTime.Today; // Date Facture
                ws.Cells[7, "F"] = codeClient; //Code Client
                ws.Cells[9, "D"] = nomClient + " " + prenomClient;
                ws.Cells[11, "D"] = adresseClient;
                ws.Cells[13, "D"] = villeClient + " " + paysClient;

                // Insertion période
                ws.Cells[20, "C"] = debut;
                ws.Cells[20, "E"] = fin;

                // Insertion du détail des repas par l'intermédiaire de l'objet "enfant"
                int reference = 0;
                int position = 22;

                foreach (DetailsEnfant enfant in lesEnfants)
                {
                    List<String[]> listePrix = enfant.get_priceList();

                    foreach (String[] details in listePrix)
                    {
                        if (details[1] != "0")
                        {
                            ws.Cells[position, "A"] = ++reference;
                            ws.Cells[position, "B"] = typeRepas(int.Parse(details[0]));
                            ws.Cells[position, "D"] = details[1];
                            ws.Cells[position, "E"] = float.Parse(details[2]);
                            position++;
                        }
                    }
                }

                // Affichage et calcul de montant de la tva
                ws.Cells[41, "D"] = "Montant de la TVA  à " + tva.ToString() + " %";
                ws.Cells[41, "G"] = float.Parse(ws.Cells[39, 7].Value.ToString()) * (tva / 100);

                // Mode de paiement et date d'échéance
                ws.Cells[17, 3] = "virement bancaire";
                ws.Cells[18, 3] = (DateTime.Now.AddDays(30)).ToString("dd/MM/yyyy");

                // sauvegarde et fermeture du programme
                if (File.Exists(pathSortie) == false)
                {
                    DirectoryInfo di = Directory.CreateDirectory(pathSortie);
                }

                // chemin d'accès de la facture
                pathSortie = pathSortie + "\\F_" + facture_id.ToString() + ".pdf";

                ws.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, pathSortie);

                wbk.Close(false, misValue, misValue);
                xlApp.Quit();

                releaseObject(ws);
                releaseObject(wbk);
                releaseObject(xlApp);

                return pathSortie;
                // Excel persiste, on le voit avec CTRL+ALT+DEL

            }
            catch (Exception msg)
            {
                return "Problème lors de la  phase de création du pdf :\r\n\r\n" + msg;
            }

        }


        private String typeRepas(int i) // pour afficher la dénomination au lieu de l'id des repas
        {
            String type = "";
            switch (i)
            {
                case 1:
                    type = "repas chaud 1";
                    break;
                case 2:
                    type = "repas chaud 2";
                    break;
                case 3:
                    type = "repas froid";
                    break;
                default:
                    type = "aucun repas";
                    break;
            }
            return type;
        }

        private String stringSplit(String thisString) // pour séparer par regrouppement de 4 caractères le compte bancaire et bic
        {
            String split = "";

            for(int i = 0; i< thisString.Length; i++)
            {
                if (i % 4 == 0 && i != 0)
                {
                    split += " ";
                }
                split += thisString[i];
            }

            return split;
        }

        private void releaseObject(object obj) // pour fermer les objets d'excel
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch
            {
                obj = null;
                //MessageBox.Show("Problème durant l'exportation\r\n Code erreur #EX02");
            }
            finally
            {
                GC.Collect();
            }
        }

        public void affichageFacture(String add) // affichage facture dans un programme tiers, par défaut du système client
        {
            try
            {
                // Amélioration à faire, une vue Form qui affiche le pdf de la facture
                // L'idée était présente, même avant d'enregistrer et envoyer avoir un aperçu
                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(add, "");
                System.Diagnostics.Process.Start(psi);
            }
            catch (SystemException exception)
            {
                MessageBox.Show("Facture introuvable ou innexistante : " + exception.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
